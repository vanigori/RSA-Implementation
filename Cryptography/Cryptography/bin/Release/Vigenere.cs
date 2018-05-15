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
    public partial class Vigenere : Form
    {

        private VigenereCipher vc;

        public Vigenere()
        {
            InitializeComponent();
            vc = new VigenereCipher("aaa");

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            //
            if (tbKey.Text == "")
                tbKey.Text = "aaa";
            else
                vc = new VigenereCipher(tbKey.Text);

            tbCipher.Text = vc.encrypt(tbPlain.Text);
            
            
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            //
            if (tbCipher.Text == "" || tbKey.Text == "")
                MessageBox.Show("Enter the cipher text and the key.");
            else
            {
                vc = new VigenereCipher(tbKey.Text);
                tbDecrypted.Text = vc.decrypt(tbCipher.Text);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbCipher.Text = "";
            tbDecrypted.Text = "";
            tbKey.Text = "";
            tbPlain.Text = "";
            vc = new VigenereCipher("aaa");
        }

        private void tbPlain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"^[a-zA-Z]+$"))
                e.Handled = true;
        }

        private void tbKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"^[a-zA-Z]+$"))
                e.Handled = true;
        }

        private void tbCipher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"^[a-zA-Z]+$"))
                e.Handled = true;
        }
    }
}
