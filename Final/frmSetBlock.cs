using Final.Models;
using Final.Tools;
using Microsoft.QualityTools.Testing.Fakes.Stubs;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmSetBlock : Form
    {
        public frmSetBlock()
        {
            InitializeComponent();
        }
        public long UserID;
        public long DormitoryID;
        public long EditBlockID = -1;

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool Istrue;
                if (EditBlockID == -1)
                {
                    Istrue = CheckTool.BlockSetField(txtName.Text, (int)numFloorNumber.Value, (int)numeRoomNumber.Value, (int)numCapacity.Value);
                    if (Istrue == true)
                    {
                        Block.SetBlock(txtName.Text, (int)numFloorNumber.Value, (int)numeRoomNumber.Value, (int)numCapacity.Value, DormitoryID, UserID);
                        MessageBoxTool.msgr("بلوک جدید با موفقیت ثبت شد");
                        Close();
                    }
                }
                else
                {
                    Istrue = CheckTool.BlockEditField(txtName.Text, (int)numFloorNumber.Value, (int)numeRoomNumber.Value, (int)numCapacity.Value);
                    if (Istrue == true)
                    {
                        DialogResult result;
                        result = MessageBoxTool.msgq("آیا از ویرایش مطمئن هستید؟");
                        if (result == DialogResult.Yes)
                        {
                            Block.EditBlock(txtName.Text, (int)numFloorNumber.Value, (int)numeRoomNumber.Value, (int)numCapacity.Value, UserID, EditBlockID);
                            MessageBoxTool.msgr("بلوک با موفقیت ویرایش شد");
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

        private void frmSetBlock_Load(object sender, EventArgs e)
        {
            if (EditBlockID != -1)
            {
                btnSave.Text = "ویرایش";
                this.Text = "صفحه ویرایش";
                Block? EditBlock = Block.FindBlockById(EditBlockID);
                txtName.Text = EditBlock.Name;
                numFloorNumber.Value = EditBlock.FloorNumber;
                numCapacity.Value = EditBlock.Capacity;
                numeRoomNumber.Value = EditBlock.RoomNumber;
            }
        }
    }
}
    

