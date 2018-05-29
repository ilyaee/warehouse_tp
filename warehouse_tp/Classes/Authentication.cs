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
        private static string hash = "f0xle@rn";   //it's a magic

        /// <summary>
        /// Возвращает string с MD5-хешированным паролем
        /// </summary>
        public static string Hash(string input)
        {
            ////вычисление хеша из password
            //MD5 md5 = MD5.Create();
            //byte[] hash = md5.ComputeHash(Encoding.ASCII.GetBytes(input));

            ////byte[] ---> string
            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < hash.Length; i++)
            //    sb.Append(hash[i].ToString("X2"));

            //return sb.ToString();

            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] CheckSum = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return BitConverter.ToString(CheckSum).Replace("-", String.Empty);
        }

        //public static string UnHash(string Input)
        //{
        //    byte[] data = Convert.FromBase64String(Input);
        //    MD5 md5 = new MD5CryptoServiceProvider();

        //    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
        //    TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider();
        //    ICryptoTransform transform = tripDes.CreateDecryptor();
        //    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
        //    return UTF8Encoding.UTF8.GetString(results);
        //}
    }
}