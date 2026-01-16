namespace FabrikaSunumProjesi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle gridStyleHeader = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle gridStyleRow = new System.Windows.Forms.DataGridViewCellStyle();

            // GENEL STİL AYARLARI
            gridStyleHeader.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            gridStyleHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            gridStyleHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            gridStyleHeader.ForeColor = System.Drawing.Color.White;
            gridStyleHeader.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            gridStyleHeader.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            gridStyleHeader.WrapMode = System.Windows.Forms.DataGridViewTriState.True;

            gridStyleRow.BackColor = System.Drawing.Color.WhiteSmoke;
            gridStyleRow.Font = new System.Drawing.Font("Segoe UI", 10F);
            gridStyleRow.ForeColor = System.Drawing.Color.Black;
            gridStyleRow.SelectionBackColor = System.Drawing.Color.SteelBlue;
            gridStyleRow.SelectionForeColor = System.Drawing.Color.White;

            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDepo = new System.Windows.Forms.TabPage();
            this.gridDepo = new System.Windows.Forms.DataGridView();
            this.tabUretim = new System.Windows.Forms.TabPage();
            this.lblTahminiMaliyet = new System.Windows.Forms.Label();
            this.gridReceteDetay = new System.Windows.Forms.DataGridView();
            this.btnUretimYap = new System.Windows.Forms.Button();
            this.numUretimAdet = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboUrunSec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridUrunKatalogu = new System.Windows.Forms.DataGridView();
            this.tabArge = new System.Windows.Forms.TabPage();
            this.btnYeniUrunKaydet = new System.Windows.Forms.Button();
            this.lblArgeTutar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYeniUrunAdi = new System.Windows.Forms.TextBox();
            this.btnMalzemeEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numMalzemeMiktar = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.gridYeniRecete = new System.Windows.Forms.DataGridView();
            this.gridHammddeSecimi = new System.Windows.Forms.DataGridView();

            // YÖNETİM
            this.tabYonetim = new System.Windows.Forms.TabPage();
            this.gridYonetim = new System.Windows.Forms.DataGridView();
            this.groupBoxIslemler = new System.Windows.Forms.GroupBox();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.btnFiyatGuncelle = new System.Windows.Forms.Button();
            this.txtYeniFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();

            this.tabLoglar = new System.Windows.Forms.TabPage();
            this.gridSistemLoglari = new System.Windows.Forms.DataGridView();

            this.tabControl1.SuspendLayout();
            this.tabDepo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepo)).BeginInit();
            this.tabUretim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReceteDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUretimAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunKatalogu)).BeginInit();
            this.tabArge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMalzemeMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridYeniRecete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHammddeSecimi)).BeginInit();

            this.tabYonetim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridYonetim)).BeginInit();
            this.groupBoxIslemler.SuspendLayout();

            this.tabLoglar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSistemLoglari)).BeginInit();
            this.SuspendLayout();

            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDepo);
            this.tabControl1.Controls.Add(this.tabUretim);
            this.tabControl1.Controls.Add(this.tabArge);
            this.tabControl1.Controls.Add(this.tabYonetim);
            this.tabControl1.Controls.Add(this.tabLoglar);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 700);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Padding = new System.Drawing.Point(12, 10);

            // 
            // tabDepo
            // 
            this.tabDepo.Controls.Add(this.gridDepo);
            this.tabDepo.Location = new System.Drawing.Point(4, 44);
            this.tabDepo.Name = "tabDepo";
            this.tabDepo.Padding = new System.Windows.Forms.Padding(10);
            this.tabDepo.Size = new System.Drawing.Size(1192, 652);
            this.tabDepo.Text = "  📦 DEPO STOKLARI  ";
            this.tabDepo.UseVisualStyleBackColor = true;

            // gridDepo (KİLİTLENDİ)
            this.gridDepo.ReadOnly = true; // ARTIK DÜZENLENEMEZ
            this.gridDepo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDepo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDepo.BackgroundColor = System.Drawing.Color.White;
            this.gridDepo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDepo.ColumnHeadersDefaultCellStyle = gridStyleHeader;
            this.gridDepo.DefaultCellStyle = gridStyleRow;
            this.gridDepo.EnableHeadersVisualStyles = false;
            this.gridDepo.RowHeadersVisible = false;
            this.gridDepo.RowTemplate.Height = 35;
            this.gridDepo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDepo.Name = "gridDepo";
            this.gridDepo.AllowUserToAddRows = false;
            this.gridDepo.AllowUserToDeleteRows = false;

            // 
            // tabUretim
            // 
            this.tabUretim.Controls.Add(this.lblTahminiMaliyet);
            this.tabUretim.Controls.Add(this.gridReceteDetay);
            this.tabUretim.Controls.Add(this.btnUretimYap);
            this.tabUretim.Controls.Add(this.numUretimAdet);
            this.tabUretim.Controls.Add(this.label2);
            this.tabUretim.Controls.Add(this.comboUrunSec);
            this.tabUretim.Controls.Add(this.label1);
            this.tabUretim.Controls.Add(this.gridUrunKatalogu);
            this.tabUretim.Location = new System.Drawing.Point(4, 44);
            this.tabUretim.Name = "tabUretim";
            this.tabUretim.Padding = new System.Windows.Forms.Padding(10);
            this.tabUretim.Size = new System.Drawing.Size(1192, 652);
            this.tabUretim.Text = "  🏭 ÜRETİM HATTI  ";
            this.tabUretim.UseVisualStyleBackColor = true;

            this.lblTahminiMaliyet.AutoSize = true;
            this.lblTahminiMaliyet.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTahminiMaliyet.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTahminiMaliyet.Location = new System.Drawing.Point(400, 20);
            this.lblTahminiMaliyet.Text = "Maliyet: 0 TL";

            // gridReceteDetay (KİLİTLENDİ)
            this.gridReceteDetay.ReadOnly = true;
            this.gridReceteDetay.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridReceteDetay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridReceteDetay.ColumnHeadersDefaultCellStyle = gridStyleHeader;
            this.gridReceteDetay.DefaultCellStyle = gridStyleRow;
            this.gridReceteDetay.EnableHeadersVisualStyles = false;
            this.gridReceteDetay.RowHeadersVisible = false;
            this.gridReceteDetay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridReceteDetay.Location = new System.Drawing.Point(400, 60);
            this.gridReceteDetay.Size = new System.Drawing.Size(770, 140);
            this.gridReceteDetay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.gridReceteDetay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridReceteDetay.AllowUserToAddRows = false;
            this.gridReceteDetay.AllowUserToDeleteRows = false;

            this.btnUretimYap.BackColor = System.Drawing.Color.SeaGreen;
            this.btnUretimYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUretimYap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnUretimYap.ForeColor = System.Drawing.Color.White;
            this.btnUretimYap.Location = new System.Drawing.Point(23, 130);
            this.btnUretimYap.Size = new System.Drawing.Size(350, 60);
            this.btnUretimYap.Text = "⚡ ÜRETİMİ BAŞLAT";
            this.btnUretimYap.Click += new System.EventHandler(this.btnUretimYap_Click);

            this.numUretimAdet.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.numUretimAdet.Location = new System.Drawing.Point(100, 78);
            this.numUretimAdet.Size = new System.Drawing.Size(180, 29);
            this.numUretimAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUretimAdet.ValueChanged += new System.EventHandler(this.numUretimAdet_ValueChanged);

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 82);
            this.label2.Text = "Adet:";

            this.comboUrunSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUrunSec.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboUrunSec.Location = new System.Drawing.Point(100, 25);
            this.comboUrunSec.Size = new System.Drawing.Size(273, 29);
            this.comboUrunSec.SelectedIndexChanged += new System.EventHandler(this.comboUrunSec_SelectedIndexChanged);

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Text = "Ürün:";

            // gridUrunKatalogu (KİLİTLENDİ)
            this.gridUrunKatalogu.ReadOnly = true;
            this.gridUrunKatalogu.BackgroundColor = System.Drawing.Color.White;
            this.gridUrunKatalogu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridUrunKatalogu.ColumnHeadersDefaultCellStyle = gridStyleHeader;
            this.gridUrunKatalogu.DefaultCellStyle = gridStyleRow;
            this.gridUrunKatalogu.EnableHeadersVisualStyles = false;
            this.gridUrunKatalogu.RowHeadersVisible = false;
            this.gridUrunKatalogu.RowTemplate.Height = 35;
            this.gridUrunKatalogu.Location = new System.Drawing.Point(10, 220);
            this.gridUrunKatalogu.Size = new System.Drawing.Size(1170, 420);
            this.gridUrunKatalogu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUrunKatalogu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUrunKatalogu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUrunKatalogu.AllowUserToAddRows = false;
            this.gridUrunKatalogu.AllowUserToDeleteRows = false;

            // 
            // tabArge
            // 
            this.tabArge.Controls.Add(this.btnYeniUrunKaydet);
            this.tabArge.Controls.Add(this.lblArgeTutar);
            this.tabArge.Controls.Add(this.label5);
            this.tabArge.Controls.Add(this.txtYeniUrunAdi);
            this.tabArge.Controls.Add(this.btnMalzemeEkle);
            this.tabArge.Controls.Add(this.label4);
            this.tabArge.Controls.Add(this.numMalzemeMiktar);
            this.tabArge.Controls.Add(this.label3);
            this.tabArge.Controls.Add(this.gridYeniRecete);
            this.tabArge.Controls.Add(this.gridHammddeSecimi);
            this.tabArge.Location = new System.Drawing.Point(4, 44);
            this.tabArge.Name = "tabArge";
            this.tabArge.Padding = new System.Windows.Forms.Padding(10);
            this.tabArge.Size = new System.Drawing.Size(1192, 652);
            this.tabArge.Text = "  🧪 AR-GE & YENİ ÜRÜN  ";
            this.tabArge.UseVisualStyleBackColor = true;

            this.btnYeniUrunKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYeniUrunKaydet.BackColor = System.Drawing.Color.DarkOrange;
            this.btnYeniUrunKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniUrunKaydet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnYeniUrunKaydet.ForeColor = System.Drawing.Color.White;
            this.btnYeniUrunKaydet.Location = new System.Drawing.Point(920, 15);
            this.btnYeniUrunKaydet.Size = new System.Drawing.Size(250, 60);
            this.btnYeniUrunKaydet.Text = "💾 SİSTEME KAYDET";
            this.btnYeniUrunKaydet.Click += new System.EventHandler(this.btnYeniUrunKaydet_Click);

            this.lblArgeTutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArgeTutar.AutoSize = true;
            this.lblArgeTutar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblArgeTutar.ForeColor = System.Drawing.Color.DarkRed;
            this.lblArgeTutar.Location = new System.Drawing.Point(680, 25);
            this.lblArgeTutar.Text = "Maliyet: 0 TL";

            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 34);
            this.label5.Text = "Yeni Ürün Adı:";

            this.txtYeniUrunAdi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtYeniUrunAdi.Location = new System.Drawing.Point(140, 31);
            this.txtYeniUrunAdi.Size = new System.Drawing.Size(400, 29);

            this.btnMalzemeEkle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMalzemeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMalzemeEkle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMalzemeEkle.ForeColor = System.Drawing.Color.White;
            this.btnMalzemeEkle.Location = new System.Drawing.Point(580, 300);
            this.btnMalzemeEkle.Size = new System.Drawing.Size(100, 50);
            this.btnMalzemeEkle.Text = "EKLE >>";
            this.btnMalzemeEkle.Click += new System.EventHandler(this.btnMalzemeEkle_Click);

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 240);
            this.label4.Text = "Miktar:";

            this.numMalzemeMiktar.Location = new System.Drawing.Point(580, 265);
            this.numMalzemeMiktar.Size = new System.Drawing.Size(100, 25);
            this.numMalzemeMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(700, 85);
            this.label3.Text = "YENİ ÜRÜN REÇETE LİSTESİ";

            // gridYeniRecete (KİLİTLENDİ)
            this.gridYeniRecete.ReadOnly = true;
            this.gridYeniRecete.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridYeniRecete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridYeniRecete.ColumnHeadersDefaultCellStyle = gridStyleHeader;
            this.gridYeniRecete.DefaultCellStyle = gridStyleRow;
            this.gridYeniRecete.EnableHeadersVisualStyles = false;
            this.gridYeniRecete.RowHeadersVisible = false;
            this.gridYeniRecete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridYeniRecete.Location = new System.Drawing.Point(704, 110);
            this.gridYeniRecete.Size = new System.Drawing.Size(465, 520);
            this.gridYeniRecete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.gridYeniRecete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridYeniRecete.AllowUserToAddRows = false;
            this.gridYeniRecete.AllowUserToDeleteRows = false;

            // gridHammddeSecimi (KİLİTLENDİ)
            this.gridHammddeSecimi.ReadOnly = true;
            this.gridHammddeSecimi.BackgroundColor = System.Drawing.Color.White;
            this.gridHammddeSecimi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridHammddeSecimi.ColumnHeadersDefaultCellStyle = gridStyleHeader;
            this.gridHammddeSecimi.DefaultCellStyle = gridStyleRow;
            this.gridHammddeSecimi.EnableHeadersVisualStyles = false;
            this.gridHammddeSecimi.RowHeadersVisible = false;
            this.gridHammddeSecimi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridHammddeSecimi.Location = new System.Drawing.Point(13, 110);
            this.gridHammddeSecimi.Size = new System.Drawing.Size(550, 520);
            this.gridHammddeSecimi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.gridHammddeSecimi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridHammddeSecimi.AllowUserToAddRows = false;
            this.gridHammddeSecimi.AllowUserToDeleteRows = false;

            // 
            // tabYonetim
            // 
            this.tabYonetim.Controls.Add(this.gridYonetim);
            this.tabYonetim.Controls.Add(this.groupBoxIslemler);
            this.tabYonetim.Location = new System.Drawing.Point(4, 44);
            this.tabYonetim.Name = "tabYonetim";
            this.tabYonetim.Padding = new System.Windows.Forms.Padding(10);
            this.tabYonetim.Size = new System.Drawing.Size(1192, 652);
            this.tabYonetim.Text = "  ⚙️ YÖNETİM PANELİ  ";
            this.tabYonetim.UseVisualStyleBackColor = true;

            // gridYonetim (KİLİTLENDİ)
            this.gridYonetim.ReadOnly = true;
            this.gridYonetim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridYonetim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridYonetim.BackgroundColor = System.Drawing.Color.White;
            this.gridYonetim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridYonetim.ColumnHeadersDefaultCellStyle = gridStyleHeader;
            this.gridYonetim.DefaultCellStyle = gridStyleRow;
            this.gridYonetim.EnableHeadersVisualStyles = false;
            this.gridYonetim.RowHeadersVisible = false;
            this.gridYonetim.RowTemplate.Height = 35;
            this.gridYonetim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridYonetim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridYonetim_CellClick);
            this.gridYonetim.AllowUserToAddRows = false;
            this.gridYonetim.AllowUserToDeleteRows = false;

            this.groupBoxIslemler.Controls.Add(this.btnUrunSil);
            this.groupBoxIslemler.Controls.Add(this.btnFiyatGuncelle);
            this.groupBoxIslemler.Controls.Add(this.txtYeniFiyat);
            this.groupBoxIslemler.Controls.Add(this.label6);
            this.groupBoxIslemler.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxIslemler.Width = 350;
            this.groupBoxIslemler.Text = "Seçili Ürün İşlemleri";
            this.groupBoxIslemler.Padding = new System.Windows.Forms.Padding(10);

            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 50);
            this.label6.Text = "Yeni Satış Fiyatı:";

            this.txtYeniFiyat.Location = new System.Drawing.Point(150, 47);
            this.txtYeniFiyat.Width = 150;
            this.txtYeniFiyat.Font = new System.Drawing.Font("Segoe UI", 11F);

            this.btnFiyatGuncelle.Text = "💰 FİYATI GÜNCELLE";
            this.btnFiyatGuncelle.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFiyatGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnFiyatGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiyatGuncelle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnFiyatGuncelle.Location = new System.Drawing.Point(24, 100);
            this.btnFiyatGuncelle.Size = new System.Drawing.Size(300, 50);
            this.btnFiyatGuncelle.Click += new System.EventHandler(this.btnFiyatGuncelle_Click);

            this.btnUrunSil.Text = "❌ ÜRÜNÜ SİL";
            this.btnUrunSil.BackColor = System.Drawing.Color.Crimson;
            this.btnUrunSil.ForeColor = System.Drawing.Color.White;
            this.btnUrunSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunSil.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnUrunSil.Location = new System.Drawing.Point(24, 200);
            this.btnUrunSil.Size = new System.Drawing.Size(300, 50);
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);

            // 
            // tabLoglar
            // 
            this.tabLoglar.Controls.Add(this.gridSistemLoglari);
            this.tabLoglar.Location = new System.Drawing.Point(4, 44);
            this.tabLoglar.Name = "tabLoglar";
            this.tabLoglar.Padding = new System.Windows.Forms.Padding(10);
            this.tabLoglar.Size = new System.Drawing.Size(1192, 652);
            this.tabLoglar.Text = "  📋 İŞLEM GEÇMİŞİ  ";
            this.tabLoglar.UseVisualStyleBackColor = true;

            // gridSistemLoglari (KİLİTLENDİ)
            this.gridSistemLoglari.ReadOnly = true;
            this.gridSistemLoglari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSistemLoglari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSistemLoglari.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.gridSistemLoglari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSistemLoglari.AllowUserToAddRows = false;
            this.gridSistemLoglari.AllowUserToDeleteRows = false;

            System.Windows.Forms.DataGridViewCellStyle logHeader = new System.Windows.Forms.DataGridViewCellStyle();
            logHeader.BackColor = System.Drawing.Color.Black;
            logHeader.ForeColor = System.Drawing.Color.Lime;
            logHeader.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.gridSistemLoglari.ColumnHeadersDefaultCellStyle = logHeader;

            System.Windows.Forms.DataGridViewCellStyle logRow = new System.Windows.Forms.DataGridViewCellStyle();
            logRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            logRow.ForeColor = System.Drawing.Color.LightGreen;
            logRow.Font = new System.Drawing.Font("Consolas", 10F);
            logRow.SelectionBackColor = System.Drawing.Color.DarkGreen;
            logRow.SelectionForeColor = System.Drawing.Color.White;
            this.gridSistemLoglari.DefaultCellStyle = logRow;

            this.gridSistemLoglari.EnableHeadersVisualStyles = false;
            this.gridSistemLoglari.RowHeadersVisible = false;
            this.gridSistemLoglari.RowTemplate.Height = 30;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fabrika Üretim Otomasyonu v2024 (Profesyonel Sürüm)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDepo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDepo)).EndInit();
            this.tabUretim.ResumeLayout(false);
            this.tabUretim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReceteDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUretimAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunKatalogu)).EndInit();
            this.tabArge.ResumeLayout(false);
            this.tabArge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMalzemeMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridYeniRecete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHammddeSecimi)).EndInit();

            this.tabYonetim.ResumeLayout(false);
            this.tabYonetim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridYonetim)).EndInit();
            this.groupBoxIslemler.ResumeLayout(false);
            this.groupBoxIslemler.PerformLayout();

            this.tabLoglar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSistemLoglari)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDepo;
        private System.Windows.Forms.TabPage tabUretim;
        private System.Windows.Forms.TabPage tabArge;
        private System.Windows.Forms.TabPage tabYonetim;
        private System.Windows.Forms.TabPage tabLoglar;

        private System.Windows.Forms.DataGridView gridDepo;
        private System.Windows.Forms.DataGridView gridReceteDetay;
        private System.Windows.Forms.Button btnUretimYap;
        private System.Windows.Forms.NumericUpDown numUretimAdet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboUrunSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridUrunKatalogu;
        private System.Windows.Forms.Button btnYeniUrunKaydet;
        private System.Windows.Forms.Label lblArgeTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYeniUrunAdi;
        private System.Windows.Forms.Button btnMalzemeEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numMalzemeMiktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridYeniRecete;
        private System.Windows.Forms.DataGridView gridHammddeSecimi;
        private System.Windows.Forms.DataGridView gridSistemLoglari;
        private System.Windows.Forms.Label lblTahminiMaliyet;

        private System.Windows.Forms.DataGridView gridYonetim;
        private System.Windows.Forms.GroupBox groupBoxIslemler;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Button btnFiyatGuncelle;
        private System.Windows.Forms.TextBox txtYeniFiyat;
        private System.Windows.Forms.Label label6;
    }
}