using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Teknik_Servis_Yönetim.Models;
using Teknik_Servis_Yönetim.Data;

namespace Teknik_Servis_Yönetim.Repositories
{
    internal  class CalisanRepository
    {

        public  Calisan IdyeGoreCalisanGetir(int calisanId)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                string sql = "SELECT * FROM calisanlar WHERE id = @id";
                using var command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", calisanId);
                using var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var calisan = new Calisan();
                    calisan.Fill(reader);
                    return calisan;
                }
            }
            return null;
        }

        public List<Calisan> TumCalisanlariGetir()
        {
            var calisanlar = new List<Calisan>();
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                string sql = "SELECT * FROM calisanlar";
                using var command = new MySqlCommand(sql, connection);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var calisan = new Calisan();
                    calisan.Fill(reader);
                    calisanlar.Add(calisan);
                }
            }
            return calisanlar;
        }
        public void CalisanSil(int calisanId)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                string sql = "DELETE FROM calisanlar WHERE id = @id";
                using var command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", calisanId);
                command.ExecuteNonQuery();
            }
        }

    }
}
