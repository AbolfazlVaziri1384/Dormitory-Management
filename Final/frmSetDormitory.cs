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
        public long UserId;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool Istrue = CheckTool.DormitoryField(txtName.Text,txtAddress.Text,Convert.ToInt32(numCapacity.Value));
                if (DormitoryEditId == -1)
                {
                    if (Istrue == true)
                    {
                        Dormitory.SetDormitory(txtName.Text, txtAddress.Text, Convert.ToInt32(numCapacity.Value),UserId);
                        MessageBoxTool.msgr("کاربر جدید با موفقیت ثبت شد");
                        Close();
                    }
                    else
                    {
                        if (Istrue == true)
                        {
                            DialogResult result;
                            result = MessageBoxTool.msgq("آیا از ویرایش مطمئن هستید؟");
                            if (result == DialogResult.Yes)
                            {
                                Dormitory.EditDormitory(DormitoryEditId,UserId,txtName.Text,txtAddress.Text,Convert.ToInt32(numCapacity.Value));
                                MessageBoxTool.msgr("کابر با موفقیت ویرایش شد");
                                Close();
                            }
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
                frmSetDormitory frm = new frmSetDormitory();
                frm.Text = "صفحه ویرایش خوابگاه";
                Dormitory? EditDormitory = Dormitory.FindDormitoryById(DormitoryEditId);
                txtName.Text = EditDormitory.Name;
                txtAddress.Text = EditDormitory.Address;
                numCapacity.Value = EditDormitory.Capacity;

            }
        }
    }
}

