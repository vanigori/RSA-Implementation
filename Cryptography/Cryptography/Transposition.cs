using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography
{
    public partial class Transposition : Form
    {

        string encryptedText;
        string key;
        string fileName;
        
        public Transposition()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            key = tbxKey.Text;
            encryptedText = TranspositionClass.encrypt(tbxPlainText.Text, key);
            tbxCipherText.Text = encryptedText;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            tbxDecryptedText.Text = TranspositionClass.decrypt(encryptedText, key);
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            try
            {
                fileName = ofd.FileName;
                tbxFileName.Text = fileName;
            }
            catch (Exception)
            {

            }
        }

        private void btnEncryptFile_Click(object sender, EventArgs e)
        {
            try
            {
                pgrStatus.Value = 0;
                pgrStatus.Step = 33;
                lblStatus.Text = pgrStatus.Value.ToString() + "%";
                lblStatusAction.Text = "Starting Encryption";
                pgrStatus.PerformStep();
                lblStatus.Text = pgrStatus.Value.ToString() + "%";
                lblStatusAction.Text = "Creating Ciphertext";
                TranspositionClass.encryptFile(fileName, tbxKey.Text);
                pgrStatus.PerformStep();
                lblStatus.Text = pgrStatus.Value.ToString() + "%";
                lblStatusAction.Text = "Saving .key File";
                pgrStatus.Value = 100;
                lblStatus.Text = pgrStatus.Value.ToString() + "%";
                lblStatusAction.Text = "Done";
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("Out of Memory Exception occurred. Please select a smaller file.");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong.");
            }
        }

        private void btnDecryptFile_Click(object sender, EventArgs e)
        {
            try
            {
                pgrStatus.Value = 0;
                pgrStatus.Step = 33;
                lblStatus.Text = pgrStatus.Value.ToString() + "%";
                lblStatusAction.Text = "Starting Encryption";
                pgrStatus.PerformStep();
                lblStatus.Text = pgrStatus.Value.ToString() + "%";
                lblStatusAction.Text = "Creating Ciphertext";
                TranspositionClass.decryptFile(fileName, tbxKey.Text);
                pgrStatus.PerformStep();
                lblStatus.Text = pgrStatus.Value.ToString() + "%";
                lblStatusAction.Text = "Saving .key File";
                pgrStatus.Value = 100;
                lblStatus.Text = pgrStatus.Value.ToString() + "%";
                lblStatusAction.Text = "Done";
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("Out of Memory Exception occurred. Please select a smaller file.");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong.");
            }
        }
    }
}
