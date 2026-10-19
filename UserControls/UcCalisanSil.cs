using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Teknik_Servis_Yönetim.Models;

namespace Teknik_Servis_Yönetim.UserControls
{
    public partial class UcCalisanSil : UserControl
    {
        public UcCalisanSil()
        {
            InitializeComponent();
        }

        private void UcCalisanSil_Load(object sender, EventArgs e)
        {
            var calisanRepo = new Repositories.CalisanRepository();
            var calisanlar = calisanRepo.TumCalisanlariGetir();

            cb_calisan_listesi.DisplayMember = "AdiSoyadi";
            cb_calisan_listesi.ValueMember = "Id";
            cb_calisan_listesi.DataSource = calisanlar;
            
        }

        private void btn_calisan_sil_Click(object sender, EventArgs e)
        {
            var calisanRepo = new Repositories.CalisanRepository();
            var secilenCalisan = cb_calisan_listesi.SelectedItem as Calisan;
            calisanRepo.CalisanSil(secilenCalisan.Id);
        }
    }
}
