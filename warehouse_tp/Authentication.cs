using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace warehouse_tp
{
    class Authentication
    {
        //wh-склад
        //sh-магазин
        //co-контрагенты
        //admin-окно управления

        #region Fields
        private string _login;
        private string _password;

        public string Password { get => _password; set => _password = value; }
        public string Login { get => _login; set => _login = value; }
        #endregion



        /// <summary>
        /// Возвращает string с MD5-хешированным паролем
        /// </summary>
        private static string Hash(string input)
        {
            //вычисление хеша из password
            MD5 md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(Encoding.ASCII.GetBytes(input));

            //byte[] ---> string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
                sb.Append(hash[i].ToString("X2"));

            return sb.ToString();
        }

        public static bool PasswordCheck(string input)
        {

            return true;
        }
    }
}