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
    }
}
