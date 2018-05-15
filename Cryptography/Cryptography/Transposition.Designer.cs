namespace Cryptography
{
    partial class Transposition
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
            this.lblStatusAction = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnDecryptFile = new System.Windows.Forms.Button();
            this.btnEncryptFile = new System.Windows.Forms.Button();
            this.pgrStatus = new System.Windows.Forms.ProgressBar();
            this.lblFile = new System.Windows.Forms.Label();
            this.tbxFileName = new System.Windows.Forms.RichTextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxKey = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxCipherText = new System.Windows.Forms.RichTextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.tbxPlainText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxDecryptedText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxFileKey = new System.Windows.Forms.RichTextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxFileKey);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblStatusAction);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.btnDecryptFile);
            this.groupBox2.Controls.Add(this.btnEncryptFile);
            this.groupBox2.Controls.Add(this.pgrStatus);
            this.groupBox2.Controls.Add(this.lblFile);
            this.groupBox2.Controls.Add(this.tbxFileName);
            this.groupBox2.Controls.Add(this.btnSelectFile);
            this.groupBox2.Location = new System.Drawing.Point(515, 54);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(361, 506);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Encryption";
            // 
            // lblStatusAction
            // 
            this.lblStatusAction.AutoSize = true;
            this.lblStatusAction.Location = new System.Drawing.Point(8, 241);
            this.lblStatusAction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusAction.Name = "lblStatusAction";
            this.lblStatusAction.Size = new System.Drawing.Size(69, 17);
            this.lblStatusAction.TabIndex = 30;
            this.lblStatusAction.Text = "No Action";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(306, 286);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(28, 17);
            this.lblStatus.TabIndex = 29;
            this.lblStatus.Text = "0%";
            // 
            // btnDecryptFile
            // 
            this.btnDecryptFile.Location = new System.Drawing.Point(206, 195);
            this.btnDecryptFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDecryptFile.Name = "btnDecryptFile";
            this.btnDecryptFile.Size = new System.Drawing.Size(127, 34);
            this.btnDecryptFile.TabIndex = 28;
            this.btnDecryptFile.Text = "Decrypt File";
            this.btnDecryptFile.UseVisualStyleBackColor = true;
            this.btnDecryptFile.Click += new System.EventHandler(this.btnDecryptFile_Click);
            // 
            // btnEncryptFile
            // 
            this.btnEncryptFile.Location = new System.Drawing.Point(36, 195);
            this.btnEncryptFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEncryptFile.Name = "btnEncryptFile";
            this.btnEncryptFile.Size = new System.Drawing.Size(127, 34);
            this.btnEncryptFile.TabIndex = 27;
            this.btnEncryptFile.Text = "Encrypt File";
            this.btnEncryptFile.UseVisualStyleBackColor = true;
            this.btnEncryptFile.Click += new System.EventHandler(this.btnEncryptFile_Click);
            // 
            // pgrStatus
            // 
            this.pgrStatus.Location = new System.Drawing.Point(12, 260);
            this.pgrStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.tbxFileName.Location = new System.Drawing.Point(5, 62);
            this.tbxFileName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxFileName.Name = "tbxFileName";
            this.tbxFileName.Size = new System.Drawing.Size(327, 34);
            this.tbxFileName.TabIndex = 24;
            this.tbxFileName.Text = "";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(205, 102);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(127, 34);
            this.btnSelectFile.TabIndex = 23;
            this.btnSelectFile.Text = "Select File...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxKey);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxCipherText);
            this.groupBox1.Controls.Add(this.btnDecrypt);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnEncrypt);
            this.groupBox1.Controls.Add(this.tbxPlainText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxDecryptedText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(77, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(376, 506);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text Encryption";
            // 
            // tbxKey
            // 
            this.tbxKey.Location = new System.Drawing.Point(11, 126);
            this.tbxKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxKey.Name = "tbxKey";
            this.tbxKey.Size = new System.Drawing.Size(329, 35);
            this.tbxKey.TabIndex = 34;
            this.tbxKey.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Key";
            // 
            // tbxCipherText
            // 
            this.tbxCipherText.Location = new System.Drawing.Point(8, 224);
            this.tbxCipherText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxCipherText.Name = "tbxCipherText";
            this.tbxCipherText.Size = new System.Drawing.Size(329, 107);
            this.tbxCipherText.TabIndex = 25;
            this.tbxCipherText.Text = "";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(211, 340);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(128, 34);
            this.btnDecrypt.TabIndex = 32;
            this.btnDecrypt.Text = "Decrypt Text";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(111, 434);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 34);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(211, 169);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(128, 34);
            this.btnEncrypt.TabIndex = 22;
            this.btnEncrypt.Text = "Encrypt Text";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // tbxPlainText
            // 
            this.tbxPlainText.Location = new System.Drawing.Point(8, 62);
            this.tbxPlainText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxPlainText.Name = "tbxPlainText";
            this.tbxPlainText.Size = new System.Drawing.Size(329, 34);
            this.tbxPlainText.TabIndex = 24;
            this.tbxPlainText.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 374);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Decrypted Text";
            // 
            // tbxDecryptedText
            // 
            this.tbxDecryptedText.Location = new System.Drawing.Point(11, 394);
            this.tbxDecryptedText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxDecryptedText.Name = "tbxDecryptedText";
            this.tbxDecryptedText.Size = new System.Drawing.Size(328, 31);
            this.tbxDecryptedText.TabIndex = 26;
            this.tbxDecryptedText.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 204);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Key";
            // 
            // tbxFileKey
            // 
            this.tbxFileKey.Location = new System.Drawing.Point(7, 143);
            this.tbxFileKey.Name = "tbxFileKey";
            this.tbxFileKey.Size = new System.Drawing.Size(327, 36);
            this.tbxFileKey.TabIndex = 32;
            this.tbxFileKey.Text = "";
            // 
            // Transposition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 741);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Transposition";
            this.Text = "Transposition";
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
        private System.Windows.Forms.RichTextBox tbxKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatusAction;
        private System.Windows.Forms.RichTextBox tbxFileKey;
        private System.Windows.Forms.Label label5;
    }
}