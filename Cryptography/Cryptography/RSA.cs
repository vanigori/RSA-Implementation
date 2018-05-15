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
            
            SymmetricAlgorithm rijn = rsa.encryptFile(tbxFileName.Text, tbxFileName.Text + ".Encrypted");
            string keyFile = tbxFileName.Text + ".key";
            File.WriteAllBytes(keyFile, rijn.Key);
            keyFile = tbxFileName.Text + ".IV";
            File.WriteAllBytes(keyFile, rijn.IV);
        }

        private void btnDecryptFile_Click(object sender, EventArgs e)
        {
            string keyFile, ivFile;
            try
            {
                keyFile = tbxFileName.Text.Substring(0, tbxFileName.Text.LastIndexOf(".")) + ".key";
                ivFile = tbxFileName.Text.Substring(0, tbxFileName.Text.LastIndexOf(".")) + ".IV";

                SymmetricAlgorithm rijn = SymmetricAlgorithm.Create();
                rijn.Key = File.ReadAllBytes(keyFile);
                rijn.IV = File.ReadAllBytes(ivFile);

                rsa.decryptFile(tbxFileName.Text, tbxFileName.Text.Substring(0, tbxFileName.Text.LastIndexOf(".")) + ".Decrypted", rijn);

            }
            catch (Exception ex) { }
        }
    }
}
