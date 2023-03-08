using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynkronKryptering
{
    public partial class Form1 : Form
    {
        SymAlgo symAlgo = new SymAlgo();
        KeyAndIV keyAndIV = new KeyAndIV();
        Encryption encryption = new Encryption();
        SymmetricAlgorithm symmetricAlgorithm;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (comboBoxEncryption.SelectedIndex < 0 || comboBoxEncryption.SelectedIndex > 5)
            {
                MessageBox.Show("Du skal vælge en krypterings algoritme i dropdown boxen");
            }
            else
            {
                SymmetricAlgorithm symmetricAlgorithm = symAlgo.GenerateFull(comboBoxEncryption.SelectedIndex);
                textBoxKey.Text = keyAndIV.PrintKey(symmetricAlgorithm);
                textBoxIV.Text = keyAndIV.PrintIV(symmetricAlgorithm);
            }
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            symmetricAlgorithm.Key = Encoding.ASCII.GetBytes(textBoxKey.Text);
            if (textBoxKey.Text != null && !string.IsNullOrWhiteSpace(textBoxKey.Text) && textBoxIV.Text != null && !string.IsNullOrWhiteSpace(textBoxIV.Text))
            {
                symmetricAlgorithm.Key = Encoding.ASCII.GetBytes(BitConverter.GetBytes(textBoxKey.Text));
                symmetricAlgorithm.IV = Encoding.ASCII.GetBytes(textBoxIV.Text);
                //SymmetricAlgorithm symmetricAlgorithm = symAlgo.GenerateMode(comboBoxEncryption.SelectedIndex);
                //string userInput = textBoxPlainText.Text;
                //var encrypted = encryption.Encrypt(Encoding.UTF8.GetBytes(userInput), Encoding.ASCII.GetBytes(textBoxKey.Text), Encoding.ASCII.GetBytes(textBoxIV.Text));
                //textBoxCipherASCII.Text = encrypted.ToString();
                var encrypted = encryption.Encrypt(Encoding.ASCII.GetBytes(textBoxPlainText.Text), symmetricAlgorithm);

                string encryptedText = "";
                foreach (byte c in encrypted)
                {
                    encryptedText += c;
                }

                textBoxCipherASCII.Text = encryptedText;
            }
            else
            {
                MessageBox.Show("Du skal generere en key og iv før du kan kryptere");
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {

        }

        private void buttonEncryptTime_Click(object sender, EventArgs e)
        {

        }

        private void buttonDecryptTime_Click(object sender, EventArgs e)
        {

        }
    }
}
