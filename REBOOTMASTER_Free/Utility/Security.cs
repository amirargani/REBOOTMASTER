using System.Security.Cryptography;
using System.Text;

namespace REBOOTMASTER_Free.Utility
{
    internal class Security
    {
        // Security Cryptography
        // learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.hashalgorithm.computehash?view=net-9.0
        // learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.hashalgorithm.computehash?view=net-10.0
        // gamedevacademy.org/c-sha256-tutorial-complete-guide/

        /// <summary>
        // Decrypts a Base64-encoded string consisting of encrypted data,
        // key, and IV, and returns the original plaintext.
        // </summary>
        // <param name="str">The concatenated string in the format "Encrypted;Key;IV".</param>
        // <returns>The decrypted plaintext or null if the input string is empty.</returns>
        internal static string GetString(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                string[] parts = str.Split(";)");
                byte[] encryptedData = Convert.FromBase64String(parts[0]);
                byte[] key = Convert.FromBase64String(parts[1]);
                byte[] iv = Convert.FromBase64String(parts[2]);
                byte[] decryptedData = DecryptData(encryptedData, key, iv);
                return Encoding.UTF8.GetString(decryptedData);
            }
            else {  return null!; }
        }

        /// <summary>
        // Encrypts a string using AES-256, generates a random key and IV
        // and returns the data as a concatenated Base64 string.
        // </summary>
        // <param name="str">The plaintext to be encrypted.</param>
        // <returns>A string in the format "EncryptedData;Key;IV".</returns>
        internal static string CreateEncryptedDataBase64(string str)
        {
            byte[] data = Encoding.UTF8.GetBytes(str);
            byte[] key = new byte[32]; // Or 256-bit key
            RandomNumberGenerator.Fill(key);
            byte[] iv;
            byte[] encryptedData = EncryptData(data, key, out iv);
            string encryptedDataBase64 = Convert.ToBase64String(encryptedData);
            string keyBase64 = Convert.ToBase64String(key);
            string ivBase64 = Convert.ToBase64String(iv);
            return encryptedDataBase64 + ";)" + keyBase64 + ";)" + ivBase64;
        }

        /// <summary>
        // Creates a SHA256 hash for the specified input string.
        // </summary>
        // <param name="input">The input text to be hashed.</param>
        // <returns>The SHA256 hash as a Base64-encoded string.</returns>
        internal static string CreateSHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        /// <summary>
        // Encrypts a byte array using AES-256 and returns the encrypted data.
        // </summary>
        // <param name="data">The data to be encrypted.</param>
        // <param name="key">The AES key (256 bits).</param>
        // <param name="iv">The generated initialization vector (IV).</param>
        // <returns>The encrypted data as a byte array.</returns>
        internal static byte[] EncryptData(byte[] data, byte[] key, out byte[] iv)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.GenerateIV();
                iv = aes.IV;
                ICryptoTransform encryptor = aes.CreateEncryptor();
                return encryptor.TransformFinalBlock(data, 0, data.Length);
            }
        }

        /// <summary>
        // Decrypts a byte array using AES-256 with the specified key and IV.
        // </summary>
        // <param name="encryptedData">The encrypted data.</param>
        // <param name="key">The AES key (256 bits).</param>
        // <param name="iv">The initialization vector (IV).</param>
        // <returns>The decrypted data as a byte array.</returns>
        internal static byte[] DecryptData(byte[] encryptedData, byte[] key, byte[] iv)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor();
                return decryptor.TransformFinalBlock(encryptedData, 0, encryptedData.Length);
            }
        }
    }
}