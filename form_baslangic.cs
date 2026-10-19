using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Teknik_Servis_Yönetim.UserControls;

namespace Teknik_Servis_Yönetim
{
    public partial class form_baslangic : Form
    {
        public form_baslangic()
        {
            InitializeComponent();
        }

        private void tsmi_cikis_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show(
                "Uygulamadan çıkmak istediğinize emin misiniz?",
                "Çıkış Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (secim == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void sayfa_yukle(UserControl sayfa)
        {
            pnl_ana_panel.Controls.Clear();
            sayfa.Dock = DockStyle.Fill;
            pnl_ana_panel.Controls.Add(sayfa);
        }

        private void tsmi_calisan_listesi_Click(object sender, EventArgs e)
        {
            sayfa_yukle(new UcCalisanListesi());
        }

        private void tsmi_calisan_ekle_Click(object sender, EventArgs e)
        {
            sayfa_yukle(new UcCalisanEkle());
        }

        private void tsmi_calisan_duzenle_Click(object sender, EventArgs e)
        {
            sayfa_yukle(new UcCalisanDuzenle());
        }

        private void tsmi_calisan_sil_Click(object sender, EventArgs e)
        {
            sayfa_yukle(new UcCalisanSil());
        }

        private void form_baslangic_Load(object sender, EventArgs e)
        {
            if(!Oturum.GirisYapildiMi())
            {
                form_giris formGiris = new form_giris();
                
                while (formGiris.DialogResult != DialogResult.OK)
                {
                    if (formGiris.DialogResult == DialogResult.Cancel)
                    {
                        Application.Exit();
                        return;
                    }
                    formGiris.ShowDialog();
                }
            }

            tsmi_karsilama.Text = Oturum.AktifKullnici?.KarsilamaMesaji;
        }
    }
}
