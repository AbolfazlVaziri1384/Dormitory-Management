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
    public partial class frmBlock : Form
    {
        public frmBlock()
        {
            InitializeComponent();
        }
        public long DormitoryId;
        public long UserID;
        DormitoryDbContext db;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBlocks.Rows.Count == 0)
                {
                    return;
                }
                int id;
                id = int.Parse(dgvBlocks.CurrentRow.Cells[0].Value.ToString());
                frmSetBlock frm = new frmSetBlock();
                frm.EditBlockID = id;
                frm.UserID = UserID;
                frm.ShowDialog();
                db = new DormitoryDbContext();
                RefreshBlockList(db.Blocks.ToList());
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.ToString());
            }
        }

        private void frmBlock_Load(object sender, EventArgs e)
        {
            Models.User? Owner = Models.Role.FindDormitoryOwner(DormitoryId);
            Models.Dormitory? dormitory = Models.Dormitory.FindDormitoryById(DormitoryId);
            if (Owner != null)
            {
                string name = User.GetFullName(Owner);
                this.Text = string.Format("بلوک های خوابگاه {0} با مدیریت " + "{1}", dormitory.Name, name);
            }
            else
                this.Text = string.Format("!بلوک های خوابگاه {0} بدون مدیر", dormitory.Name);

            db = new DormitoryDbContext();
            RefreshBlockList(db.Blocks.ToList());
            db.Dispose();
        }
        private void RefreshBlockList(List<Models.Block> Blocklist)
        {
            dgvBlocks.Rows.Clear();
            // اگر ادمین یا مدیر یا مسئول خوابگاه اصلی باشد
            if ((Role.FindRole(UserID) == (int)EnumTool.Role.Admin) || (Role.FindRole(UserID) == (int)EnumTool.Role.Manager) || (Role.FindRole(UserID) == (int)EnumTool.Role.DormitoryOwner))
                foreach (var item in Blocklist)
                {
                    // نمایش همه
                    if ((item.IsDeleted == false) && (item.DermitoryId == DormitoryId))
                    {
                        dgvBlocks.Rows.Add(item.Id.ToString(),
                                                item.Name,
                                                item.FloorNumber,
                                                item.RoomNumber,
                                                item.Capacity,
                                                HDateTimeTool.ToHDateTime(item.CreatOn),
                                                Block.FindBlockOwnerName(item.Id));
                    }

                }
            else
                foreach (var item in Blocklist)
                {
                    // بلوک های مربوط به این خوابگاه را می آورد

                    if ((item.CreatBy == UserID) && (item.IsDeleted == false) && (item.DermitoryId == DormitoryId))
                    {
                        dgvBlocks.Rows.Add(item.Id.ToString(),
                                                item.Name,
                                                item.FloorNumber,
                                                item.RoomNumber,
                                                item.Capacity,
                                                HDateTimeTool.ToHDateTime(item.CreatOn),
                                                Block.FindBlockOwnerName(item.Id));
                    }

                }

            if (dgvBlocks.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dgvBlocks.Rows)
                {
                    // برای زمانی که بلوکی بی مسئوله
                    if (row.Cells[6].Value.ToString() == "")
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }



        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvBlocks.Rows.Count == 0)
            {
                MessageBoxTool.msger("لیست بلوک ها خالی است");
                return;
            }
            DataTable dtBlock = new DataTable();
            dtBlock.Columns.Add("Name");
            dtBlock.Columns.Add("FloorNumber");
            dtBlock.Columns.Add("RoomNumber");
            dtBlock.Columns.Add("Capacity");
            dtBlock.Columns.Add("CreatOn");
            dtBlock.Columns.Add("Owner");
            dtBlock.Columns.Add("DormitoryName");

            Models.Dormitory? dormitory = Models.Dormitory.FindDormitoryById(DormitoryId);

            foreach (DataGridViewRow row in dgvBlocks.Rows)
            {
                dtBlock.Rows.Add(
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString(),
                    row.Cells[5].Value.ToString(),
                    row.Cells[6].Value.ToString(),
                    dormitory.Name.ToString()
                    );
            }
            stiBlockPrint.Load(Application.StartupPath + "/BlockReport.mrt");
            stiBlockPrint.RegData("DTBlock", dtBlock);
            stiBlockPrint.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSetBlock_Click(object sender, EventArgs e)
        {
            try
            {

                frmSetBlock frm = new frmSetBlock();
                frm.UserID = UserID;
                frm.DormitoryID = DormitoryId;
                frm.ShowDialog();
                db = new DormitoryDbContext();
                RefreshBlockList(db.Blocks.ToList());
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.ToString());
            }
        }

        private void btnSetRoom_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBlocks.Rows.Count == 0)
                {
                    return;
                }
                long id;
                id = int.Parse(dgvBlocks.CurrentRow.Cells[0].Value.ToString());
                frmSetRoom frm = new frmSetRoom();
                frm.UserId = UserID;
                frm.BlockId = id;
                frm.ShowDialog();
                db = new DormitoryDbContext();
                RefreshBlockList(db.Blocks.ToList());
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.ToString());
            }

        }

        private void btnShowRooms_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBlocks.Rows.Count == 0)
                {
                    return;
                }
                long id;
                id = int.Parse(dgvBlocks.CurrentRow.Cells[0].Value.ToString());
                frmRoom frm = new frmRoom();
                frm.UserID = UserID;
                frm.BlockId = id;
                frm.ShowDialog();
                db = new DormitoryDbContext();
                RefreshBlockList(db.Blocks.ToList());
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.ToString());
            }

        }

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBlocks.Rows.Count == 0)
                {
                    return;
                }
                long id;
                id = int.Parse(dgvBlocks.CurrentRow.Cells[0].Value.ToString());
                frmSetRole frm = new frmSetRole();
                frm.UserID = UserID;
                frm.Dormitory_BlockId = id;
                frm.IsDormitory = false;
                frm.ShowDialog();
                db = new DormitoryDbContext();
                RefreshBlockList(db.Blocks.ToList());
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.ToString());
            }
        }

        private void btnDeleteOwner_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBlocks.Rows.Count == 0)
                {
                    return;
                }
                int id;
                id = int.Parse(dgvBlocks.CurrentRow.Cells[0].Value.ToString());
                if (id != 0)
                {
                    DialogResult result;
                    result = MessageBoxTool.msgq("آیا از حذف مطمئن هستید ؟");
                    if (result == DialogResult.Yes)
                    {

                        Models.Role.DeleteRoleForBlock(id);
                        MessageBoxTool.msg();
                        db = new DormitoryDbContext();
                        RefreshBlockList(db.Blocks.ToList());
                        db.Dispose();
                    }
                }

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
                if (dgvBlocks.Rows.Count == 0)
                {
                    return;
                }
                int id;
                id = int.Parse(dgvBlocks.CurrentRow.Cells[0].Value.ToString());
                if (id != 0)
                {
                    DialogResult result;
                    result = MessageBoxTool.msgq("آیا از حذف مطمئن هستید ؟");
                    if (result == DialogResult.Yes)
                    {
                        Models.Block.DeleteBlock(UserID, id);
                        MessageBoxTool.msg();
                        db = new DormitoryDbContext();
                        RefreshBlockList(db.Blocks.ToList());
                        db.Dispose();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.ToString());
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                db = new DormitoryDbContext();
                RefreshBlockList((List<Models.Block>)db.Blocks.Where(i => i.Name.Contains(txtSearch.Text.Trim())).ToList());
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.ToString());
            }
        }
    }
}
