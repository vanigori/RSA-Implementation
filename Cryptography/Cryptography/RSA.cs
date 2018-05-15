using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.IO;
using Newtonsoft.Json;

namespace Cryptography
{
    public partial class RSA : Form
    {

        private RSAImplementation rsa;

        public RSA()
        {
            InitializeComponent();
            rsa = new RSAImplementation();
            rsa.generateKeys();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            tbxCipherText.Text = rsa.encryptText(tbxPlainText.Text).ToString();
            tbxDecryptedText.Text = rsa.decryptText(BigInteger.Parse(tbxCipherText.Text));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            try
            {
                string fileName = ofd.FileName;
                tbxFileName.Text = fileName;
            } catch (Exception) {}
        }

        private void btnEncryptFile_Click(object sender, EventArgs e)
        {
            pgrStatus.Value = 0;
            pgrStatus.Step = 20;
            lblStatus.Text = pgrStatus.Value.ToString() + "%";
            lblStatusAction.Text = "Starting Encryption";
           pgrStatus.PerformStep();
            lblStatus.Text = pgrStatus.Value.ToString() + "%";
            lblStatusAction.Text = "Creating Ciphertext";
            byte[] file = File.ReadAllBytes(tbxFileName.Text);
           pgrStatus.PerformStep();
            lblStatus.Text = pgrStatus.Value.ToString() + "%";
            lblStatusAction.Text = "Encrypting now";
            byte[] encryptedFile = rsa.encryptFile(file);
           pgrStatus.PerformStep();
            lblStatus.Text = pgrStatus.Value.ToString() + "%";
            lblStatusAction.Text = "Writing encyption to file";
            FileStream f = File.OpenWrite(tbxFileName.Text + ".Encrypted");
            f.Write(encryptedFile, 0, encryptedFile.Length);
            f.Close();
            f.Dispose();
           pgrStatus.PerformStep();
            lblStatus.Text = pgrStatus.Value.ToString() + "%";
           pgrStatus.PerformStep();
            lblStatus.Text = pgrStatus.Value.ToString() + "%";
            lblStatusAction.Text = "Done";
        }

        private void btnDecryptFile_Click(object sender, EventArgs e)
        {
            pgrStatus.Value = 0;
            pgrStatus.Step = 20;
            lblStatus.Text = pgrStatus.Value.ToString() + "%";
            lblStatusAction.Text = "Starting decryption";
            pgrStatus.PerformStep();
            lblStatus.Text = pgrStatus.Value.ToString() + "%";
            lblStatusAction.Text = "Reading ciphertext";
            byte[] file = File.ReadAllBytes(tbxFileName.Text);
            pgrStatus.PerformStep();
            lblStatus.Text = pgrStatus.Value.ToString() + "%";
            lblStatusAction.Text = "Decrypting now";
            byte[] encryptedFile = rsa.decryptFile(file);
            pgrStatus.PerformStep();
            lblStatus.Text = pgrStatus.Value.ToString() + "%";
            lblStatusAction.Text = "Writing decryption to file";
            FileStream f = File.OpenWrite(tbxFileName.Text + ".Decrypted");
            f.Write(encryptedFile, 0, encryptedFile.Length);
            f.Close();
            f.Dispose();
            pgrStatus.PerformStep();
            pgrStatus.PerformStep();
            lblStatus.Text = pgrStatus.Value.ToString() + "%";
            lblStatusAction.Text = "Done";
        }
    }
}
