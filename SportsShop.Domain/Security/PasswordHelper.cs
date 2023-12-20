using System;
using System.Security.Cryptography;
using System.Text;

namespace SportsShop.Domain.Security
{
    public static class PasswordHelper
    {
        public static string EncodePasswordMd5(string pass) //Encrypt using MD5   
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            var originalBytes = ASCIIEncoding.Default.GetBytes(pass);
            var encodedBytes = md5.ComputeHash(originalBytes);
            return BitConverter.ToString(encodedBytes);
        }
    }
}
