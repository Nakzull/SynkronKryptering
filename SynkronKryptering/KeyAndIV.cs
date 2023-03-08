using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SynkronKryptering
{
    internal class KeyAndIV
    {
        public byte[] GenerateRandomNumber(int length)
        {
            using (var randomNumberGenerator = new RNGCryptoServiceProvider())
            {
                var randomNumber = new byte[length];
                randomNumberGenerator.GetBytes(randomNumber);

                return randomNumber;
            }
        }

        public string PrintKey(SymmetricAlgorithm symmetricAlgorithm)
        {
            string textKey = "";
            foreach (byte c in symmetricAlgorithm.Key)
            {
                textKey += c;
            }

            string s = Convert.ToBase64String(symmetricAlgorithm.Key);

            return textKey;
        }

        public string PrintIV(SymmetricAlgorithm symmetricAlgorithm)
        {
            string textIV = "";
            foreach (byte c in symmetricAlgorithm.IV)
            {
                textIV += c;
            }
            return textIV;
        }
    }
}
