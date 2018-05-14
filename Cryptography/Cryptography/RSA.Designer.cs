namespace Cryptography
{
    partial class RSA
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnDecryptFile = new System.Windows.Forms.Button();
            this.btnEncryptFile = new System.Windows.Forms.Button();
            this.pgrStatus = new System.Windows.Forms.ProgressBar();
            this.lblFile = new System.Windows.Forms.Label();
            this.tbxFileName = new System.Windows.Forms.RichTextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxCipherText = new System.Windows.Forms.RichTextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.tbxPlainText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxDecryptedText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.btnDecryptFile);
            this.groupBox2.Controls.Add(this.btnEncryptFile);
            this.groupBox2.Controls.Add(this.pgrStatus);
            this.groupBox2.Controls.Add(this.lblFile);
            this.groupBox2.Controls.Add(this.tbxFileName);
            this.groupBox2.Controls.Add(this.btnSelectFile);
            this.groupBox2.Location = new System.Drawing.Point(523, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 454);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Encryption";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(305, 239);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(28, 17);
            this.lblStatus.TabIndex = 29;
            this.lblStatus.Text = "0%";
            // 
            // btnDecryptFile
            // 
            this.btnDecryptFile.Location = new System.Drawing.Point(206, 148);
            this.btnDecryptFile.Name = "btnDecryptFile";
            this.btnDecryptFile.Size = new System.Drawing.Size(127, 34);
            this.btnDecryptFile.TabIndex = 28;
            this.btnDecryptFile.Text = "Decrypt File";
            this.btnDecryptFile.UseVisualStyleBackColor = true;
            // 
            // btnEncryptFile
            // 
            this.btnEncryptFile.Location = new System.Drawing.Point(35, 148);
            this.btnEncryptFile.Name = "btnEncryptFile";
            this.btnEncryptFile.Size = new System.Drawing.Size(127, 34);
            this.btnEncryptFile.TabIndex = 27;
            this.btnEncryptFile.Text = "Encrypt File";
            this.btnEncryptFile.UseVisualStyleBackColor = true;
            // 
            // pgrStatus
            // 
            this.pgrStatus.Location = new System.Drawing.Point(10, 213);
            this.pgrStatus.Name = "pgrStatus";
            this.pgrStatus.Size = new System.Drawing.Size(323, 23);
            this.pgrStatus.TabIndex = 26;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(7, 41);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(30, 17);
            this.lblFile.TabIndex = 25;
            this.lblFile.Text = "File";
            // 
            // tbxFileName
            // 
            this.tbxFileName.Location = new System.Drawing.Point(6, 62);
            this.tbxFileName.Name = "tbxFileName";
            this.tbxFileName.Size = new System.Drawing.Size(327, 34);
            this.tbxFileName.TabIndex = 24;
            this.tbxFileName.Text = "";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(206, 104);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(127, 34);
            this.btnSelectFile.TabIndex = 23;
            this.btnSelectFile.Text = "Select File...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxCipherText);
            this.groupBox1.Controls.Add(this.btnDecrypt);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnEncrypt);
            this.groupBox1.Controls.Add(this.tbxPlainText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxDecryptedText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(87, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 454);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text Encryption";
            // 
            // tbxCipherText
            // 
            this.tbxCipherText.Location = new System.Drawing.Point(7, 169);
            this.tbxCipherText.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCipherText.Name = "tbxCipherText";
            this.tbxCipherText.Size = new System.Drawing.Size(329, 107);
            this.tbxCipherText.TabIndex = 25;
            this.tbxCipherText.Text = "";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(209, 283);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(128, 34);
            this.btnDecrypt.TabIndex = 32;
            this.btnDecrypt.Text = "Decrypt Text";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(109, 378);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 34);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(209, 104);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(128, 34);
            this.btnEncrypt.TabIndex = 22;
            this.btnEncrypt.Text = "Encrypt Text";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            // 
            // tbxPlainText
            // 
            this.tbxPlainText.Location = new System.Drawing.Point(8, 62);
            this.tbxPlainText.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPlainText.Name = "tbxPlainText";
            this.tbxPlainText.Size = new System.Drawing.Size(329, 34);
            this.tbxPlainText.TabIndex = 24;
            this.tbxPlainText.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 317);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Decrypted Text";
            // 
            // tbxDecryptedText
            // 
            this.tbxDecryptedText.Location = new System.Drawing.Point(9, 337);
            this.tbxDecryptedText.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDecryptedText.Name = "tbxDecryptedText";
            this.tbxDecryptedText.Size = new System.Drawing.Size(328, 31);
            this.tbxDecryptedText.TabIndex = 26;
            this.tbxDecryptedText.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Cipher Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Plaintext";
            // 
            // RSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 616);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RSA";
            this.Text = "RSA";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnDecryptFile;
        private System.Windows.Forms.Button btnEncryptFile;
        private System.Windows.Forms.ProgressBar pgrStatus;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.RichTextBox tbxFileName;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox tbxCipherText;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.RichTextBox tbxPlainText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox tbxDecryptedText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}