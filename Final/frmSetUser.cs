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

namespace Final
{
    public partial class frmSetUser : Form
    {
        public frmSetUser()
        {
            InitializeComponent();
        }
        public int UserEditId = -1;
        public long UserId = -1;
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool show = chkShowPassword.Checked;

            txtPassword.UseSystemPasswordChar = !show;
            txtConfirmPassword.UseSystemPasswordChar = !show;
        }

        private void frmSetUser_Load(object sender, EventArgs e)
        {

            if (UserEditId != -1)
            {
                btnSave.Text = "ویرایش";
                frmSetUser frm = new frmSetUser();
                frm.Text = "صفحه ویرایش";
                User? EditUser = User.FindUserById(UserEditId);
                txtFirstName.Text = EditUser.FirstName;
                txtLastName.Text = EditUser.LastName;
                txtUserName.Text = EditUser.UserName;
                txtPassword.Text = EditUser.Password;
                txtConfirmPassword.Text = EditUser.Password;
                txtAddress.Text = EditUser.Address;
                numNationalCode.Value = EditUser.NationalCode;
                numStu_Per_Code.Value = EditUser.StuPerCode;
                numPhone.Value = EditUser.Phone;
                mskBirthDay.Text = EditUser.Birthday;
                if (EditUser.Gender == 0) radWoman.Checked = true;
                else radMen.Checked = true;
            }
            else
            {
                radMen.Checked = true;
            }

            bool show = chkShowPassword.Checked;
            txtPassword.UseSystemPasswordChar = !show;
            txtConfirmPassword.UseSystemPasswordChar = !show;
            // اگر فردی بخواهد تازه ثبت نام کند یا کسی بخواهد تغییری ایجاد کند
            if (UserId != -1)
            {
                grpLoginInfo.Enabled = false;
                txtUserName.UseSystemPasswordChar = !show;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void grpLoginInfo_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool Istrue = CheckTool.UserField(txtFirstName.Text, txtLastName.Text, txtUserName.Text, txtPassword.Text, txtConfirmPassword.Text, txtAddress.Text, Convert.ToInt64(numNationalCode.Value), Convert.ToInt64(numStu_Per_Code.Value), Convert.ToInt64(numPhone.Value), mskBirthDay.Text.ToString());
                if (UserEditId == -1)
                {
                    if (Istrue == true)
                    {
                        User.SetUser(txtFirstName.Text, txtLastName.Text, txtUserName.Text, txtPassword.Text, txtAddress.Text, Convert.ToInt64(numNationalCode.Value), Convert.ToInt64(numStu_Per_Code.Value), Convert.ToInt64(numPhone.Value), mskBirthDay.Text.ToString(), radMen.Checked);
                        MessageBoxTool.msgr("کاربر جدید با موفقیت ثبت شد");
                        Close();
                    }
                }
                else
                {
                    if (Istrue == true)
                    {
                        DialogResult result;
                        result = MessageBoxTool.msgq("آیا از ویرایش مطمئن هستید؟");
                        if (result == DialogResult.Yes)
                        {
                            User.EditUser(UserEditId, UserId, txtFirstName.Text, txtLastName.Text, txtUserName.Text, txtPassword.Text, txtAddress.Text, Convert.ToInt64(numNationalCode.Value), Convert.ToInt64(numStu_Per_Code.Value), Convert.ToInt64(numPhone.Value), mskBirthDay.Text.ToString(), radMen.Checked);
                            MessageBoxTool.msgr("کابر با موفقیت ویرایش شد");
                            Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.Message);
            }
        }
    }
}
