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
    }
}
