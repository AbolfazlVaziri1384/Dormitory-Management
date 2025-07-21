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
    public partial class frmSetRoom : Form
    {
        public frmSetRoom()
        {
            InitializeComponent();
        }
        public long UserId;
        public long BlockId;
        public long EditRoomId = -1;

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool Istrue = CheckTool.RoomField( (int)numFloorNumber.Value, (int)numNumber.Value, (int)numCapacity.Value);
                if (EditRoomId == -1)
                {
                    if (Istrue == true)
                    {
                        Room.SetRoom((int)numFloorNumber.Value, (int)numNumber.Value, (int)numCapacity.Value, BlockId, UserId);
                        MessageBoxTool.msgr("اتاق جدید با موفقیت ثبت شد");
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
                            Room.EditRoom( (int)numFloorNumber.Value, (int)numNumber.Value, (int)numCapacity.Value, UserId, EditRoomId);
                            MessageBoxTool.msgr("اتاق با موفقیت ویرایش شد");
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
