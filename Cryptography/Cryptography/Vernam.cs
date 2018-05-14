using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Cryptography
{
    public partial class Vernam : Form
    {
        CipherClass encryptedCipher;
        string fileName;
        public Vernam()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            encryptedCipher = VernamClass.encrypt(tbxPlainText.Text);
            tbxCipherText.Text = (string)encryptedCipher.cipher;
            string output = "";
            foreach (int key in encryptedCipher.key)
            {
                 output += key.ToString() + " ";
            }
            tbxKey.Text = output;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            tbxDecryptedText.Text =  VernamClass.decrypt(encryptedCipher);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            encryptedCipher = null;
            tbxCipherText.Clear();
            tbxDecryptedText.Clear();
            tbxKey.Clear();
            tbxPlainText.Clear();
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
                encryptedCipher = VernamClass.encrypt(fileName, true);
                pgrStatus.PerformStep();
                lblStatus.Text = pgrStatus.Value.ToString() + "%";
                lblStatusAction.Text = "Saving .key File";
                ByteArrayToFile(fileName + ".key", encryptedCipher.byteKey);
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

        public static bool ByteArrayToFile(string fileName, byte[] byteArray)
        {
            try
            {
                using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(byteArray, 0, byteArray.Length);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in process: {0}", ex);
                return false;
            }
        }

        private void btnDecryptFile_Click(object sender, EventArgs e)
        {
            try
            {
                pgrStatus.Value = 0;
                pgrStatus.Step = 33;
                lblStatus.Text = pgrStatus.Value.ToString() + "%";
                lblStatusAction.Text = "Starting Decryption";
                pgrStatus.PerformStep();
                lblStatus.Text = pgrStatus.Value.ToString() + "%";
                lblStatusAction.Text = "Creating Plaintext";
                VernamClass.decrypt(fileName, File.ReadAllBytes(fileName.Replace(".vernam",".key")));
                pgrStatus.PerformStep();
                lblStatus.Text = pgrStatus.Value.ToString() + "%";
                lblStatusAction.Text = "Saving .decrypted File";
                pgrStatus.Value = 100;
                lblStatus.Text = pgrStatus.Value.ToString() + "%";
                lblStatusAction.Text = "Done";
            }
            catch (IOException)
            {
                MessageBox.Show("Please ensure that the .key file is in the same directory as the encrypted file.");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
