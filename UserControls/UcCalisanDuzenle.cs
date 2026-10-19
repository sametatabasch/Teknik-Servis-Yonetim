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
        public UcCalisanDuzenle()
        {
            InitializeComponent();
        }

        private void UcCalisanDuzenle_Load(object sender, EventArgs e)
        {
            // Calışanlar üzerinde yapıalcak sql işlemlerini yapan sınıfı çağırdık
            var calisanRepo = new CalisanRepository();
            // Seçilen çalışan id'sine göre çalışan bilgilerini getirdik
            var DuzenlenecekCalisan = calisanRepo.IdyeGoreCalisanGetir(SecilenCalisanId);

            label1.Text = $"Seçilen Çalışan: {DuzenlenecekCalisan.Ad} {DuzenlenecekCalisan.Soyad} {DuzenlenecekCalisan.Yetki}";
        }
    }
}
