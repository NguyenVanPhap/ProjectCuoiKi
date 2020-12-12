using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using Nhom11_DoAnQuanLySinhVien.BS_Layer;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Nhom11_DoAnQuanLySinhVien
{
    public partial class frmDangNhap : Form
    {
        BLDangNhap dbDangNhap = new BLDangNhap();
        
        string QuyenTruyCap = "";
        string err;

        //di chuyển form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        //

        public frmDangNhap()
        {
            InitializeComponent();
            cbbServer.Items.Clear();
            cbbServer.Items.Add(System.Windows.Forms.SystemInformation.ComputerName);
            cbbServer.Text = System.Windows.Forms.SystemInformation.ComputerName;
            rdoSV.Checked = true;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                BLDangNhap BLDN = new BLDangNhap();
                bool KT=BLDN.kiemTraThongTinDangNhap(this.txtTenDN.Text, this.txtPassword.Text, ref err,QuyenTruyCap);
                if(KT)
                {
                    MessageBox.Show("Đăng nhập thành công vào hệ thống!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    FrMain frm = new FrMain();
                    frm.Permission = QuyenTruyCap;
                    frm.account = this.txtTenDN.Text;
                    frm.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Thông tin đăng nhập không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi rồi!");
            }

        }

        private void rdoSV_CheckedChanged(object sender, EventArgs e)
        {
            QuyenTruyCap = "sinhvien";
        }

        private void rdoGiangVien_CheckedChanged(object sender, EventArgs e)
        {
            QuyenTruyCap = "giangvien";
        }

        private void rdoNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            QuyenTruyCap = "admin";
        }

        private void pnlTittle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
