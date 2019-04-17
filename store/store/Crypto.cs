using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Security.Cryptography;

namespace store.Models
{
    public class Crypto
    {

        public static string Hash(string value)
        {

            return BitConverter.ToString(System.Security.Cryptography.MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(value))).Replace("-", string.Empty).ToLower(); 
        }

    }
}