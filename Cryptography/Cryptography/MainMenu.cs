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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnVigenere_Click(object sender, EventArgs e)
        {
            Vigenere frm = new Vigenere();
            frm.ShowDialog();
        }

        private void btnColumnar_Click(object sender, EventArgs e)
        {
            Transposition frm = new Transposition();
            frm.ShowDialog();
        }

        private void btnVernam_Click(object sender, EventArgs e)
        {
            Vernam frm = new Vernam();
            frm.ShowDialog();
        }

        private void btnRSA_Click(object sender, EventArgs e)
        {
            RSA frm = new RSA();
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
