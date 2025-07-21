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
    public partial class frmRoom : Form
    {
        public frmRoom()
        {
            InitializeComponent();
        }
        public long BlockId;
        public long UserID;
        DormitoryDbContext db;

        private void dgvRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmRoom_Load(object sender, EventArgs e)
        {
            Models.User? Owner = Models.Role.FindBlockOwner(BlockId);
            Models.Block? block = Models.Block.FindBlockById(BlockId);
            Models.Dormitory? dormitory = Models.Dormitory.FindDormitoryById(block.DermitoryId);
            frmRoom frmRoom = new frmRoom();
            if (Owner != null)
            {
                string name = User.GetFullName(Owner);
                frmRoom.Text = string.Format("{اتاق های بلوک {0} از خوابگاه {1} با مدیریت {2", block.Name, dormitory.Name, name);
            }
            else
                frmRoom.Text = string.Format("!اتاق های بلوک {0} از خوابگاه {1} بدون مدیر", block.Name, dormitory.Name);
            db = new DormitoryDbContext();
            RefreshRoomList(db.Rooms.ToList());
            db.Dispose();
        }
        private void RefreshRoomList(List<Models.Room> Roomlist)
        {
            dgvRooms.Rows.Clear();

            foreach (var item in Roomlist)
            {
                // اتاق های ان بلوک را میاره

                if ((item.BlockId == BlockId) && (item.IsDeleted == false))
                {
                    dgvRooms.Rows.Add(item.Id.ToString(),
                                            item.Number,
                                            item.FloorNumber,
                                            item.Capacity,
                                            Room.StudentCount(item.Id),
                                            HDateTimeTool.ToHDateTime(item.CreatOn));
                }

            }

            if (dgvRooms.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dgvRooms.Rows)
                {
                    // برای زمانی که اتاقی پره
                    if (row.Cells[3].Value == row.Cells[4].Value)
                    {
                        row.DefaultCellStyle.BackColor = Color.Aqua;
                    }
                }
            }



        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvRooms.Rows.Count == 0)
            {
                MessageBoxTool.msger("لیست اتاق ها خالی است");
                return;
            }
            DataTable dtRoom = new DataTable();
            dtRoom.Columns.Add("Number");
            dtRoom.Columns.Add("FloorNumber");
            dtRoom.Columns.Add("Capacity");
            dtRoom.Columns.Add("StudentCount");
            dtRoom.Columns.Add("CreatOn");
            dtRoom.Columns.Add("BlockName");
            dtRoom.Columns.Add("DormitoryName");

            Models.Block? block = Models.Block.FindBlockById(BlockId);
            Models.Dormitory? dormitory = Models.Dormitory.FindDormitoryById(block.DermitoryId);

            foreach (DataGridViewRow row in dgvRooms.Rows)
            {
                dtRoom.Rows.Add(
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString(),
                    row.Cells[5].Value.ToString(),
                    block.Name.ToString(),
                    dormitory.Name.ToString()
                    );
            }
            stiRoomPrint.Load(Application.StartupPath + "/RoomReport.mrt");
            stiRoomPrint.RegData("DTRoom", dtRoom);
            stiRoomPrint.Show();
        }

        private void btnSetRoom_Click(object sender, EventArgs e)
        {
            try
            {

                frmSetRoom frm = new frmSetRoom();
                frm.UserId = UserID;
                frm.BlockId = BlockId;
                frm.ShowDialog();
                db = new DormitoryDbContext();
                RefreshRoomList(db.Rooms.ToList());
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.ToString());
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRooms.Rows.Count == 0)
                {
                    return;
                }
                int id;
                id = int.Parse(dgvRooms.CurrentRow.Cells[0].Value.ToString());
                frmSetRoom frm = new frmSetRoom();
                frm.EditRoomId = id;
                frm.UserId = UserID;
                frm.ShowDialog();
                db = new DormitoryDbContext();
                RefreshRoomList(db.Rooms.ToList());
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.ToString());
            }

        }

        private void btnSetRoomAssegment_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRooms.Rows.Count == 0)
                {
                    return;
                }
                long id;
                id = int.Parse(dgvRooms.CurrentRow.Cells[0].Value.ToString());
                frmSetRoomAssignment frm = new frmSetRoomAssignment();
                frm.UserID = UserID;
                frm.RoomId = id;
                frm.ShowDialog();
                db = new DormitoryDbContext();
                RefreshRoomList(db.Rooms.ToList());
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRooms.Rows.Count == 0)
                {
                    return;
                }
                int id;
                id = int.Parse(dgvRooms.CurrentRow.Cells[0].Value.ToString());
                if (id != 0)
                {
                    DialogResult result;
                    result = MessageBoxTool.msgq("آیا از حذف مطمئن هستید ؟");
                    if (result == DialogResult.Yes)
                    {
                        Models.Block.DeleteBlock(UserID, id);
                        MessageBoxTool.msg();
                        db = new DormitoryDbContext();
                        RefreshRoomList(db.Rooms.ToList());
                        db.Dispose();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.ToString());
            }
        }

        private void btnShowRoomAssegment_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRooms.Rows.Count == 0)
                {
                    return;
                }
                long id;
                id = int.Parse(dgvRooms.CurrentRow.Cells[0].Value.ToString());
                frmRoomAssignment frm = new frmRoomAssignment();
                frm.UserID = UserID;
                frm.RoomId = id;
                frm.ShowDialog();
                db = new DormitoryDbContext();
                RefreshRoomList(db.Rooms.ToList());
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.ToString());
            }
        }
    }
}
