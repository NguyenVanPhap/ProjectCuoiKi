using Nhom11_DoAnQuanLySinhVien.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom11_DoAnQuanLySinhVien
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }
        BLTinhHinhHocTap bLTinhHinhHocTap = new BLTinhHinhHocTap();

        private void btnLayKhoa_Test_Click(object sender, EventArgs e)
        {
            MessageBox.Show(bLTinhHinhHocTap.LayKhoa().Count.ToString()); 
            
        }
    }
}
