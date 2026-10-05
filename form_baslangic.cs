using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
    }
}
