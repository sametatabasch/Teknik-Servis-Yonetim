using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Teknik_Servis_Yönetim.Models
{
    internal class Calisan
    {
        /**
         * id INT PRIMARY KEY AUTO_INCREMENT,
         * ad VARCHAR(50) NOT NULL,
         * soyad VARCHAR(50) NOT NULL,
         * kullanici_adi VARCHAR(50) NOT NULL UNIQUE,
         * sifre VARCHAR(100) NOT NULL,
         * yetki ENUM('Sekreter', 'Teknisyen', 'Yönetici') NOT NULL DEFAULT 'Teknisyen',
         * email VARCHAR(100) NOT NULL UNIQUE,
         * telefon VARCHAR(15) NOT NULL UNIQUE,
         * tc VARCHAR(11) NOT NULL UNIQUE,
         * maas DECIMAL(10,2) NOT NULL DEFAULT 0.00,
         * cinsiyet ENUM('Erkek', 'Kadın') NOT NULL,
         * d_tarihi DATE NOT NULL,
         * baslama_tarihi DATE NOT NULL,
         * foto VARCHAR(255) NULL,
         * adres VARCHAR(255) NULL,
         * olusturulma_tarihi DATETIME DEFAULT CURRENT_TIMESTAMP
         * 
         */
        public int Id { get; set; }
        public string Ad { get; set; } = "";
        public string Soyad { get; set; } = "";
        public string KullaniciAdi { get; set; } = "";
        public string Sifre { get; set; } = "";
        public string Yetki { get; set; } = "";
        public string Email { get; set; } = "";
        public string Telefon { get; set; } = "";
        public string Tc { get; set; } = "";
        public decimal Maas { get; set; } = 0.00m;
        public string Cinsiyet { get; set; } = "";
        public DateTime DTarihi { get; set; } = DateTime.MinValue;
        public DateTime BaslamaTarihi { get; set; } = DateTime.MinValue;
        public string? Foto { get; set; }
        public string? Adres { get; set; }
        public DateTime OlusturulmaTarihi { get; set; } = DateTime.MinValue;

        public string AdiSoyadi => $"{Ad} {Soyad}";

        public string KarsilamaMesaji => $"Hoş geldiniz, {AdiSoyadi}! - {Yetki}";

        public void Fill(MySqlDataReader reader)
        {
            Id= reader.GetInt32("id");
            Ad = reader.GetString("ad");
            Soyad = reader.GetString("soyad");
            KullaniciAdi = reader.GetString("kullanici_adi");
            Sifre = reader.GetString("sifre");
            Yetki = reader.GetString("yetki");
            Email = reader.GetString("email");
            Telefon = reader.GetString("telefon");
            Tc = reader.GetString("tc");
            Maas = reader.GetDecimal("maas");
            Cinsiyet = reader.GetString("cinsiyet");
            DTarihi = reader.GetDateTime("d_tarihi");
            BaslamaTarihi = reader.GetDateTime("baslama_tarihi");
            Foto = reader["foto"] as string;
            Adres = reader["adres"] as string;
            OlusturulmaTarihi = reader.GetDateTime("olusturulma_tarihi");
        }
    }
}
