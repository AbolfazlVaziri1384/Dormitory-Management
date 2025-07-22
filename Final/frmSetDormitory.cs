using Final.Models;
using Final.Tools;
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
    public partial class frmSetDormitory : Form
    {
        public frmSetDormitory()
        {
            InitializeComponent();
        }
        public int DormitoryEditId = -1;
        public long UserID;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool Istrue;
                if (DormitoryEditId == -1)
                {
                    Istrue = CheckTool.DormitorySetField(txtName.Text, txtAddress.Text, Convert.ToInt32(numCapacity.Value));
                    if (Istrue == true)
                    {
                        int Dormitorygender = 1;
                        if (radWoman.Checked == true) Dormitorygender = 0;
                        if (radFamily.Checked == true) Dormitorygender = 2;
                        Dormitory.SetDormitory(txtName.Text, txtAddress.Text, Convert.ToInt32(numCapacity.Value), UserID, Dormitorygender);
                        MessageBoxTool.msgr("خوابگاه جدید با موفقیت ثبت شد");
                        Close();
                    }
                }
                else
                {
                    Istrue = CheckTool.DormitoryEditField(txtName.Text, txtAddress.Text, Convert.ToInt32(numCapacity.Value));
                    if (Istrue == true)
                    {
                        DialogResult result;
                        result = MessageBoxTool.msgq("آیا از ویرایش مطمئن هستید؟");
                        if (result == DialogResult.Yes)
                        {
                            int Dormitorygender = 1;
                            if (radWoman.Checked == true) Dormitorygender = 0;
                            if (radFamily.Checked == true) Dormitorygender = 2;
                            Dormitory.EditDormitory(DormitoryEditId, UserID, txtName.Text, txtAddress.Text, Convert.ToInt32(numCapacity.Value), Dormitorygender);
                            MessageBoxTool.msgr("خوابگاه با موفقیت ویرایش شد");
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

        private void frmSetDormitory_Load(object sender, EventArgs e)
        {
            if (DormitoryEditId != -1)
            {
                btnSave.Text = "ویرایش";
                this.Text = "صفحه ویرایش خوابگاه";
                Dormitory? EditDormitory = Dormitory.FindDormitoryById(DormitoryEditId);
                txtName.Text = EditDormitory.Name;
                txtAddress.Text = EditDormitory.Address;
                numCapacity.Value = EditDormitory.Capacity;
                if (EditDormitory.DormitoryGender == 0) radWoman.Checked = true;
                else if (EditDormitory.DormitoryGender == 1) radMan.Checked = true;
                else if (EditDormitory.DormitoryGender == 2) radFamily.Checked = true;
            }
            else
                radMan.Checked = true;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void numCapacity_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

