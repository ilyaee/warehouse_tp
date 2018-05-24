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

        #region EmployeesForAdmin
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
            cmd.Parameters.AddWithValue("@password", Authentication.Hash(password));
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
            cmd.Parameters.AddWithValue("@password", Authentication.Hash(password));
            cmd.Parameters.AddWithValue("@ID", SelectedRow);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        #endregion

        public static bool PasswordCheck(string Login, string InputPass, out string prefix)
        {
            prefix = null;
            var cmd = new MySqlCommand(Queries.PasswordCheck, connection);
            cmd.Parameters.AddWithValue("@login", Login);
            cmd.Parameters.AddWithValue("@password", Authentication.Hash(InputPass)); //передаем хешированный пароль
            connection.Open();
            cmd.ExecuteNonQuery();
            adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            bool ok;
            try
            {
                ok = dt.Rows[0][0].ToString() != null;
            }
            catch (IndexOutOfRangeException)
            {
                connection.Close();
                return false;
            }

            prefix = Login.Substring(0, 2);
            connection.Close();
            return true;
        }

        public static void ShowRemnants()
        {
            adapter = new MySqlDataAdapter(Queries.ShowRemnants, connection);
            ds = new DataSet();
            adapter.Fill(ds);
        }

        public static void ShowContractors()
        {
            adapter = new MySqlDataAdapter(Queries.ShowAllContractors, connection);
            ds = new DataSet();
            adapter.Fill(ds);
        }

        public static void ShowRemnantsForWarehouseIn()
        {
            adapter = new MySqlDataAdapter(Queries.ShowRemnantsForWarehouseIn, connection);
            ds = new DataSet();
            adapter.Fill(ds);
        }

        public static bool ProductNameCheck(string ProductName)
        {
            var cmd = new MySqlCommand(Queries.ProductNameCheck, connection);
            cmd.Parameters.AddWithValue("@name", ProductName);
            connection.Open();
            cmd.ExecuteNonQuery();
            adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            bool ok;
            try
            {
                ok = dt.Rows[0][0].ToString() != null;
            }
            catch (IndexOutOfRangeException)
            {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        public static void ProductCountAndPriceUpdate(string ProductName, int count, double price)
        {
            //получаем id продукта и его текущее количество на складе
            var cmd = new MySqlCommand(Queries.GetProductId, connection);
            cmd.Parameters.AddWithValue("@name", ProductName);
            connection.Open();
            cmd.ExecuteNonQuery();
            adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            int ProductId = Convert.ToInt32(dt.Rows[0][0]);
            int OldCount = Convert.ToInt32(dt.Rows[0][1]);
            connection.Close();
            
            //обновляем количество на складе 
            cmd = new MySqlCommand(Queries.ProductCountAndPriceUpdate, connection);
            cmd.Parameters.AddWithValue("@count", count + OldCount);
            cmd.Parameters.AddWithValue("@id", ProductId);
            cmd.Parameters.AddWithValue("@price", price * 1.3);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void AddNewProduct(string name, int count, double price)
        {
            var cmd = new MySqlCommand(Queries.AddNewProduct, connection);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@count", count);
            cmd.Parameters.AddWithValue("@price", price * 1.3);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void AddNewContractor(string fio, string role)
        {
            var cmd = new MySqlCommand(Queries.AddNewContractor, connection);
            cmd.Parameters.AddWithValue("@fio", fio);
            cmd.Parameters.AddWithValue("@role", role);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void ContractorUpdate(string OldFio, string NewFio, string role)
        {
            var cmd = new MySqlCommand(Queries.GetContractorId, connection);
            cmd.Parameters.AddWithValue("@fio", OldFio);
            connection.Open();
            cmd.ExecuteNonQuery();
            adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            int ProductId = Convert.ToInt32(dt.Rows[0][0]);
            connection.Close();

            cmd = new MySqlCommand(Queries.ContractorUpdate, connection);
            cmd.Parameters.AddWithValue("@fio", NewFio);
            cmd.Parameters.AddWithValue("@role", role);
            cmd.Parameters.AddWithValue("@id", ProductId);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void DeleteContractor(string fio)
        {
            var cmd = new MySqlCommand(Queries.GetContractorId, connection);
            cmd.Parameters.AddWithValue("@fio", fio);
            connection.Open();
            cmd.ExecuteNonQuery();
            adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            int ProductId = Convert.ToInt32(dt.Rows[0][0]);
            connection.Close();

            cmd = new MySqlCommand(Queries.DeleteContractor, connection);
            cmd.Parameters.AddWithValue("@id", ProductId);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}