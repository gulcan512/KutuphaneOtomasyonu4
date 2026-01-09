using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DALL
{
    public class DbBaglanti
    {
        private static string connectionString =
            "Server=172.21.54.253; Database=26_132330081; User=26_132330081; Password=İnif123.";

        public static MySqlConnection BaglantiGetir()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
    

