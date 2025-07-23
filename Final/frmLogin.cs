using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final.Models;
using Final.Tools;
using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Final
{
    public partial class frmLogin : Form
    {
        public frmLogin()
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
            try
            {
                User? user = User.FindUser(txtUserName.Text, txtPassword.Text);
                if (user != null && user.IsDeleted == false)
                {
                    if (user.IsActive == true)
                    {
                        User.SetLogin(user);

                        string role = "";
                        switch (Role.FindRole(user.Id))
                        {
                            case -1:
                                role = "دانشجو";
                                break;
                            case 0:
                                role = "ادمین";
                                break;
                            case 1:
                                role = "مدیر";
                                break;
                            case 2:
                                role = "مسئول خوابگاه";
                                break;
                            case 3:
                                role = "مسئول بلوک";
                                break;
                            default:
                                break;
                        }
                        MessageBoxTool.msgw($"خوش آمدید\n{User.GetFullName(user)}\n: نقش شما\n{role}");
                        frmMain frm = new frmMain();
                        frm.UserID = user.Id;
                        frm.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBoxTool.msger("اکانت شما غیر فعال است");
                    }
                }
                else
                {
                    MessageBoxTool.msger("نام کاربری یا رمز عبور اشتباه است");
                }
            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.Message);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgotPassword forgotForm = new frmForgotPassword();
            forgotForm.ShowDialog();
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {

        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmSetUser registerForm = new frmSetUser();
            registerForm.ShowDialog();
        }

    }
}
