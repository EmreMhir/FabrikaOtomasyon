using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FabrikaSunumProjesi
{
    public partial class Form1 : Form
    {
        // VERİTABANI BAĞLANTISI
        string baglanti = "Server=localhost;Database=FabrikaSunumDB;Uid=root;Pwd=1234;";

        DataTable dtArgeSepeti = new DataTable();
        double argeToplamTutar = 0;

        // Yönetim Paneli için seçilen ürünün ID'sini tutacak değişken
        int seciliYonetimUrunID = -1;

        public Form1()
        {
            InitializeComponent();
            ArgeTablosunuHazirla();
            // Program açılırken verileri çekiyoruz.
            TumVerileriGuncelle();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        // 1. VERİLERİ ÇEKME (REFRESH)
        void TumVerileriGuncelle()
        {
            using (MySqlConnection conn = new MySqlConnection(baglanti))
            {
                try
                {
                    conn.Open();

                    // A) DEPO TABLOSU
                    MySqlDataAdapter daDepo = new MySqlDataAdapter("SELECT * FROM Tbl_Depo_Hammaddeler", conn);
                    DataTable dtDepo = new DataTable();
                    daDepo.Fill(dtDepo);
                    if (gridDepo != null) gridDepo.DataSource = dtDepo;
                    if (gridHammddeSecimi != null) gridHammddeSecimi.DataSource = dtDepo;

                    // B) ÜRÜN KATALOĞU (Hem Üretim hem Yönetim sekmesi için)
                    MySqlDataAdapter daUrun = new MySqlDataAdapter("SELECT * FROM Tbl_Satis_Urunleri", conn);
                    DataTable dtUrun = new DataTable();
                    daUrun.Fill(dtUrun);

                    // Üretim Sekmesindeki Grid
                    if (gridUrunKatalogu != null) gridUrunKatalogu.DataSource = dtUrun;

                    // Yönetim Sekmesindeki Grid
                    if (gridYonetim != null) gridYonetim.DataSource = dtUrun;

                    // C) COMBOBOX DOLDURMA
                    if (comboUrunSec != null)
                    {
                        // Olayı geçici durdur (Hata vermemesi için)
                        comboUrunSec.SelectedIndexChanged -= comboUrunSec_SelectedIndexChanged;

                        comboUrunSec.DataSource = dtUrun;
                        comboUrunSec.DisplayMember = "UrunAdi";
                        comboUrunSec.ValueMember = "UrunID";

                        // Olayı tekrar aç
                        comboUrunSec.SelectedIndexChanged += comboUrunSec_SelectedIndexChanged;
                    }

                    // D) LOGLAR
                    if (gridSistemLoglari != null)
                    {
                        string sql = "SELECT * FROM Tbl_Sistem_Loglari ORDER BY TarihSaat DESC";
                        MySqlDataAdapter daLog = new MySqlDataAdapter(sql, conn);
                        DataTable dtLog = new DataTable();
                        daLog.Fill(dtLog);
                        gridSistemLoglari.DataSource = dtLog;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı Bağlantı Hatası: " + ex.Message);
                }
            }
        }

        // 2. YÖNETİM PANELİ İŞLEMLERİ

        // Tablodan bir satıra tıklayınca bilgileri al
        private void gridYonetim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Tıklanan satırı al
                DataGridViewRow row = gridYonetim.Rows[e.RowIndex];

                // ID'yi değişkene ata (Hata kontrolü ile)
                if (row.Cells["UrunID"].Value != null)
                {
                    seciliYonetimUrunID = Convert.ToInt32(row.Cells["UrunID"].Value);
                    txtYeniFiyat.Text = row.Cells["SatisFiyati"].Value.ToString();
                }
            }
        }

        // Fiyat Güncelle Butonu
        private void btnFiyatGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliYonetimUrunID == -1)
            {
                MessageBox.Show("Lütfen listeden bir ürün seçiniz.");
                return;
            }

            try
            {
                decimal yeniFiyat = Convert.ToDecimal(txtYeniFiyat.Text);

                using (MySqlConnection conn = new MySqlConnection(baglanti))
                {
                    conn.Open();
                    string sql = "UPDATE Tbl_Satis_Urunleri SET SatisFiyati=@fiyat WHERE UrunID=@id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@fiyat", yeniFiyat);
                    cmd.Parameters.AddWithValue("@id", seciliYonetimUrunID);
                    cmd.ExecuteNonQuery();

                    // Log Tut
                    MySqlCommand cmdLog = new MySqlCommand("sp_LogKaydet", conn);
                    cmdLog.CommandType = CommandType.StoredProcedure;
                    cmdLog.Parameters.AddWithValue("p_Tur", "FIYAT_GUNCELLEME");
                    cmdLog.Parameters.AddWithValue("p_Detay", "Ürün ID: " + seciliYonetimUrunID + " fiyatı güncellendi: " + yeniFiyat);
                    cmdLog.ExecuteNonQuery();
                }

                MessageBox.Show("✅ Fiyat Başarıyla Güncellendi!");
                TumVerileriGuncelle(); // Listeyi yenile
            }
            catch
            {
                MessageBox.Show("Lütfen geçerli bir fiyat giriniz (Örn: 1500,50)");
            }
        }

        // Ürün Sil Butonu
        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (seciliYonetimUrunID == -1)
            {
                MessageBox.Show("Lütfen silinecek ürünü seçiniz.");
                return;
            }

            DialogResult cevap = MessageBox.Show("Bu ürünü ve reçetesini kalıcı olarak silmek istiyor musunuz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(baglanti))
                {
                    try
                    {
                        conn.Open();

                        // 1. Önce Reçeteyi Sil (Bağımlılığı kaldır)
                        string sqlReceteSil = "DELETE FROM Tbl_Uretim_Receteleri WHERE UrunID=@id";
                        MySqlCommand cmd1 = new MySqlCommand(sqlReceteSil, conn);
                        cmd1.Parameters.AddWithValue("@id", seciliYonetimUrunID);
                        cmd1.ExecuteNonQuery();

                        // 2. Sonra Ürünü Sil
                        string sqlUrunSil = "DELETE FROM Tbl_Satis_Urunleri WHERE UrunID=@id";
                        MySqlCommand cmd2 = new MySqlCommand(sqlUrunSil, conn);
                        cmd2.Parameters.AddWithValue("@id", seciliYonetimUrunID);
                        cmd2.ExecuteNonQuery();

                        // 3. Log Tut
                        MySqlCommand cmdLog = new MySqlCommand("sp_LogKaydet", conn);
                        cmdLog.CommandType = CommandType.StoredProcedure;
                        cmdLog.Parameters.AddWithValue("p_Tur", "URUN_SILME");
                        cmdLog.Parameters.AddWithValue("p_Detay", "Ürün ID: " + seciliYonetimUrunID + " sistemden silindi.");
                        cmdLog.ExecuteNonQuery();

                        MessageBox.Show("🗑️ Ürün Silindi.");

                        // Temizlik
                        seciliYonetimUrunID = -1;
                        txtYeniFiyat.Text = "";
                        TumVerileriGuncelle();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Silme Hatası: " + ex.Message);
                    }
                }
            }
        }

        // 3. MALİYET HESAPLAMA & ÜRETİM
        void MaliyetHesapla()
        {
            if (comboUrunSec.SelectedValue == null) return;

            try
            {
                // Seçilen değerin veri tipi kontrolü (Açılış hatasını önler)
                if (comboUrunSec.SelectedValue is DataRowView) return;

                int urunID = Convert.ToInt32(comboUrunSec.SelectedValue);
                int adet = (int)numUretimAdet.Value;

                if (adet <= 0)
                {
                    lblTahminiMaliyet.Text = "Tahmini Maliyet: 0 TL";
                    if (gridReceteDetay != null) gridReceteDetay.DataSource = null;
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(baglanti))
                {
                    conn.Open();
                    string sqlToplam = @"SELECT SUM(R.GerekliMiktar * H.BirimMaliyet) 
                                         FROM Tbl_Uretim_Receteleri R 
                                         JOIN Tbl_Depo_Hammaddeler H ON R.HammaddeID = H.HammaddeID 
                                         WHERE R.UrunID = @uid";
                    MySqlCommand cmd = new MySqlCommand(sqlToplam, conn);
                    cmd.Parameters.AddWithValue("@uid", urunID);
                    object sonuc = cmd.ExecuteScalar();

                    if (sonuc != DBNull.Value && sonuc != null)
                    {
                        double birimMaliyet = Convert.ToDouble(sonuc);
                        lblTahminiMaliyet.Text = "Tahmini Maliyet: " + (birimMaliyet * adet).ToString("C2");

                        string sqlDetay = @"SELECT H.Ad as 'Malzeme', 
                                            (R.GerekliMiktar * @adet) as 'Gereken Miktar', 
                                            H.BirimMaliyet as 'Birim Fiyat', 
                                            (R.GerekliMiktar * @adet * H.BirimMaliyet) as 'Toplam Tutar'
                                            FROM Tbl_Uretim_Receteleri R 
                                            JOIN Tbl_Depo_Hammaddeler H ON R.HammaddeID = H.HammaddeID 
                                            WHERE R.UrunID = @uid";
                        MySqlDataAdapter da = new MySqlDataAdapter(sqlDetay, conn);
                        da.SelectCommand.Parameters.AddWithValue("@uid", urunID);
                        da.SelectCommand.Parameters.AddWithValue("@adet", adet);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (gridReceteDetay != null) gridReceteDetay.DataSource = dt;
                    }
                    else
                    {
                        lblTahminiMaliyet.Text = "Maliyet Hesaplanamadı (Reçete Yok)";
                    }
                }
            }
            catch { }
        }

        private void comboUrunSec_SelectedIndexChanged(object sender, EventArgs e) { MaliyetHesapla(); }
        private void numUretimAdet_ValueChanged(object sender, EventArgs e) { MaliyetHesapla(); }

        private void btnUretimYap_Click(object sender, EventArgs e)
        {
            if (comboUrunSec.SelectedValue == null) return;
            int urunID = Convert.ToInt32(comboUrunSec.SelectedValue);
            int adet = (int)numUretimAdet.Value;

            if (adet <= 0) { MessageBox.Show("Lütfen en az 1 adet giriniz."); return; }

            using (MySqlConnection conn = new MySqlConnection(baglanti))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("sp_UretimGerceklestir", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_UrunID", urunID);
                    cmd.Parameters.AddWithValue("p_Adet", adet);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("✅ Üretim Başarıyla Tamamlandı!\nStoklar güncellendi.");
                    TumVerileriGuncelle();
                    MaliyetHesapla();
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Yetersiz Stok"))
                        MessageBox.Show("⛔ Stok Yetersiz! Üretim yapılamadı.\n(Bu durum Loglara kaydedildi)");
                    else
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);

                    TumVerileriGuncelle();
                }
            }
        }

        // 4. AR-GE BÖLÜMÜ (Yeni Ürün)
        void ArgeTablosunuHazirla()
        {
            dtArgeSepeti.Columns.Add("HammaddeID", typeof(int));
            dtArgeSepeti.Columns.Add("MalzemeAdi", typeof(string));
            dtArgeSepeti.Columns.Add("Miktar", typeof(double));
            dtArgeSepeti.Columns.Add("Tutar", typeof(double));
            gridYeniRecete.DataSource = dtArgeSepeti;
        }

        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {
            if (gridHammddeSecimi.SelectedRows.Count == 0) return;
            double miktar = (double)numMalzemeMiktar.Value;
            if (miktar <= 0) { MessageBox.Show("Miktar girin."); return; }

            var satir = gridHammddeSecimi.SelectedRows[0];
            int id = Convert.ToInt32(satir.Cells["HammaddeID"].Value);
            string ad = satir.Cells["Ad"].Value.ToString();
            double fiyat = Convert.ToDouble(satir.Cells["BirimMaliyet"].Value);
            double tutar = miktar * fiyat;

            dtArgeSepeti.Rows.Add(id, ad, miktar, tutar);
            argeToplamTutar += tutar;
            lblArgeTutar.Text = "Maliyet: " + argeToplamTutar.ToString("C2");
        }

        private void btnYeniUrunKaydet_Click(object sender, EventArgs e)
        {
            if (txtYeniUrunAdi.Text == "" || dtArgeSepeti.Rows.Count == 0)
            {
                MessageBox.Show("Lütfen ürün adı girin ve malzeme ekleyin.");
                return;
            }

            string yeniBarkod = "ARGE-" + DateTime.Now.ToString("HHmmss");

            using (MySqlConnection conn = new MySqlConnection(baglanti))
            {
                conn.Open();
                MySqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // 1. Ürün Ekle
                    string sqlUrun = "INSERT INTO Tbl_Satis_Urunleri (UrunAdi, BarkodNo, SatisFiyati, StoktakiUrunSayisi, Kategori) VALUES (@ad, @bar, @fiyat, 0, 'Ozel')";
                    MySqlCommand cmd = new MySqlCommand(sqlUrun, conn, trans);
                    cmd.Parameters.AddWithValue("@ad", txtYeniUrunAdi.Text);
                    cmd.Parameters.AddWithValue("@bar", yeniBarkod);
                    cmd.Parameters.AddWithValue("@fiyat", argeToplamTutar * 1.5);
                    cmd.ExecuteNonQuery();
                    long yeniID = cmd.LastInsertedId;

                    // 2. Reçete Ekle
                    foreach (DataRow row in dtArgeSepeti.Rows)
                    {
                        string sqlRecete = "INSERT INTO Tbl_Uretim_Receteleri (UrunID, HammaddeID, GerekliMiktar) VALUES (@u, @h, @m)";
                        MySqlCommand cmd2 = new MySqlCommand(sqlRecete, conn, trans);
                        cmd2.Parameters.AddWithValue("@u", yeniID);
                        cmd2.Parameters.AddWithValue("@h", row["HammaddeID"]);
                        cmd2.Parameters.AddWithValue("@m", row["Miktar"]);
                        cmd2.ExecuteNonQuery();
                    }

                    // 3. Log Kaydet
                    MySqlCommand cmd3 = new MySqlCommand("sp_LogKaydet", conn, trans);
                    cmd3.CommandType = CommandType.StoredProcedure;
                    cmd3.Parameters.AddWithValue("p_Tur", "YENI_URUN");
                    cmd3.Parameters.AddWithValue("p_Detay", txtYeniUrunAdi.Text + " oluşturuldu. Barkod: " + yeniBarkod);
                    cmd3.ExecuteNonQuery();

                    trans.Commit();
                    MessageBox.Show("✅ Yeni Ürün Başarıyla Eklendi!\nBarkod: " + yeniBarkod);

                    dtArgeSepeti.Rows.Clear();
                    argeToplamTutar = 0;
                    lblArgeTutar.Text = "0 TL";
                    txtYeniUrunAdi.Text = "";
                    TumVerileriGuncelle();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}