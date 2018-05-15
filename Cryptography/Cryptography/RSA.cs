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
using System.Security.Cryptography;

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
            tbxCipherText.Text = "";
            tbxDecryptedText.Text = "";
            tbxFileName.Text = "";
            tbxPlainText.Text = "";
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
            pgrStatus.Step = 33;
            lblStatusAction.Text = "Encrypting File";
            SymmetricAlgorithm rijn = rsa.encryptFile(tbxFileName.Text, tbxFileName.Text + ".Encrypted");
            pgrStatus.PerformStep();
            lblStatusAction.Text = "Writing key to file";
            string keyFile = tbxFileName.Text + ".key";
            File.WriteAllBytes(keyFile, rijn.Key);
            pgrStatus.PerformStep();
            lblStatusAction.Text = "Writing IV to file";
            keyFile = tbxFileName.Text + ".IV";
            File.WriteAllBytes(keyFile, rijn.IV);
            pgrStatus.PerformStep();
            lblStatusAction.Text = "Done";
            pgrStatus.Value = 100;
        }

        private void btnDecryptFile_Click(object sender, EventArgs e)
        {
            string keyFile, ivFile;
            try
            {
                pgrStatus.Value = 0;
                pgrStatus.Step = 25;
                lblStatusAction.Text = "Loading key file";
                keyFile = tbxFileName.Text.Substring(0, tbxFileName.Text.LastIndexOf(".")) + ".key";
                pgrStatus.PerformStep();
                lblStatusAction.Text = "Loading IV file";
                ivFile = tbxFileName.Text.Substring(0, tbxFileName.Text.LastIndexOf(".")) + ".IV";
                pgrStatus.PerformStep();

                lblStatusAction.Text = "Creating algorithm object and iniliatizing variables";
                SymmetricAlgorithm rijn = SymmetricAlgorithm.Create();
                rijn.Key = File.ReadAllBytes(keyFile);
                rijn.IV = File.ReadAllBytes(ivFile);
                pgrStatus.PerformStep();

                lblStatusAction.Text = "Decrypting";
                rsa.decryptFile(tbxFileName.Text, tbxFileName.Text.Substring(0, tbxFileName.Text.LastIndexOf(".")) + ".Decrypted", rijn);
                pgrStatus.PerformStep();
            }
            catch (Exception ex) { }
        }
    }
}
