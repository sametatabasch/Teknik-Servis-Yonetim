using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Teknik_Servis_Yönetim.Repositories;

namespace Teknik_Servis_Yönetim.UserControls
{
    public partial class UcCalisanDuzenle : UserControl
    {
        public int SecilenCalisanId;
        private string secilenFotoYolu = "";

        public UcCalisanDuzenle()
        {
            InitializeComponent();
        }

        private void UcCalisanDuzenle_Load(object sender, EventArgs e)
        {
            // Yetki ComboBox listesi
            cmb_calisan_yetki.Items.Clear();
            cmb_calisan_yetki.Items.AddRange(new object[] { "Teknisyen", "Sekreter", "Yönetici" });

            // Calışanlar üzerinde yapıalcak sql işlemlerini yapan sınıfı çağırdık
            var calisanRepo = new CalisanRepository();
            // Seçilen çalışan id'sine göre çalışan bilgilerini getirdik
            var DuzenlenecekCalisan = calisanRepo.IdyeGoreCalisanGetir(SecilenCalisanId);
            if (DuzenlenecekCalisan == null)
            {
                MessageBox.Show("Çalışan bulunamadı.");
                return;
            }

            txt_calisan_adi.Text = DuzenlenecekCalisan.Ad;
            txt_calisan_soyadi.Text = DuzenlenecekCalisan.Soyad;
            radio_calisan_cinsiyet_erkek.Checked = DuzenlenecekCalisan.Cinsiyet == "Erkek";
            radio_calisan_cinsiyet_kadin.Checked = DuzenlenecekCalisan.Cinsiyet == "Kadın";
            txt_calisan_tc.Text = DuzenlenecekCalisan.Tc;
            DateTimePickerDegeriAta(dtp_calisan_d_tarihi, DuzenlenecekCalisan.DTarihi);

            mtxt_calisan_gsm.Text = DuzenlenecekCalisan.Telefon;
            txt_calisan_email.Text = DuzenlenecekCalisan.Email;
            txt_calisan_adres.Text = DuzenlenecekCalisan.Adres;

            cmb_calisan_yetki.SelectedItem = DuzenlenecekCalisan.Yetki;
            nud_calisan_maas.Value = Math.Min(DuzenlenecekCalisan.Maas, nud_calisan_maas.Maximum);
            DateTimePickerDegeriAta(dtp_calisan_baslama_tarihi, DuzenlenecekCalisan.BaslamaTarihi);

            if (!string.IsNullOrEmpty(DuzenlenecekCalisan.Foto))
            {
                secilenFotoYolu = DuzenlenecekCalisan.Foto;
                pcb_calisan_foto.ImageLocation = secilenFotoYolu;
            }
        }

        // DateTimePicker'ın Min/Max aralığı dışında kalan değerler hata vereceğinden değer aralığa çekilir
        private static void DateTimePickerDegeriAta(DateTimePicker dtp, DateTime deger)
        {
            if (deger < dtp.MinDate) deger = dtp.MinDate;
            if (deger > dtp.MaxDate) deger = dtp.MaxDate;
            dtp.Value = deger;
        }

        private void btn_calisan_foto_ekle_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog1.Title = "Çalışan Fotoğrafı Seç";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                secilenFotoYolu = openFileDialog1.FileName;
                pcb_calisan_foto.ImageLocation = secilenFotoYolu;
            }
        }

        private void btn_calisan_guncelle_Click(object sender, EventArgs e)
        {
            // CalisanRepository'de güncelleme metodu henüz yok; eklenince burada çağrılacak
        }
    }
}
