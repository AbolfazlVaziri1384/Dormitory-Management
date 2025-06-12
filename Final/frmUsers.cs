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
using Microsoft.VisualBasic.ApplicationServices;

namespace Final
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }
        public long UserID;
        DormitoryDbContext db = new DormitoryDbContext();
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                frmSetUser frm = new frmSetUser();
                frm.ShowDialog();
                RefreshUsersList(db.Users.ToList());
            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.ToString());
            }
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            RefreshUsersList(db.Users.ToList());
        }

        
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RefreshUsersList((List<Models.User>)db.Users.Where(i => i.FirstName.Contains(txtSearch.Text.Trim()) ||
                                                   i.LastName.Contains(txtSearch.Text.Trim()) ||
                                                   i.StuPerCode.ToString().Contains(txtSearch.Text.Trim()) ||
                                                   i.NationalCode.ToString().Contains(txtSearch.Text.Trim())).ToList());
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
                if (dgvUsers.Rows.Count == 0)
                {
                    return;
                }
                int id;
                id = int.Parse(dgvUsers.CurrentRow.Cells[0].Value.ToString());
                frmSetUser frm = new frmSetUser();
                frm.UserEditId = id;
                frm.ShowDialog();
                db = new DormitoryDbContext();
                RefreshUsersList(db.Users.ToList());
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
                if (dgvUsers.Rows.Count == 0)
                {
                    return;
                }
                int id;
                id = int.Parse(dgvUsers.CurrentRow.Cells[0].Value.ToString());
                if (id != 0)
                {
                    DialogResult result;
                    result = MessageBoxTool.msgq("آیا از حذف مطمئن هستید ؟");
                    if (result == DialogResult.Yes)
                    {
                        Models.User.DeleteUser(id, UserID);
                        MessageBoxTool.msg();
                        db = new DormitoryDbContext();
                        RefreshUsersList(db.Users.ToList());
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.ToString());
            }
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvUsers.Rows.Count == 0)
                {
                    return;
                }
                int id;
                id = int.Parse(dgvUsers.CurrentRow.Cells[0].Value.ToString());
                if (id != 0)
                {
                    DialogResult result;
                    result = MessageBoxTool.msgq("آیا از تغییر وضعیت مطمئن هستید ؟");
                    if (result == DialogResult.Yes)
                    {
                        Models.User.ChangeActiveUser(id);
                        MessageBoxTool.msg();

                        //برای اینکه بعد از هر تغیر اطلاعات را از کش نخواند 
                        db = new DormitoryDbContext();

                        RefreshUsersList(db.Users.ToList());
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBoxTool.msger(ex.ToString());
            }

        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            /*
             go to frmMaim
             */
        }
        private void RefreshUsersList(List<Models.User> Userslist)
        {
            dgvUsers.Rows.Clear();
            List<Models.User> Lst = new List<Models.User>();
            foreach (var item in Userslist)
            {
                // فردی که ادمین است را نشان نمی دهد
                if ((Models.Role.FindRole(item.Id) != 0) || (Models.Role.FindRole(item.Id) == null))
                    if ((item.Id != UserID) && (item.IsDeleted == false))
                    {
                        dgvUsers.Rows.Add(item.Id.ToString(),
                                          item.FirstName,
                                          item.LastName,
                                         (item.Gender == 0) ? "خانم" : "آقا",
                                          item.Birthday,
                                          item.StuPerCode,
                                          item.NationalCode,
                                          item.Phone,
                                         (item.IsActive == true) ? "فعال" : "غیر فعال",
                                          item.Address);
                    }

            }

            if (dgvUsers.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dgvUsers.Rows)
                {
                    // برای زمانی که اگر کسی غیر فعال است قر مز بشه
                    if (row.Cells[8].Value.ToString() == "غیر فعال")
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }



        }

    }
}
