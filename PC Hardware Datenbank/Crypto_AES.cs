using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PC_Hardware_Datenbank
{
    class Crypto_AES
    {
        private AesCryptoServiceProvider crypto_provider;

        private static string key = "qwertzuiopüäölkjhgfdsayxcvbnmkzg";
        private static string IV = "poiuztgdewahvdly";

        public Crypto_AES()
        {
            crypto_provider = new AesCryptoServiceProvider();

            crypto_provider.BlockSize = 128;
            crypto_provider.KeySize = 256;

            crypto_provider.Key = System.Text.ASCIIEncoding.ASCII.GetBytes(key);
            //crypto_provider.Key = System.Text.UnicodeEncoding.Unicode.GetBytes(key);

            crypto_provider.IV = System.Text.ASCIIEncoding.ASCII.GetBytes(IV);
            //crypto_provider.IV = System.Text.UnicodeEncoding.Unicode.GetBytes(IV);

            crypto_provider.Mode = CipherMode.CBC;
            crypto_provider.Padding = PaddingMode.PKCS7;
        }

        public String encrypt(String clear_text)//Verschlüsseln
        {
            ICryptoTransform transform = crypto_provider.CreateEncryptor();

            byte[] encrypted_bytes = transform.TransformFinalBlock(ASCIIEncoding.ASCII.GetBytes(clear_text), 0, clear_text.Length);
            //byte[] encrypted_bytes = transform.TransformFinalBlock(UnicodeEncoding.Unicode.GetBytes(clear_text), 0, clear_text.Length);

            string str = Convert.ToBase64String(encrypted_bytes);
            return str;
        }

        public String decrypt(String cipher_text)//Entschlüsseln
        {
            ICryptoTransform transform = crypto_provider.CreateDecryptor();

            byte[] enc_bytes = Convert.FromBase64String(cipher_text);
            byte[] decrypted_bytes = transform.TransformFinalBlock(enc_bytes, 0, enc_bytes.Length);

            string str = ASCIIEncoding.ASCII.GetString(decrypted_bytes);
            //string str = UnicodeEncoding.Unicode.GetString(decrypted_bytes);

            return str;
        }

    }
}
