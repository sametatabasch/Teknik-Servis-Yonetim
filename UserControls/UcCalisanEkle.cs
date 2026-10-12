using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Teknik_Servis_Yönetim.UserControls
{
    public partial class UcCalisanEkle : UserControl
    {
        private string secilenFotoYolu = "";

        public UcCalisanEkle()
        {
            InitializeComponent();
        }

        private void UcCalisanEkle_Load(object sender, EventArgs e)
        {
            // Günümüzden 65 ve 18 yıl öncesi aralığı
            DateTime minDate = DateTime.Now.AddYears(-65);
            DateTime maxDate = DateTime.Now.AddYears(-18);

            // DateTimePicker varsayılan olarak bugünü tuttuğundan,
            // MaxDate (18 yıl öncesi) atandığında hata vermemesi için önce Value ayarlanır:
            dtp_calisan_d_tarihi.Value = maxDate;
            dtp_calisan_d_tarihi.MinDate = minDate;
            dtp_calisan_d_tarihi.MaxDate = maxDate;

            // Yetki ComboBox listesi
            cmb_calisan_yetki.Items.Clear();
            cmb_calisan_yetki.Items.AddRange(new object[] { "Teknisyen", "Sekreter", "Yönetici" });
            cmb_calisan_yetki.SelectedIndex = 0;

            // Başlama tarihi varsayılan olarak bugün
            dtp_calisan_baslama_tarihi.Value = DateTime.Today;
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

        private void btn_calisan_kaydet_Click(object sender, EventArgs e)
        {
            // 1. Cinsiyet kontrolü
            string cinsiyet = "";
            if (radio_calisan_cinsiyet_erkek.Checked)
            {
                cinsiyet = "Erkek";
            }
            else if (radio_calisan_cinsiyet_kadin.Checked)
            {
                cinsiyet = "Kadın";
            }
            else
            {
                MessageBox.Show("Lütfen bir cinsiyet seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Fotoğraf bilgisi
            string fotoBilgisi = string.IsNullOrEmpty(secilenFotoYolu) ? "Seçilmedi" : secilenFotoYolu;

            // 3. Tüm form alanlarını mesaj metninde birleştirme
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=== KİŞİSEL BİLGİLER ===");
            sb.AppendLine($"Adı            : {txt_calisan_adi.Text.Trim()}");
            sb.AppendLine($"Soyadı         : {txt_calisan_soyadi.Text.Trim()}");
            sb.AppendLine($"Cinsiyet       : {cinsiyet}");
            sb.AppendLine($"Doğum Tarihi   : {dtp_calisan_d_tarihi.Value:dd.MM.yyyy}");
            sb.AppendLine($"T.C. No        : {txt_calisan_tc.Text.Trim()}");
            sb.AppendLine($"Fotoğraf       : {fotoBilgisi}");
            sb.AppendLine();
            sb.AppendLine("=== İLETİŞİM BİLGİLERİ ===");
            sb.AppendLine($"Cep Tel        : {mtxt_calisan_gsm.Text}");
            sb.AppendLine($"E-posta        : {txt_calisan_email.Text.Trim()}");
            sb.AppendLine($"Adres          : {txt_calisan_adres.Text.Trim()}");
            sb.AppendLine();
            sb.AppendLine("=== İŞ VE YETKİ BİLGİLERİ ===");
            sb.AppendLine($"Yetki          : {cmb_calisan_yetki.SelectedItem}");
            sb.AppendLine($"Maaş           : {nud_calisan_maas.Value:N2} TL");
            sb.AppendLine($"Başlama Tarihi : {dtp_calisan_baslama_tarihi.Value:dd.MM.yyyy}");

            // 4. MessageBox ile gösterme
            MessageBox.Show(sb.ToString(), "Çalışan Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
