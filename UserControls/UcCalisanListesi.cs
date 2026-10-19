using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Teknik_Servis_Yönetim.Data;
using MySql.Data.MySqlClient;

namespace Teknik_Servis_Yönetim.UserControls
{
    public partial class UcCalisanListesi : UserControl
    {
        public int secilen_calisan_id;
        public UcCalisanListesi()
        {
            InitializeComponent();
        }

        private void UcCalisanListesi_Load(object sender, EventArgs e)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                string sql = "SELECT * FROM calisanlar";
                using var adapter = new MySqlDataAdapter(sql, connection);

                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgw_calisan_listesi.DataSource = dataTable;
            }
        }

        public void dgw_calisan_listesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var secilenSatir = dgw_calisan_listesi.Rows[e.RowIndex];

                string secilen_calisan_adi = secilenSatir.Cells["ad"].Value.ToString();
                string secilen_calisan_soyadi = secilenSatir.Cells["soyad"].Value.ToString();

                secilen_calisan_id = Convert.ToInt32(secilenSatir.Cells["id"].Value);

                lbl_secilen_ad_soyad.Text = $"Seçilen Çalışan: {secilen_calisan_adi} {secilen_calisan_soyadi}";

                btn_secilen_duzenle.Text = $" {secilen_calisan_adi} {secilen_calisan_soyadi} Düzenle";
                btn_secilen_sil.Text = $" {secilen_calisan_adi} {secilen_calisan_soyadi} Sil";
            }
        }

        private void btn_secilen_duzenle_Click(object sender, EventArgs e)
        {
            // Düzenle kontrolünü çalışan forma eklemek için çalışan formu bulduk 
            var baslangicFormu = this.FindForm() as form_baslangic;
            // Düzenle kontrolünü oluşturduk
            var duzenleControl = new UcCalisanDuzenle();
            // Düzenle kontrolüne seçilen çalışan id'sini atadık
            duzenleControl.SecilenCalisanId = secilen_calisan_id;

            baslangicFormu.sayfa_yukle(duzenleControl);

        }

        private void btn_secilen_sil_Click(object sender, EventArgs e)
        {
            var calisanRepo = new Repositories.CalisanRepository();
            calisanRepo.CalisanSil(secilen_calisan_id);
            dgw_calisan_listesi.Rows.RemoveAt(dgw_calisan_listesi.CurrentRow.Index);
        }
    }
}
