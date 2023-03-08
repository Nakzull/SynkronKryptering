namespace SynkronKryptering
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxEncryption = new System.Windows.Forms.ComboBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonEncryptTime = new System.Windows.Forms.Button();
            this.buttonDecryptTime = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBoxIV = new System.Windows.Forms.TextBox();
            this.textBoxPlainText = new System.Windows.Forms.TextBox();
            this.textBoxPlainTextHex = new System.Windows.Forms.TextBox();
            this.textBoxCipherASCII = new System.Windows.Forms.TextBox();
            this.textBoxCipherHex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelTimeToEncrypt = new System.Windows.Forms.Label();
            this.labelTimeToDecrypt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxEncryption
            // 
            this.comboBoxEncryption.FormattingEnabled = true;
            this.comboBoxEncryption.Items.AddRange(new object[] {
            "DES",
            "3DES",
            "AES 128",
            "AES 256",
            "Rijndael 128",
            "Rijndael 256"});
            this.comboBoxEncryption.Location = new System.Drawing.Point(50, 41);
            this.comboBoxEncryption.Name = "comboBoxEncryption";
            this.comboBoxEncryption.Size = new System.Drawing.Size(145, 21);
            this.comboBoxEncryption.TabIndex = 0;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(50, 104);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(145, 37);
            this.buttonGenerate.TabIndex = 1;
            this.buttonGenerate.Text = "Generate Key and IV";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(50, 178);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(145, 37);
            this.buttonEncrypt.TabIndex = 2;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(50, 266);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(145, 37);
            this.buttonDecrypt.TabIndex = 3;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonEncryptTime
            // 
            this.buttonEncryptTime.Location = new System.Drawing.Point(50, 333);
            this.buttonEncryptTime.Name = "buttonEncryptTime";
            this.buttonEncryptTime.Size = new System.Drawing.Size(145, 37);
            this.buttonEncryptTime.TabIndex = 4;
            this.buttonEncryptTime.Text = "Get Encrypt Time";
            this.buttonEncryptTime.UseVisualStyleBackColor = true;
            this.buttonEncryptTime.Click += new System.EventHandler(this.buttonEncryptTime_Click);
            // 
            // buttonDecryptTime
            // 
            this.buttonDecryptTime.Location = new System.Drawing.Point(50, 401);
            this.buttonDecryptTime.Name = "buttonDecryptTime";
            this.buttonDecryptTime.Size = new System.Drawing.Size(145, 37);
            this.buttonDecryptTime.TabIndex = 5;
            this.buttonDecryptTime.Text = "Get Decrypt Time";
            this.buttonDecryptTime.UseVisualStyleBackColor = true;
            this.buttonDecryptTime.Click += new System.EventHandler(this.buttonDecryptTime_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(448, 41);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(276, 20);
            this.textBoxKey.TabIndex = 6;
            // 
            // textBoxIV
            // 
            this.textBoxIV.Location = new System.Drawing.Point(448, 93);
            this.textBoxIV.Name = "textBoxIV";
            this.textBoxIV.Size = new System.Drawing.Size(276, 20);
            this.textBoxIV.TabIndex = 7;
            // 
            // textBoxPlainText
            // 
            this.textBoxPlainText.Location = new System.Drawing.Point(448, 195);
            this.textBoxPlainText.Name = "textBoxPlainText";
            this.textBoxPlainText.Size = new System.Drawing.Size(276, 20);
            this.textBoxPlainText.TabIndex = 8;
            // 
            // textBoxPlainTextHex
            // 
            this.textBoxPlainTextHex.Location = new System.Drawing.Point(448, 221);
            this.textBoxPlainTextHex.Name = "textBoxPlainTextHex";
            this.textBoxPlainTextHex.ReadOnly = true;
            this.textBoxPlainTextHex.Size = new System.Drawing.Size(276, 20);
            this.textBoxPlainTextHex.TabIndex = 9;
            // 
            // textBoxCipherASCII
            // 
            this.textBoxCipherASCII.Location = new System.Drawing.Point(448, 294);
            this.textBoxCipherASCII.Name = "textBoxCipherASCII";
            this.textBoxCipherASCII.ReadOnly = true;
            this.textBoxCipherASCII.Size = new System.Drawing.Size(276, 20);
            this.textBoxCipherASCII.TabIndex = 10;
            // 
            // textBoxCipherHex
            // 
            this.textBoxCipherHex.Location = new System.Drawing.Point(448, 320);
            this.textBoxCipherHex.Name = "textBoxCipherHex";
            this.textBoxCipherHex.ReadOnly = true;
            this.textBoxCipherHex.Size = new System.Drawing.Size(276, 20);
            this.textBoxCipherHex.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "IV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Plain Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "ASCII";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Hex";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cipher Text";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "ASCII";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Hex";
            // 
            // labelTimeToEncrypt
            // 
            this.labelTimeToEncrypt.AutoSize = true;
            this.labelTimeToEncrypt.Location = new System.Drawing.Point(445, 401);
            this.labelTimeToEncrypt.Name = "labelTimeToEncrypt";
            this.labelTimeToEncrypt.Size = new System.Drawing.Size(141, 13);
            this.labelTimeToEncrypt.TabIndex = 20;
            this.labelTimeToEncrypt.Text = "Time/message at encryption";
            // 
            // labelTimeToDecrypt
            // 
            this.labelTimeToDecrypt.AutoSize = true;
            this.labelTimeToDecrypt.Location = new System.Drawing.Point(445, 442);
            this.labelTimeToDecrypt.Name = "labelTimeToDecrypt";
            this.labelTimeToDecrypt.Size = new System.Drawing.Size(141, 13);
            this.labelTimeToDecrypt.TabIndex = 21;
            this.labelTimeToDecrypt.Text = "Time/message at decryption";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.labelTimeToDecrypt);
            this.Controls.Add(this.labelTimeToEncrypt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCipherHex);
            this.Controls.Add(this.textBoxCipherASCII);
            this.Controls.Add(this.textBoxPlainTextHex);
            this.Controls.Add(this.textBoxPlainText);
            this.Controls.Add(this.textBoxIV);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.buttonDecryptTime);
            this.Controls.Add(this.buttonEncryptTime);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.comboBoxEncryption);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEncryption;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonEncryptTime;
        private System.Windows.Forms.Button buttonDecryptTime;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBoxIV;
        private System.Windows.Forms.TextBox textBoxPlainText;
        private System.Windows.Forms.TextBox textBoxPlainTextHex;
        private System.Windows.Forms.TextBox textBoxCipherASCII;
        private System.Windows.Forms.TextBox textBoxCipherHex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelTimeToEncrypt;
        private System.Windows.Forms.Label labelTimeToDecrypt;
    }
}

