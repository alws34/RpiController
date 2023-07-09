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

        public static byte[] EncryptPassword(string password, byte[] key)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;

                // Generate a random IV (Initialization Vector)
                aes.GenerateIV();

                using (MemoryStream memoryStream = new MemoryStream())
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    // Write the IV to the beginning of the encrypted data
                    memoryStream.Write(aes.IV, 0, aes.IV.Length);

                    // Convert the password to bytes and encrypt it
                    byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                    cryptoStream.Write(passwordBytes, 0, passwordBytes.Length);
                    cryptoStream.FlushFinalBlock();

                    return memoryStream.ToArray();
                }
            }
        }

        public static byte[] GenerateEncryptionKey()
        {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] key = new byte[32]; // 256 bits
                rng.GetBytes(key);
                return key;
            }
        }

        public static string DecryptPassword(byte[] encryptedPassword, byte[] key)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;

                // Read the IV from the beginning of the encrypted data
                byte[] iv = new byte[aes.IV.Length];
                Array.Copy(encryptedPassword, iv, iv.Length);
                aes.IV = iv;

                using (MemoryStream memoryStream = new MemoryStream(encryptedPassword, iv.Length, encryptedPassword.Length - iv.Length))
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                using (StreamReader streamReader = new StreamReader(cryptoStream))
                {
                    return streamReader.ReadToEnd();
                }
            }
        }



    }
}
