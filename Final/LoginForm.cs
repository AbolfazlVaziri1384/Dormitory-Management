using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.BackColor = ColorTranslator.FromHtml("#ECF0F1");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordForm forgotForm = new ForgotPasswordForm();
            var result = forgotForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("اکنون می‌توانید با رمز جدید وارد شوید", "بازگشت به ورود", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
