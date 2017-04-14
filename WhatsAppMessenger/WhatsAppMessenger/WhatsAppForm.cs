using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsAppApi;

namespace WhatsAppMessenger
{
    public partial class WhatsAppForm : Form
    {
        WhatsApp wa;

        public WhatsAppForm()
        {
            InitializeComponent();
        }

        private void WhatsAppForm_Load(object sender, EventArgs e)
        {
            signOutToolStripMenuItem.Visible = false;
            panel1.BringToFront();
            if(Properties.Settings.Default.Remember)
            {
                txtNumber.Text = Properties.Settings.Default.PhoneNumber;
                txtPassword.Text = Properties.Settings.Default.Password;
                chkRemeber.Checked = Properties.Settings.Default.Remember;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chkRemeber_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Remember = chkRemeber.Checked;
            Properties.Settings.Default.PhoneNumber = txtNumber.Text;
            Properties.Settings.Default.Password = txtPassword.Text;
            Properties.Settings.Default.Save();
        }

        private void linkNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (RegisterForm frm = new RegisterForm())
            {
                if(frm.ShowDialog() == DialogResult.OK)
                {
                    txtNumber.Text = Properties.Settings.Default.PhoneNumber;
                    txtPassword.Text = Properties.Settings.Default.Password;
                }
            }
        }
    }
}
