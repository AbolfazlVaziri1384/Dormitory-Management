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
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            string studentId = txtStudentId.Text.Trim();
            string nationalCode = txtNationalCode.Text.Trim();

            if (studentId == "" && nationalCode == "")
            {
                MessageBox.Show("اطلاعات تأیید شد");

                txtStudentId.Enabled = false;
                txtNationalCode.Enabled = false;
                btnVerify.Enabled = false;

                txtNewPassword.Enabled = true;
                txtConfirmPassword.Enabled = true;
                btnSubmit.Enabled = true;
            }
            else
            {
                MessageBox.Show("اطلاعات وارد شده نادرست است");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == txtConfirmPassword.Text && txtNewPassword.Text.Length >= 4)
            {
                MessageBox.Show("رمز جدید با موفقیت ثبت شد");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("رمزها با هم مطابقت ندارند");
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool show = chkShowPassword.Checked;

            txtNewPassword.UseSystemPasswordChar = !show;
            txtConfirmPassword.UseSystemPasswordChar = !show;
        }
    }
}
