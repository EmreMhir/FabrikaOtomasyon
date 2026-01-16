CREATE DATABASE FabrikaSunumDB;
USE FabrikaSunumDB;

-- 1. TABLOLAR

-- Tablo 1: Depodaki Malzemeler
CREATE TABLE Tbl_Depo_Hammaddeler (
    HammaddeID INT AUTO_INCREMENT PRIMARY KEY,
    Ad VARCHAR(100),
    Birim VARCHAR(20),            
    StokMiktari DOUBLE DEFAULT 0, 
    BirimMaliyet DECIMAL(10,2)    
);

-- Tablo 2: Satılacak Ürünler Kataloğu
CREATE TABLE Tbl_Satis_Urunleri (
    UrunID INT AUTO_INCREMENT PRIMARY KEY,
    UrunAdi VARCHAR(100),
    BarkodNo VARCHAR(50),         
    SatisFiyati DECIMAL(10,2),
    StoktakiUrunSayisi INT DEFAULT 0,
    Kategori VARCHAR(30) DEFAULT 'Standart' 
);

-- Tablo 3: Reçeteler
CREATE TABLE Tbl_Uretim_Receteleri (
    ReceteID INT AUTO_INCREMENT PRIMARY KEY,
    UrunID INT,
    HammaddeID INT,
    GerekliMiktar DOUBLE,
    FOREIGN KEY (UrunID) REFERENCES Tbl_Satis_Urunleri(UrunID),
    FOREIGN KEY (HammaddeID) REFERENCES Tbl_Depo_Hammaddeler(HammaddeID)
);

-- Tablo 4: Sistem Logları
CREATE TABLE Tbl_Sistem_Loglari (
    LogID INT AUTO_INCREMENT PRIMARY KEY,
    IslemTuru VARCHAR(50),        
    IslemDetayi TEXT,             
    TarihSaat DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- 2. AKILLI ROBOTLAR

DELIMITER //

-- Fonksiyon A: Log Kaydetme
CREATE PROCEDURE sp_LogKaydet(IN p_Tur VARCHAR(50), IN p_Detay TEXT)
BEGIN
    INSERT INTO Tbl_Sistem_Loglari (IslemTuru, IslemDetayi) VALUES (p_Tur, p_Detay);
END //

-- Fonksiyon B: Üretim Yapma (Stok Kontrollü)
CREATE PROCEDURE sp_UretimGerceklestir(IN p_UrunID INT, IN p_Adet INT)
BEGIN
    DECLARE StokYetersizMi INT DEFAULT 0;
    DECLARE EksikMalzemeler VARCHAR(255) DEFAULT '';
    DECLARE UrunIsmi VARCHAR(100);

    SELECT UrunAdi INTO UrunIsmi FROM Tbl_Satis_Urunleri WHERE UrunID = p_UrunID;

    -- Stok Yeterli mi Kontrolü
    SELECT COUNT(*), GROUP_CONCAT(H.Ad SEPARATOR ', ') 
    INTO StokYetersizMi, EksikMalzemeler
    FROM Tbl_Uretim_Receteleri R 
    JOIN Tbl_Depo_Hammaddeler H ON R.HammaddeID = H.HammaddeID
    WHERE R.UrunID = p_UrunID 
    AND (R.GerekliMiktar * p_Adet) > H.StokMiktari;

    IF StokYetersizMi > 0 THEN
        -- Yetersizse Log Tut
        INSERT INTO Tbl_Sistem_Loglari (IslemTuru, IslemDetayi) 
        VALUES ('HATA', CONCAT(UrunIsmi, ' üretilemedi. Eksik: ', EksikMalzemeler));
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Yetersiz Stok';
    ELSE
        -- Yeterliyse Üretimi Yap
        START TRANSACTION;
            UPDATE Tbl_Depo_Hammaddeler H 
            JOIN Tbl_Uretim_Receteleri R ON H.HammaddeID = R.HammaddeID
            SET H.StokMiktari = H.StokMiktari - (R.GerekliMiktar * p_Adet)
            WHERE R.UrunID = p_UrunID;

            UPDATE Tbl_Satis_Urunleri 
            SET StoktakiUrunSayisi = StoktakiUrunSayisi + p_Adet 
            WHERE UrunID = p_UrunID;

            INSERT INTO Tbl_Sistem_Loglari (IslemTuru, IslemDetayi) 
            VALUES ('ÜRETİM', CONCAT(p_Adet, ' adet ', UrunIsmi, ' üretildi.'));
        COMMIT;
    END IF;
END //

DELIMITER ;

-- 3. VERİLERİ DOLDURMA

-- A) Hammaddeler
INSERT INTO Tbl_Depo_Hammaddeler (Ad, Birim, StokMiktari, BirimMaliyet) VALUES 
('Sunta Plaka (18mm)', 'Adet', 500, 450.00), ('MDF Plaka (18mm)', 'Adet', 300, 600.00),
('Vida (3.5x18)', 'Adet', 10000, 0.50), ('Masa Ayağı (Metal)', 'Adet', 400, 120.00),
('Ahşap Tutkalı', 'Kg', 100, 80.00), ('Dolap Menteşesi', 'Adet', 800, 25.00),
('Çekmece Rayı', 'Takım', 300, 90.00), ('Kulp (Metal)', 'Adet', 600, 35.00),
('Kenar Bandı', 'Metre', 2000, 5.00), ('Sünger (32 Dansite)', 'Plaka', 150, 400.00),
('Kumaş (Kadife)', 'Metre', 300, 250.00), ('Zımba Teli', 'Kutu', 200, 40.00),
('Boya (Beyaz)', 'Kg', 150, 180.00), ('Vernik', 'Kg', 100, 200.00),
('Cam (Temperli)', 'm2', 50, 800.00), ('Ayna', 'm2', 80, 500.00),
('Askı Borusu', 'Metre', 200, 60.00), ('Minifix Bağlantı', 'Takım', 2000, 8.00),
('Karton Koli', 'Adet', 1000, 15.00), ('Ambalaj Naylonu', 'Rulo', 50, 300.00);

