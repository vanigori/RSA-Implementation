namespace Cryptography
{
    partial class Vigenere
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
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDecrypted = new System.Windows.Forms.TextBox();
            this.tbCipher = new System.Windows.Forms.TextBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.tbPlain = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(221, 680);
            this.btnClear.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(253, 67);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 563);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 32);
            this.label3.TabIndex = 29;
            this.label3.Text = "Decrypted Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 398);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 32);
            this.label2.TabIndex = 28;
            this.label2.Text = "Cipher Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 27;
            this.label1.Text = "Plaintext";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(421, 310);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(256, 67);
            this.btnEncrypt.TabIndex = 22;
            this.btnEncrypt.Text = "Encrypt Text";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(421, 496);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(256, 67);
            this.btnDecrypt.TabIndex = 32;
            this.btnDecrypt.Text = "Decrypt Text";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDecrypted);
            this.groupBox1.Controls.Add(this.tbCipher);
            this.groupBox1.Controls.Add(this.tbKey);
            this.groupBox1.Controls.Add(this.tbPlain);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnDecrypt);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnEncrypt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(69, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(752, 782);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text Encryption";
            // 
            // tbDecrypted
            // 
            this.tbDecrypted.Location = new System.Drawing.Point(16, 601);
            this.tbDecrypted.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbDecrypted.Name = "tbDecrypted";
            this.tbDecrypted.ReadOnly = true;
            this.tbDecrypted.Size = new System.Drawing.Size(657, 38);
            this.tbDecrypted.TabIndex = 43;
            // 
            // tbCipher
            // 
            this.tbCipher.Location = new System.Drawing.Point(21, 436);
            this.tbCipher.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbCipher.Name = "tbCipher";
            this.tbCipher.Size = new System.Drawing.Size(657, 38);
            this.tbCipher.TabIndex = 42;
            this.tbCipher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCipher_KeyPress);
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(21, 231);
            this.tbKey.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(657, 38);
            this.tbKey.TabIndex = 41;
            this.tbKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKey_KeyPress);
            // 
            // tbPlain
            // 
            this.tbPlain.Location = new System.Drawing.Point(13, 119);
            this.tbPlain.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbPlain.Name = "tbPlain";
            this.tbPlain.Size = new System.Drawing.Size(657, 38);
            this.tbPlain.TabIndex = 40;
            this.tbPlain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPlain_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 32);
            this.label4.TabIndex = 34;
            this.label4.Text = "Key";
            // 
            // Vigenere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(883, 863);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Vigenere";
            this.Text = "Vigenere";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPlain;
        private System.Windows.Forms.TextBox tbDecrypted;
        private System.Windows.Forms.TextBox tbCipher;
        private System.Windows.Forms.TextBox tbKey;
    }
}