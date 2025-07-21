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
    public partial class frmSetTransferRoomAssetHistory : Form
    {
        public frmSetTransferRoomAssetHistory()
        {
            InitializeComponent();
        }
        public long UserID;
        public long RoomAssetID;
        public long EditTransferRoomAssetID = -1;
        DormitoryDbContext db;
    }
}
