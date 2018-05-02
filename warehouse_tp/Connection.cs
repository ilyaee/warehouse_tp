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


        public static void ShowAllEmployees()
        {
            adapter = new MySqlDataAdapter(Queries.ShowAllEmployees, connection);
            ds = new DataSet();
            adapter.Fill(ds);
        }

        public static void AddEmployee(string login, string password)
        {
            var cmd = new MySqlCommand(Queries.AddEmployee, connection);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@password", password);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void DeleteEmployee(int SelectedRow)
        {
            var cmd = new MySqlCommand(Queries.DeleteEmployee, connection);
            cmd.Parameters.AddWithValue("@ID", SelectedRow);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void UpdateEmployee(string login, string password, int SelectedRow)    //добавить встроенную функцию хеширования
        {
            var cmd = new MySqlCommand(Queries.UpdateEmployee, connection);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@ID", SelectedRow);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}