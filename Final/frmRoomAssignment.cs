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
    public partial class frmRoomAssignment : Form
    {
        public frmRoomAssignment()
        {
            InitializeComponent();
        }
        public long UserID;
        public long RoomId;
        DormitoryDbContext db;
        private void frmRoomAssignment_Load(object sender, EventArgs e)
        {
            frmRoomAssignment frmRoomAssigment = new frmRoomAssignment();

            Models.Room? room = Models.Room.FindRoomById(RoomId);
            Models.Block? block = Models.Block.FindBlockById(room.BlockId);
            Models.Dormitory? dormitory = Models.Dormitory.FindDormitoryById(block.DermitoryId);
            frmRoomAssigment.Text = string.Format("{1} افراد اتاق شماره {0} در طبقه", room.Number, room.FloorNumber);
            lblBlock.Text = block.Name;
            lblDormitory.Text = dormitory.Name;

            Models.User? BlockOwner = Models.Role.FindBlockOwner(room.BlockId);
            Models.User? DormitoryOwner = Models.Role.FindBlockOwner(Models.Block.FindBlockById(room.BlockId).DermitoryId);

            if (BlockOwner != null)
            {
                string name = User.GetFullName(BlockOwner);
                lblBlockOwner.Text = name;
            }
            else lblBlockOwner.Text = "-";

            if (DormitoryOwner != null)
            {
                string name = User.GetFullName(DormitoryOwner);
                lblDormitoryOwner.Text = name;
            }
            else lblDormitoryOwner.Text = "-";

            db = new DormitoryDbContext();
            RefreshRoomAssigmentList(db.RoomAssigments.ToList());
            db.Dispose();
        }
        private void RefreshRoomAssigmentList(List<Models.RoomAssigment> RoomAssigmentlist)
        {
            dgvStudents.Rows.Clear();

            foreach (var item in RoomAssigmentlist)
            {
                // افراد داخل اتاق رامیاره

                if ((item.RoomId == RoomId) && (item.IsDeleted == false))
                {
                    Models.User user = User.FindUserById(item.Id);
                    string name = User.GetFullName(user);

                    dgvStudents.Rows.Add(item.Id.ToString(),
                                            name,
                                            user.StuPerCode,
                                            user.NationalCode,
                                            HDateTimeTool.ToHDateTime(item.CreatOn));
                }

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dtRoomAssigment = new DataTable();
            dtRoomAssigment.Columns.Add("Name");
            dtRoomAssigment.Columns.Add("StuPerStudent");
            dtRoomAssigment.Columns.Add("NationalCode");
            dtRoomAssigment.Columns.Add("CreatOn");

            dtRoomAssigment.Columns.Add("Dormitory");
            dtRoomAssigment.Columns.Add("Block");
            dtRoomAssigment.Columns.Add("DormitoryOwner");
            dtRoomAssigment.Columns.Add("BlockOwner");

            dtRoomAssigment.Columns.Add("Number");
            dtRoomAssigment.Columns.Add("FloorNumber");

            Models.Room? room = Models.Room.FindRoomById(RoomId);

            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                dtRoomAssigment.Rows.Add(
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString(),
                    lblDormitory.Text,
                    lblBlock.Text,
                    lblDormitoryOwner.Text,
                    lblBlockOwner.Text,
                    room.Number,
                    room.FloorNumber
                    );
            }
            stiRoomAssigmentPrint.Load(Application.StartupPath + "/RoomAssigmentReport.mrt");
            stiRoomAssigmentPrint.RegData("DTRoomAssigment", dtRoomAssigment);
            stiRoomAssigmentPrint.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStudents.Rows.Count == 0)
                {
                    return;
                }
                int id;
                id = int.Parse(dgvStudents.CurrentRow.Cells[0].Value.ToString());
                if (id != 0)
                {
                    DialogResult result;
                    result = MessageBoxTool.msgq("آیا از حذف مطمئن هستید ؟");
                    if (result == DialogResult.Yes)
                    {
                        Models.Block.DeleteBlock(UserID, id);
                        MessageBoxTool.msg();
                        db = new DormitoryDbContext();
                        RefreshRoomAssigmentList(db.RoomAssigments.ToList());
                        db.Dispose();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.ToString());
            }

        }

        private void btnSetRoomAssignment_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStudents.Rows.Count == 0)
                {
                    return;
                }
                long id;
                id = int.Parse(dgvStudents.CurrentRow.Cells[0].Value.ToString());
                frmSetRoomAssignment frm = new frmSetRoomAssignment();
                frm.UserID = UserID;
                frm.RoomId = id;
                frm.ShowDialog();
                db = new DormitoryDbContext();
                RefreshRoomAssigmentList(db.RoomAssigments.ToList());
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.ToString());
            }
        }
    }
}
