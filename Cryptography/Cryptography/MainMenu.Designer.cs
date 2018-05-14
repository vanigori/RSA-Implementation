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
            this.btnVigenere.Location = new System.Drawing.Point(221, 81);
            this.btnVigenere.Margin = new System.Windows.Forms.Padding(4);
            this.btnVigenere.Name = "btnVigenere";
            this.btnVigenere.Size = new System.Drawing.Size(174, 103);
            this.btnVigenere.TabIndex = 14;
            this.btnVigenere.Text = "Vigenere Cipher";
            this.btnVigenere.UseVisualStyleBackColor = true;
            this.btnVigenere.Click += new System.EventHandler(this.btnVigenere_Click);
            // 
            // btnColumnar
            // 
            this.btnColumnar.Location = new System.Drawing.Point(403, 81);
            this.btnColumnar.Margin = new System.Windows.Forms.Padding(4);
            this.btnColumnar.Name = "btnColumnar";
            this.btnColumnar.Size = new System.Drawing.Size(174, 103);
            this.btnColumnar.TabIndex = 12;
            this.btnColumnar.Text = "Columnar Transposition";
            this.btnColumnar.UseVisualStyleBackColor = true;
            this.btnColumnar.Click += new System.EventHandler(this.btnColumnar_Click);
            // 
            // btnRSA
            // 
            this.btnRSA.Location = new System.Drawing.Point(403, 192);
            this.btnRSA.Margin = new System.Windows.Forms.Padding(4);
            this.btnRSA.Name = "btnRSA";
            this.btnRSA.Size = new System.Drawing.Size(174, 103);
            this.btnRSA.TabIndex = 16;
            this.btnRSA.Text = "RSA";
            this.btnRSA.UseVisualStyleBackColor = true;
            this.btnRSA.Click += new System.EventHandler(this.btnRSA_Click);
            // 
            // btnVernam
            // 
            this.btnVernam.Location = new System.Drawing.Point(221, 192);
            this.btnVernam.Margin = new System.Windows.Forms.Padding(4);
            this.btnVernam.Name = "btnVernam";
            this.btnVernam.Size = new System.Drawing.Size(174, 103);
            this.btnVernam.TabIndex = 13;
            this.btnVernam.Text = "Vernam Cipher";
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
            this.btnExit.Location = new System.Drawing.Point(221, 303);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(356, 28);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 428);
            this.Controls.Add(this.btnVigenere);
            this.Controls.Add(this.btnColumnar);
            this.Controls.Add(this.btnRSA);
            this.Controls.Add(this.btnVernam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Name = "MainMenu";
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

