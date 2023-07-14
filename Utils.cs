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
        public static string GetUniqueID() { return Guid.NewGuid().ToString(); }

        public static byte[] GenerateSalt()
        {
            // Create a new RNGCryptoServiceProvider object.
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

            // Generate a random salt of 16 bytes.
            byte[] salt = new byte[16];
            rng.GetBytes(salt);

            // Return the salt.
            return salt;
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

        public static byte[] GenerateKey()
        {
            // Create a new RNGCryptoServiceProvider object.
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

            // Generate a random key of 128 bits.
            byte[] key = new byte[16];
            rng.GetBytes(key);

            // Return the key.
            return key;
        }

        public static string EncryptPassword(string password, byte[] key, byte[] salt)
        {
            // Create an AesManaged object.
            using (AesManaged aes = new AesManaged())
            {
                // Initialize the AesManaged object with the key and salt.
                aes.Key = key;
                aes.IV = salt;

                // Encrypt the password.
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write);
                cs.Write(Encoding.UTF8.GetBytes(password), 0, password.Length);
                cs.Close();

                // Convert the encrypted password to a Base-64 string.
                byte[] encryptedBytes = ms.ToArray();
                string encryptedPassword = Convert.ToBase64String(encryptedBytes);

                // Return the encrypted password.
                return encryptedPassword;
            }
        }

        public static string DecryptPassword(string encryptedPassword, byte[] key, byte[] salt)
        {
            string password = null;
            // Create an AesManaged object.
            using (AesManaged aes = new AesManaged())
            {
                // Initialize the AesManaged object with the key and salt.
                aes.Key = key;
                aes.IV = salt;
                try
                {
                    // Decrypt the password.
                    byte[] encryptedBytes = Convert.FromBase64String(encryptedPassword);
                    MemoryStream ms = new MemoryStream(encryptedBytes);
                    CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read);
                    byte[] decryptedBytes = new byte[ms.Length];
                    cs.Read(decryptedBytes, 0, decryptedBytes.Length);
                    cs.Close();

                    // Return the decrypted password as a string.
                    password = Encoding.UTF8.GetString(decryptedBytes).Trim('\0');
                }
                catch (Exception ex) { return null; }

            }
            return password;
        }
    }
}