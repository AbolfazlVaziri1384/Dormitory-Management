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
    public partial class frmSetRoomAssignment : Form
    {
        public frmSetRoomAssignment()
        {
            InitializeComponent();
        }
        DormitoryDbContext db;
        public long UserID;
        public long RoomId;
        public long RoomAssigmentEditId = -1;
        private void frmSetRoomAssignment_Load(object sender, EventArgs e)
        {
            if (RoomAssigmentEditId != -1)
            {
                btnSave.Text = "ویرایش";
                this.Text = "ویرایش تخصیص اتاق";
            }
            db = new DormitoryDbContext();
            RefreshStudentsList(db.Users.ToList());
            db.Dispose();
        }
        private void RefreshStudentsList(List<Models.User> Userslist)
        {
            dgvStudents.Rows.Clear();
            foreach (var item in Userslist)
            {
                //نباید مسئول خاصی باشه
                //ادمین - مدیر - مسئول خوابگاه
                if ((Models.Role.FindRole(item.Id) != (int)EnumTool.Role.Admin) && (Models.Role.FindRole(item.Id) != (int)EnumTool.Role.Manager) && (Models.Role.FindRole(item.Id) != (int)EnumTool.Role.DormitoryOwner))
                    //نباید قبلا بهش اتاقی داده باشیم
                    if ((!RoomAssigment.AnyRoomAssigment(item.Id)) && (item.IsDeleted == false))
                        //باید جنسیت با خوابگاه یکی باشه
                        if ((Dormitory.FindDormitoryType(RoomId) == item.Gender) || (Dormitory.FindDormitoryType(RoomId) == 2))
                        {
                            dgvStudents.Rows.Add(item.Id.ToString(),
                                              item.FirstName,
                                              item.LastName,
                                             (item.Gender == 0) ? "خانم" : "آقا",
                                              item.StuPerCode,
                                              item.NationalCode
                                              );
                        }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text == null) return;

                db = new DormitoryDbContext();
                RefreshStudentsList((List<Models.User>)db.Users.Where(i => i.FirstName.Contains(txtSearch.Text.Trim()) ||
                                                   i.LastName.Contains(txtSearch.Text.Trim()) ||
                                                   i.StuPerCode.ToString().Contains(txtSearch.Text.Trim()) ||
                                                   i.NationalCode.ToString().Contains(txtSearch.Text.Trim())).ToList());
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStudents.Rows.Count == 0)
                {
                    return;
                }
                long id;
                id = int.Parse(dgvStudents.CurrentRow.Cells[0].Value.ToString());
                if (RoomAssigmentEditId == -1)
                {
                    RoomAssigment.SetRoomAssigment(id, RoomId, UserID);
                    MessageBoxTool.msgr("تخصیص اتاق با موفقیت انجام شد");
                    Close();
                }
                else
                {
                    DialogResult result;
                    result = MessageBoxTool.msgq("آیا از ویرایش مطمئن هستید؟");
                    if (result == DialogResult.Yes)
                    {
                        RoomAssigment.EditRoomAssigment(RoomAssigmentEditId, UserID, id);
                        MessageBoxTool.msgr("تخصیص اتاق با موفقیت ویرایش شد");
                        Close();
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
