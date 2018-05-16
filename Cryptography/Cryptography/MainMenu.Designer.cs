namespace Cryptography
{
    partial class MainMenu
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
            this.btnVigenere = new System.Windows.Forms.Button();
            this.btnColumnar = new System.Windows.Forms.Button();
            this.btnRSA = new System.Windows.Forms.Button();
            this.btnVernam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVigenere
            // 
            this.btnVigenere.BackgroundImage = global::Cryptography.Properties.Resources._220px_Vigenere;
            this.btnVigenere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVigenere.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVigenere.ForeColor = System.Drawing.Color.Transparent;
            this.btnVigenere.Location = new System.Drawing.Point(221, 81);
            this.btnVigenere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVigenere.Name = "btnVigenere";
            this.btnVigenere.Size = new System.Drawing.Size(174, 103);
            this.btnVigenere.TabIndex = 14;
            this.btnVigenere.Text = "VIGENERE CIPHER";
            this.btnVigenere.UseVisualStyleBackColor = true;
            this.btnVigenere.Click += new System.EventHandler(this.btnVigenere_Click);
            // 
            // btnColumnar
            // 
            this.btnColumnar.BackgroundImage = global::Cryptography.Properties.Resources.laurendeau;
            this.btnColumnar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColumnar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColumnar.ForeColor = System.Drawing.Color.Red;
            this.btnColumnar.Location = new System.Drawing.Point(403, 81);
            this.btnColumnar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnColumnar.Name = "btnColumnar";
            this.btnColumnar.Size = new System.Drawing.Size(174, 103);
            this.btnColumnar.TabIndex = 12;
            this.btnColumnar.Text = "COLUMNAR TRANSPOSITION";
            this.btnColumnar.UseVisualStyleBackColor = true;
            this.btnColumnar.Click += new System.EventHandler(this.btnColumnar_Click);
            // 
            // btnRSA
            // 
            this.btnRSA.BackgroundImage = global::Cryptography.Properties.Resources.shutterstock_91905962_300x200;
            this.btnRSA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRSA.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRSA.ForeColor = System.Drawing.Color.Red;
            this.btnRSA.Location = new System.Drawing.Point(403, 192);
            this.btnRSA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRSA.Name = "btnRSA";
            this.btnRSA.Size = new System.Drawing.Size(174, 103);
            this.btnRSA.TabIndex = 16;
            this.btnRSA.Text = "RSA";
            this.btnRSA.UseVisualStyleBackColor = true;
            this.btnRSA.Click += new System.EventHandler(this.btnRSA_Click);
            // 
            // btnVernam
            // 
            this.btnVernam.BackgroundImage = global::Cryptography.Properties.Resources.download;
            this.btnVernam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVernam.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVernam.ForeColor = System.Drawing.Color.Red;
            this.btnVernam.Location = new System.Drawing.Point(221, 192);
            this.btnVernam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVernam.Name = "btnVernam";
            this.btnVernam.Size = new System.Drawing.Size(174, 103);
            this.btnVernam.TabIndex = 13;
            this.btnVernam.Text = "VERNAM CIPHER";
            this.btnVernam.UseVisualStyleBackColor = true;
            this.btnVernam.Click += new System.EventHandler(this.btnVernam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(445, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select your choice of encryption";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Cryptography.Properties.Resources.images;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(221, 303);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(356, 87);
            this.btnExit.TabIndex = 15;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cryptography.Properties.Resources.GD_Embedded_Encryption_Hero_02_rev;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 428);
            this.Controls.Add(this.btnVigenere);
            this.Controls.Add(this.btnColumnar);
            this.Controls.Add(this.btnRSA);
            this.Controls.Add(this.btnVernam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cryptography Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVigenere;
        private System.Windows.Forms.Button btnColumnar;
        private System.Windows.Forms.Button btnRSA;
        private System.Windows.Forms.Button btnVernam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}

