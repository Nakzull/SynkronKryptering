using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        Encryption encryption = new Encryption();
        Stopwatch stopWatch = new Stopwatch();
        TimeSpan encodingTime;
        TimeSpan decodingTime;
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
                textBoxKey.Text = Convert.ToBase64String(symmetricAlgorithm.Key);
                textBoxIV.Text = Convert.ToBase64String(symmetricAlgorithm.IV);
            }
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if (textBoxKey.Text != null && !string.IsNullOrWhiteSpace(textBoxKey.Text) && textBoxIV.Text != null && !string.IsNullOrWhiteSpace(textBoxIV.Text))
            {
                SymmetricAlgorithm symmetricAlgorithm = symAlgo.GenerateMode(comboBoxEncryption.SelectedIndex);
                symmetricAlgorithm.Key = Convert.FromBase64String(textBoxKey.Text);
                symmetricAlgorithm.IV = Convert.FromBase64String(textBoxIV.Text);
                var plainTextBytes = Encoding.UTF8.GetBytes(textBoxPlainText.Text);
                var whatever = Convert.ToBase64String(plainTextBytes);
                stopWatch.Reset();
                stopWatch.Start();
                var encrypted = encryption.Encrypt(Encoding.ASCII.GetBytes(textBoxPlainText.Text), symmetricAlgorithm);
                stopWatch.Stop();
                encodingTime = stopWatch.Elapsed;

                textBoxPlainTextHex.Text = encryption.PlainTextHexPrint(textBoxPlainText.Text);
                textBoxCipherASCII.Text = Convert.ToBase64String(encrypted);
                textBoxCipherHex.Text = BitConverter.ToString(encrypted).Replace("-", "");
                textBoxPlainText.Text = "";
            }
            else
            {
                MessageBox.Show("Du skal generere en key og iv før du kan kryptere");
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            if (textBoxKey.Text != null && !string.IsNullOrWhiteSpace(textBoxKey.Text) && textBoxIV.Text != null && !string.IsNullOrWhiteSpace(textBoxIV.Text))
            {
                SymmetricAlgorithm symmetricAlgorithm = symAlgo.GenerateMode(comboBoxEncryption.SelectedIndex);

                symmetricAlgorithm.Key = Convert.FromBase64String(textBoxKey.Text);
                symmetricAlgorithm.IV = Convert.FromBase64String(textBoxIV.Text);
                stopWatch.Reset();
                stopWatch.Start();
                var decrypt = encryption.Decrypt(Convert.FromBase64String(textBoxCipherASCII.Text), symmetricAlgorithm);
                stopWatch.Stop();
                decodingTime = stopWatch.Elapsed;

                textBoxPlainTextHex.Text = encryption.PlainTextHexPrint(Encoding.Default.GetString(decrypt));
                textBoxPlainText.Text = Encoding.Default.GetString(decrypt);
            }
            else
            {
                MessageBox.Show("Du skal angive en key og iv før du kan dekryptere");
            }
        }

        private void buttonEncryptTime_Click(object sender, EventArgs e)
        {
            labelTimeToEncrypt.Text = encodingTime.ToString();
        }

        private void buttonDecryptTime_Click(object sender, EventArgs e)
        {
            labelTimeToDecrypt.Text = decodingTime.ToString();
        }
    }
}
