using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace warehouse_tp
{
    class Connection
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        public static MySqlConnection connection = new MySqlConnection(connectionString);
        public static DataSet ds;/* = new DataSet();*/
        public static MySqlDataAdapter adapter;
    }
}