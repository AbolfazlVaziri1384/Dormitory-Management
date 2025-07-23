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
    public partial class frmBlockOwners : Form
    {
        public frmBlockOwners()
        {
            InitializeComponent();
        }
        public long UserID;
        DormitoryDbContext db = new DormitoryDbContext();
        private void frmBlockOwners_Load(object sender, EventArgs e)
        {
            db = new DormitoryDbContext();
            RefreshUsersList(db.Users.ToList());
            db.Dispose();
        }
        private void RefreshUsersList(List<Models.User> Userslist)
        {
            dgvUsers.Rows.Clear();
            foreach (var item in Userslist)
            {
                //فقط نمایش مسئولات بلوک
                if (Role.FindRole(item.Id) == (int)EnumTool.Role.BlockOwner)
                    if ((item.Id != UserID) && (item.IsDeleted == false))
                    {
                        dgvUsers.Rows.Add(item.Id.ToString(),
                                          item.FirstName,
                                          item.LastName,
                                         (item.Gender == 0) ? "خانم" : "آقا",
                                          item.Birthday,
                                          item.StuPerCode,
                                          item.NationalCode,
                                          $"0{item.Phone}",
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

                        Models.Role.DeleteManagerRole(id);
                        MessageBoxTool.msg();
                        db = new DormitoryDbContext();
                        RefreshUsersList(db.Users.ToList());
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
