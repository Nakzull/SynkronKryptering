using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SynkronKryptering
{
    internal class SymAlgo
    {
        KeyAndIV keyAndIV = new KeyAndIV();
        SymmetricAlgorithm symmetricAlgorithm;
        public SymmetricAlgorithm GenerateFull(int index)
        {
            int keyLength = 0;
            int iVLength = 0;
            if (index == 0 || index == 1)
            {
                symmetricAlgorithm = DES.Create();
                keyLength = 8;
                iVLength = 8;
            }
            else if (index == 2)
            {
                symmetricAlgorithm = Aes.Create();
                keyLength = 16;
                iVLength = 16;
            }
            else if (index == 3)
            {
                symmetricAlgorithm = Aes.Create();
                keyLength = 32;
                iVLength = 16;
            }
            else if (index == 4)
            {
                symmetricAlgorithm = Rijndael.Create();
                keyLength= 16;
                iVLength= 16;
            }
            else if (index == 5)
            {
                symmetricAlgorithm = Rijndael.Create();
                keyLength = 32;
                iVLength = 16;
            }

            symmetricAlgorithm.Key = keyAndIV.GenerateRandomNumber(keyLength);
            symmetricAlgorithm.IV = keyAndIV.GenerateRandomNumber(iVLength);
            return symmetricAlgorithm;
        }
        public SymmetricAlgorithm GenerateMode(int index)
        {
            if (index == 0 || index == 1)
            {
                symmetricAlgorithm = DES.Create();
            }
            else if (index == 2 || index == 3)
            {
                symmetricAlgorithm = Aes.Create();
            }
            else if (index == 4 || index == 5)
            {
                symmetricAlgorithm = Rijndael.Create();
            }

            return symmetricAlgorithm;
        }
    }
}
