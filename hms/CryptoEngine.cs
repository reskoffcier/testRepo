using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace hms
{
    class CryptoEngine
    {
        public static string Encrypt(string plainText)
        {
            return EncryptHashMD5(plainText, true);
        }

        public static string Decrypt(string cipherText)
        {
            return DecryptHashMD5(cipherText, true);
        }

        private static string EncryptHashMD5(string toEncrypt, bool useHashing)
        {
            var bytes = Encoding.UTF8.GetBytes(toEncrypt);
            var s = "@%mahedee#@leads$&";
            byte[] numArray;
            if (useHashing)
            {
                var cryptoServiceProvider = new MD5CryptoServiceProvider();
                numArray = cryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(s));
                cryptoServiceProvider.Clear();
            }
            else
                numArray = Encoding.UTF8.GetBytes(s);
            var cryptoServiceProvider1 = new TripleDESCryptoServiceProvider
            {
                Key = numArray,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            var inArray = cryptoServiceProvider1.CreateEncryptor().TransformFinalBlock(bytes, 0, bytes.Length);
            cryptoServiceProvider1.Clear();
            return Convert.ToBase64String(inArray, 0, inArray.Length);
        }

        private static string DecryptHashMD5(string cipherString, bool useHashing)
        {
            var inputBuffer = Convert.FromBase64String(cipherString);
            var s = "@%mahedee#@leads$&";
            byte[] numArray;
            if (useHashing)
            {
                var cryptoServiceProvider = new MD5CryptoServiceProvider();
                numArray = cryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(s));
                cryptoServiceProvider.Clear();
            }
            else
                numArray = Encoding.UTF8.GetBytes(s);
            var cryptoServiceProvider1 = new TripleDESCryptoServiceProvider
            {
                Key = numArray,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            var bytes = cryptoServiceProvider1.CreateDecryptor().TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
            cryptoServiceProvider1.Clear();
            return Encoding.UTF8.GetString(bytes);
        }
    }
}
