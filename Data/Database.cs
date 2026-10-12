using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Teknik_Servis_Yönetim.Data
{
    internal static class Database
    {
        // veri tabanı bağlantısı için gerekli olan bağlantı metni
        private static string connectionString = "Server=localhost;Database=teknik_servis;Uid=teknik_servis_user;Pwd=123456;Charset=utf8mb4";
        /**
         * Veri tabanı bağlantısı için bir MySqlConnection nesnesi döndüren statik bir yöntemdir. Bu yöntem, veri tabanına bağlanmak için gerekli olan bağlantı metnini kullanır ve bir MySqlConnection nesnesi oluşturur.
         * Bu nesne, veri tabanı işlemleri yapmak için kullanılabilir.
         */
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
