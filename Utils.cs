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
        private static readonly string Key = "b14ca5898a4e4133bbce2ea2315a1916"; // Replace with your secret key
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

        public static string GenerateKey()
        {
            using (var aes = Aes.Create())
            {
                aes.KeySize = 128; // Set the key size to 128 bits (16 bytes)
                aes.GenerateKey();
                return Convert.ToBase64String(aes.Key);
            }
        }

        public static string EncryptPassword(string password, string key)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = DeriveKeyBytes(key);
                aes.IV = iv;
                aes.Padding = PaddingMode.PKCS7;

                ICryptoTransform encryptor = aes.CreateEncryptor();

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                        {
                            streamWriter.Write(password);
                        }
                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        public static string DecryptPassword(string encryptedPassword, string key)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(encryptedPassword);

            using (Aes aes = Aes.Create())
            {
                aes.Key = DeriveKeyBytes(key);
                aes.IV = iv;
                aes.Padding = PaddingMode.PKCS7;

                ICryptoTransform decryptor = aes.CreateDecryptor();

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader(cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }

        private static byte[] DeriveKeyBytes(string key)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] keyBytes = Encoding.UTF8.GetBytes(key);
                return sha256.ComputeHash(keyBytes);
            }
        }

    }
}
