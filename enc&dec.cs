
using System;
    using System.IO;
    using System.Security.Cryptography;
    using System.Text;

namespace PassGuard
{
    
    public class EncryptionDecryption
    {
        // مفتاح ثابت مشفر بتنسيق Base64
        private static readonly string keyBase64 = "pBq7F9y8k6mOpU3z1xNsT4vR8wLhR2jQ";
        private static readonly byte[] key = Convert.FromBase64String(keyBase64);

        public string Encrypt(string plainText)
        {
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] encryptedBytes;

            using (var aes = Aes.Create())
            {
                aes.Key = key;
                aes.GenerateIV();
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (var ms = new MemoryStream())
                {
                    ms.Write(aes.IV, 0, aes.IV.Length);

                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        cs.Write(plainBytes, 0, plainBytes.Length);
                        cs.FlushFinalBlock();
                    }

                    encryptedBytes = ms.ToArray();
                }
            }

            return Convert.ToBase64String(encryptedBytes);
        }
    }


}
