using System;
using System.Collections.Generic;
using System.Collections;
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
    public partial class frmDormitory : Form
    {
        public frmDormitory()
        {
            InitializeComponent();
        }
        DormitoryDbContext db = new DormitoryDbContext();
        public long UserID;
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                db = new DormitoryDbContext();
                RefreshDormitoryList((List<Models.Dormitory>)db.Dormitories.Where(i => i.Name.Contains(txtSearch.Text.Trim())).ToList());
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.ToString());
            }
        }

        private void frmDormitory_Load(object sender, EventArgs e)
        {
            db = new DormitoryDbContext();
            RefreshDormitoryList(db.Dormitories.ToList());
            db.Dispose();
        }
        private void RefreshDormitoryList(List<Models.Dormitory> Dormitorylist)
        {
            dgvDormitory.Rows.Clear();
            // اگر ادمین یا مدیر اصلی باشد
            if ((Role.FindRole(UserID) == 0) || (Role.FindRole(UserID) == 1))
                foreach (var item in Dormitorylist)
                {
                    // نمایش همه
                    if (item.IsDeleted == false)
                    {
                        dgvDormitory.Rows.Add(item.Id.ToString(),
                                                item.Name,
                                                item.Capacity,
                                                item.NowCapacity,
                                                Dormitory.FindDormitoryOwnerName(item.Id),
                                                (item.DormitoryGender == 0) ? "خواهران" : (item.DormitoryGender == 1) ? "برادران" : "متاهلی",
                                                item.Address);
                    }

                }
            else
                foreach (var item in Dormitorylist)
                {
                    // خوابگاه های ثبت شده توسط فرد را نمایش می دهد

                    if ((item.CreatBy == UserID) && (item.IsDeleted == false))
                    {
                        dgvDormitory.Rows.Add(item.Id.ToString(),
                                                item.Name,
                                                item.Capacity,
                                                item.NowCapacity,
                                                Dormitory.FindDormitoryOwnerName(item.Id),
                                                (item.DormitoryGender == 0) ? "خواهران" : (item.DormitoryGender == 1) ? "برادران" : "متاهلی",
                                                item.Address);
                    }

                }

            if (dgvDormitory.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dgvDormitory.Rows)
                {
                    // برای زمانی که خوابگاهی بی مسئوله
                    if (row.Cells[4].Value.ToString() == "")
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }



        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvDormitory.Rows.Count == 0)
            {
                MessageBoxTool.msger("لیست خوابگاه ها خالی است");
                return;
            }
            DataTable dtDormitory = new DataTable();
            dtDormitory.Columns.Add("Name");
            dtDormitory.Columns.Add("Capacity");
            dtDormitory.Columns.Add("NowCapacity");
            dtDormitory.Columns.Add("Owner");
            dtDormitory.Columns.Add("Gender");
            dtDormitory.Columns.Add("Address");
            foreach (DataGridViewRow row in dgvDormitory.Rows)
            {
                dtDormitory.Rows.Add(
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString(),
                    row.Cells[5].Value.ToString(),
                    row.Cells[6].Value.ToString()
                    );
            }
            stiDormitoryPrint.Load(Application.StartupPath + "/DormitoryReport.mrt");
            stiDormitoryPrint.RegData("DTDormitory", dtDormitory);
            stiDormitoryPrint.Show();
        }

        private void btnStudentPrint_Click(object sender, EventArgs e)
        {
            if (dgvDormitory.Rows.Count == 0)
            {
                MessageBoxTool.msger("لیست خوابگاه ها خالی است");
                return;
            }
            long id;
            id = long.Parse(dgvDormitory.CurrentRow.Cells[0].Value.ToString());
            List<RoomAssigment> RoomAssigments = new List<RoomAssigment>();
            RoomAssigments = Dormitory.FindStudents(id);

            DataTable dtStudent = new DataTable();
            dtStudent.Columns.Add("StudentFirstName");
            dtStudent.Columns.Add("StudentLastName");
            dtStudent.Columns.Add("StudentCode");
            dtStudent.Columns.Add("RoomNumber");
            dtStudent.Columns.Add("RoomFloorNumber");
            dtStudent.Columns.Add("BlockName");
            dtStudent.Columns.Add("DormitoryName");
            dtStudent.Columns.Add("CreatOn");

            foreach (var row in RoomAssigments)
            {
                var user = User.FindUserById(row.Id);
                var room = Room.FindRoomById(row.Id);
                var block = Block.FindBlockById(row.Id);
                dtStudent.Rows.Add(
                    user.FirstName.ToString(),
                    user.LastName.ToString(),
                    user.StuPerCode.ToString(),
                    room.Number.ToString(),
                    room.FloorNumber.ToString(),
                    block.Name.ToString(),
                    dgvDormitory.CurrentRow.Cells[1].Value.ToString(),
                    row.CreatOn.ToString()
                    );
            }
            stiStudentPrint.Load(Application.StartupPath + "/StudentsReport.mrt");
            stiStudentPrint.RegData("DTStudents", dtStudent);
            stiStudentPrint.Show();
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSetDormitory_Click(object sender, EventArgs e)
        {
            try
            {

                frmSetDormitory frm = new frmSetDormitory();
                frm.UserID = UserID;
                frm.ShowDialog();
                db = new DormitoryDbContext();
                RefreshDormitoryList(db.Dormitories.ToList());
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.ToString());
            }
        }

        private void btnSetBlock_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDormitory.Rows.Count == 0)
                {
                    return;
                }
                long id;
                id = int.Parse(dgvDormitory.CurrentRow.Cells[0].Value.ToString());
                frmSetBlock frm = new frmSetBlock();
                frm.UserID = UserID;
                frm.DormitoryID = id;
                frm.ShowDialog();
                db = new DormitoryDbContext();
                RefreshDormitoryList(db.Dormitories.ToList());
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
                if (dgvDormitory.Rows.Count == 0)
                {
                    return;
                }
                int id;
                id = int.Parse(dgvDormitory.CurrentRow.Cells[0].Value.ToString());
                frmSetDormitory frm = new frmSetDormitory();
                frm.DormitoryEditId = id;
                frm.UserID = UserID;
                frm.ShowDialog();
                db = new DormitoryDbContext();
                RefreshDormitoryList(db.Dormitories.ToList());
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
                if (dgvDormitory.Rows.Count == 0)
                {
                    return;
                }
                int id;
                id = int.Parse(dgvDormitory.CurrentRow.Cells[0].Value.ToString());
                if (id != 0)
                {
                    DialogResult result;
                    result = MessageBoxTool.msgq("آیا از حذف مطمئن هستید ؟");
                    if (result == DialogResult.Yes)
                    {
                        Models.Dormitory.DeleteDormitory(UserID,id);
                        MessageBoxTool.msg();
                        db = new DormitoryDbContext();
                        RefreshDormitoryList(db.Dormitories.ToList());
                        db.Dispose();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.ToString());
            }
        }

        private void btnShowBlocks_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDormitory.Rows.Count == 0)
                {
                    return;
                }
                long id;
                id = int.Parse(dgvDormitory.CurrentRow.Cells[0].Value.ToString());
                frmBlock frm = new frmBlock();
                frm.UserID = UserID;
                frm.DormitoryId = id;
                frm.ShowDialog();
                db = new DormitoryDbContext();
                RefreshDormitoryList(db.Dormitories.ToList());
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
                if (dgvDormitory.Rows.Count == 0)
                {
                    return;
                }
                long id;
                id = int.Parse(dgvDormitory.CurrentRow.Cells[0].Value.ToString());
                frmSetRole frm = new frmSetRole();
                frm.UserID = UserID;
                frm.Dormitory_BlockId = id;
                frm.IsDormitory = true;
                frm.ShowDialog();
                db = new DormitoryDbContext();
                RefreshDormitoryList(db.Dormitories.ToList());
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
                if (dgvDormitory.Rows.Count == 0)
                {
                    return;
                }
                int id;
                id = int.Parse(dgvDormitory.CurrentRow.Cells[0].Value.ToString());
                if (id != 0)
                {
                    DialogResult result;
                    result = MessageBoxTool.msgq("آیا از حذف مطمئن هستید ؟");
                    if (result == DialogResult.Yes)
                    {

                        Models.Role.DeleteRole(id);
                        MessageBoxTool.msg();
                        db = new DormitoryDbContext();
                        RefreshDormitoryList(db.Dormitories.ToList());
                        db.Dispose();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.ToString());
            }

        }
    }
}
