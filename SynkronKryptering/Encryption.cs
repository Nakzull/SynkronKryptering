using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SynkronKryptering
{
    internal class Encryption
    {
        public byte[] Encrypt(byte[] dataToEncrypt, SymmetricAlgorithm symmetricAlgorithm)
        {
            MemoryStream ms = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(ms, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
            cryptoStream.Write(dataToEncrypt, 0, dataToEncrypt.Length);
            cryptoStream.Close();
            return ms.ToArray();
        }

        public byte[] Decrypt(byte[] dataToDecrypt, SymmetricAlgorithm symmetricAlgorithm)
        {
            byte[] plaintext = new byte[dataToDecrypt.Length];
            MemoryStream ms = new MemoryStream(dataToDecrypt);
            CryptoStream cryptoStream = new CryptoStream(ms, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Read);
            cryptoStream.Read(plaintext, 0, dataToDecrypt.Length);
            cryptoStream.Close();
            return plaintext;
        }

        public string PlainTextHexPrint(string input)
        {
            byte[] ba = Encoding.Default.GetBytes(input);
            var hexString = BitConverter.ToString(ba);
            hexString = hexString.Replace("-", "");
            hexString = hexString.Replace("00", "");
            return hexString;
        }
    }
}
