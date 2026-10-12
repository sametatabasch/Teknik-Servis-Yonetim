-- ========================================================
-- Proje: Teknik Servis ve Arıza Takip Otomasyonu
-- Veritabanı ve Kullanıcı Tanımlamaları
-- ========================================================

CREATE DATABASE IF NOT EXISTS teknik_servis 
CHARACTER SET utf8mb4 
COLLATE utf8mb4_general_ci;

CREATE USER IF NOT EXISTS 'teknik_servis_user'@'localhost' IDENTIFIED BY '123456';
GRANT ALL PRIVILEGES ON teknik_servis.* TO 'teknik_servis_user'@'localhost';
FLUSH PRIVILEGES;

USE teknik_servis;

-- --------------------------------------------------------
-- 1. Çalışanlar / Personel Tablosu (Giriş & Yetkilendirme)
-- --------------------------------------------------------
CREATE TABLE IF NOT EXISTS calisanlar (
    id INT PRIMARY KEY AUTO_INCREMENT,
    ad VARCHAR(50) NOT NULL,
    soyad VARCHAR(50) NOT NULL,
    kullanici_adi VARCHAR(50) NOT NULL UNIQUE,
    sifre VARCHAR(100) NOT NULL,
    yetki ENUM('Sekreter', 'Teknisyen', 'Yönetici') NOT NULL DEFAULT 'Teknisyen',
    email VARCHAR(100) NOT NULL UNIQUE,
    telefon VARCHAR(15) NOT NULL UNIQUE,
    tc VARCHAR(11) NOT NULL UNIQUE,
    maas DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    cinsiyet ENUM('Erkek', 'Kadın') NOT NULL,
    d_tarihi DATE NOT NULL,
    baslama_tarihi DATE NOT NULL,
    foto VARCHAR(255) NULL,
    adres VARCHAR(255) NULL,
    olusturulma_tarihi DATETIME DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB;

-- --------------------------------------------------------
-- 2. Müşteriler Tablosu
-- --------------------------------------------------------
CREATE TABLE IF NOT EXISTS musteriler (
    id INT PRIMARY KEY AUTO_INCREMENT,
    ad_soyad VARCHAR(100) NOT NULL,
    telefon VARCHAR(20) NOT NULL,
    email VARCHAR(100) NULL,
    adres TEXT NULL,
    kayit_tarihi DATETIME DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB;

-- --------------------------------------------------------
-- 3. Cihazlar Tablosu (1 Müşteri -> N Cihaz)
-- --------------------------------------------------------
CREATE TABLE IF NOT EXISTS cihazlar (
    id INT PRIMARY KEY AUTO_INCREMENT,
    musteri_id INT NOT NULL,
    kategori VARCHAR(50) NOT NULL, -- Bilgisayar, Telefon, Tablet vb.
    marka VARCHAR(50) NOT NULL,
    model VARCHAR(50) NOT NULL,
    seri_no VARCHAR(100) NOT NULL UNIQUE,
    CONSTRAINT fk_cihaz_musteri 
        FOREIGN KEY (musteri_id) 
        REFERENCES musteriler(id) 
        ON DELETE CASCADE 
        ON UPDATE CASCADE
) ENGINE=InnoDB;

-- --------------------------------------------------------
-- 4. Servis Kayıtları Tablosu (Durum & Teknisyen Ataması)
-- --------------------------------------------------------
CREATE TABLE IF NOT EXISTS servis_kayitlari (
    id INT PRIMARY KEY AUTO_INCREMENT,
    cihaz_id INT NOT NULL,
    teknisyen_id INT NULL,
    gelis_tarihi DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    musteri_sikayeti TEXT NOT NULL,
    tahmini_fiyat DECIMAL(10,2) DEFAULT 0.00,
    durum ENUM(
        'Kabul Edildi', 
        'İnceleniyor', 
        'Parça Bekliyor', 
        'Onay Bekliyor', 
        'Tamamlandı', 
        'Teslim Edildi'
    ) NOT NULL DEFAULT 'Kabul Edildi',
    CONSTRAINT fk_servis_cihaz 
        FOREIGN KEY (cihaz_id) 
        REFERENCES cihazlar(id) 
        ON DELETE CASCADE 
        ON UPDATE CASCADE,
    CONSTRAINT fk_servis_teknisyen 
        FOREIGN KEY (teknisyen_id) 
        REFERENCES calisanlar(id) 
        ON DELETE SET NULL 
        ON UPDATE CASCADE
) ENGINE=InnoDB;

-- --------------------------------------------------------
-- 5. İşlem Geçmişi Tablosu (Zaman Çizelgesi & Loglama)
-- --------------------------------------------------------
CREATE TABLE IF NOT EXISTS islem_gecmisi (
    id INT PRIMARY KEY AUTO_INCREMENT,
    servis_id INT NOT NULL,
    tarih DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    aciklama TEXT NOT NULL,
    CONSTRAINT fk_islem_servis 
        FOREIGN KEY (servis_id) 
        REFERENCES servis_kayitlari(id) 
        ON DELETE CASCADE 
        ON UPDATE CASCADE
) ENGINE=InnoDB;

-- ========================================================
-- Test Verileri (Mock Data)
-- ========================================================

-- Çalışanlar (Sekreter, Teknisyen ve Yönetici girişleri)
INSERT INTO calisanlar (ad, soyad, kullanici_adi, sifre, yetki, email, telefon, tc, maas, cinsiyet, d_tarihi, baslama_tarihi, foto, adres) VALUES
('Samet', 'ATABAŞ','sametatabasch','123456','Yönetici', 'sametatabasch@servis.com', '05551110004', '10000000004', 50000.00, 'Erkek', '1985-07-15', '2022-01-15', 'profil4.jpg', 'Tirebolu, Giresun'),
('Ahmet', 'Yılmaz', 'yonetici', '123456', 'Yönetici', 'ahmet.yilmaz@servis.com', '05551110001', '10000000001', 45000.00, 'Erkek', '1988-04-12', '2022-01-15', 'profil1.jpg', 'Kadıköy, İstanbul'),
('Ayşe', 'Kaya', 'sekreter', '123456', 'Sekreter', 'ayse.kaya@servis.com', '05551110002', '10000000002', 32000.00, 'Kadın', '1995-09-20', '2023-03-01', 'profil2.jpg', 'Üsküdar, İstanbul'),
('Mehmet', 'Demir', 'teknisyen1', '123456', 'Teknisyen', 'mehmet.demir@servis.com', '05551110003', '10000000003', 38000.00, 'Erkek', '1992-11-05', '2022-06-10', 'profil3.jpg', 'Ataşehir, İstanbul');

-- Müşteriler
INSERT INTO musteriler (ad_soyad, telefon, email, adres) VALUES
('Ali Can', '(555) 222-3344', 'ali.can@example.com', 'Maltepe, İstanbul'),
('Zeynep Akın', '(555) 777-8899', 'zeynep.akin@example.com', 'Kartal, İstanbul');

-- Cihazlar
INSERT INTO cihazlar (musteri_id, kategori, marka, model, seri_no) VALUES
(1, 'Bilgisayar', 'Dell', 'XPS 15', 'DLXPS15001'),
(1, 'Telefon', 'Apple', 'iPhone 13', 'IPH130099'),
(2, 'Tablet', 'Samsung', 'Galaxy Tab S8', 'SMGTAB802');

-- Servis Kayıtları
INSERT INTO servis_kayitlari (cihaz_id, teknisyen_id, gelis_tarihi, musteri_sikayeti, tahmini_fiyat, durum) VALUES
(1, 3, NOW(), 'Ekrana görüntü gelmiyor, fanlar son hızda dönüyor.', 2500.00, 'İnceleniyor'),
(2, NULL, NOW(), 'Şarj soketinde temassızlık var.', 750.00, 'Kabul Edildi'),
(3, 3, NOW(), 'Batarya çabuk bitiyor ve cihaz aşırı ısınıyor.', 1200.00, 'Parça Bekliyor');

-- İşlem Geçmişi
INSERT INTO islem_gecmisi (servis_id, tarih, aciklama) VALUES
(1, NOW(), 'Cihaz kasası açıldı, anakart besleme entegreleri incelendi.'),
(1, NOW(), 'Kısa devre tespiti yapıldı, yedek çip siparişi verildi.'),
(3, NOW(), 'Yeni batarya montajı öncesi şarj devresi kontrol edildi.');