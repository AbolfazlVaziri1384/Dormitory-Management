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
                                                (item.DormitoryGender == 0) ? "خواهران" : (item.DormitoryGender == 1) ? "برادران" : "متاهلی",
                                                item.Address);
                    }

                }

            if (dgvDormitory.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dgvDormitory.Rows)
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
