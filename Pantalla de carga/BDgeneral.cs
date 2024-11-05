using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Qmanager
{
    public class BDgeneral
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=db_qmanager");
            conection.Open();
            return conection;
        }
    }
}