-- B) Ürünler
INSERT INTO Tbl_Satis_Urunleri (UrunAdi, BarkodNo, SatisFiyati, StoktakiUrunSayisi) VALUES 
('Çalışma Masası', 'URN-1001', 1800.00, 10), ('Yemek Masası', 'URN-1002', 4500.00, 5),
('Kitaplık', 'URN-1003', 1200.00, 15), ('Gardırop', 'URN-1004', 6000.00, 2),
('Komodin', 'URN-1005', 750.00, 20), ('TV Ünitesi', 'URN-1006', 2200.00, 8),
('Orta Sehpa', 'URN-1007', 900.00, 12), ('Ayakkabılık', 'URN-1008', 850.00, 10),
('Mutfak Sandalyesi', 'URN-1009', 650.00, 40), ('Şifonyer', 'URN-1010', 2500.00, 6);

-- C) Reçeteler
INSERT INTO Tbl_Uretim_Receteleri (UrunID, HammaddeID, GerekliMiktar) VALUES 
(1, 1, 1), (1, 4, 4), (1, 3, 20),
(2, 2, 2), (2, 4, 4), (2, 14, 1), 
(3, 1, 2), (3, 3, 50), (3, 9, 10), 
(4, 1, 5), (4, 6, 10), (4, 8, 3), 
(9, 4, 4), (9, 10, 0.5), (9, 11, 1),
-- Sonradan Eklenenler:
(5, 1, 0.5), (5, 7, 2), (5, 8, 2),      -- Komodin
(6, 1, 2), (6, 3, 20), (6, 18, 10),     -- TV Ünitesi
(7, 2, 1), (7, 4, 4), (7, 14, 0.2),     -- Orta Sehpa
(8, 1, 2), (8, 6, 4), (8, 8, 4),        -- Ayakkabılık
(10, 1, 3), (10, 7, 4), (10, 8, 4), (10, 16, 0.5); -- Şifonyer

-- Son Kontrol
SELECT * FROM Tbl_Uretim_Receteleri;