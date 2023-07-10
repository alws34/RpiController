using Renci.SshNet.Security;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PiController
{
    public static class Utils
    {
        private static readonly byte[] Key = Encoding.UTF8.GetBytes("ThisIsASecretKey"); // Replace with your secret key
        private static readonly byte[] IV = Encoding.UTF8.GetBytes("ThisIsAnIV12345"); // Replace with your IV

        public static string GetUniqueID() { return Guid.NewGuid().ToString(); }

        public static string GenerateSalt(int length = 512)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_-+={}[]'|.><,?/;";
            StringBuilder saltBuilder = new StringBuilder();

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] saltBytes = new byte[length];
                rng.GetBytes(saltBytes);

                foreach (byte b in saltBytes)
                {
                    saltBuilder.Append(chars[b % chars.Length]);
                }
            }

            return saltBuilder.ToString();
        }

        public static string GetSHA512Hash(string input)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha512.ComputeHash(inputBytes);

                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }

        public static string GenerateSalt()
        {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[8]; // 64 bits
                rng.GetBytes(salt);
                return Convert.ToBase64String(salt);
            }
        }

    }
}
