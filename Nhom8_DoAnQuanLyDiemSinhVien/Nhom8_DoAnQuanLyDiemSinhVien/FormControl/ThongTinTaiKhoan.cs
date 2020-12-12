using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Nhom11_DoAnQuanLySinhVien.BS_Layer;

namespace Nhom11_DoAnQuanLySinhVien.FormControl
{
    public partial class ThongTinTaiKhoan : UserControl
    {
        public string TenDN;
        BLThongTinTaiKhoan dbThongTinTaiKhoan = new BLThongTinTaiKhoan();
        DoiMatKhau DMK;
        public ThongTinTaiKhoan(string account, DoiMatKhau DoiMatKhau)
        {
            InitializeComponent();
            TenDN = account;
            DMK = DoiMatKhau;
        }
        public void ChangeLanguageToEngLish()
        {
            lblAcount.Text = "ACCOUNT INFORMATION";
            lblAccountID.Text = "Account:";

            
            lblQuyen.Text = "Permission:";
            lblDoiMatKhau.Text = "Change password";



        }
        public void ChangeLanguageToVietNamese()
        {

            lblAcount.Text = "THÔNG TIN TÀI KHOẢN";
            lblAccountID.Text = "Mã số tài khoản:";

            lblQuyen.Text = "Quyền:";
            lblDoiMatKhau.Text = "Đổi mật khẩu";

        }
        private void ThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            DataTable dt;
            DataSet ds = dbThongTinTaiKhoan.LayThongTinTaiKhoan(TenDN);
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                this.txtMaTK.Text = row["TenDangNhap"].ToString();
                //this.txtHoTen.Text = row["MatKhau"].ToString();
                this.txtEmail.Text = row["Email"].ToString();
                this.txtPhone.Text = row["SoDienThoai"].ToString();
                
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.DMK.Visible = true;
            this.DMK.BringToFront();
        }

        private void lblDoiMatKhau_Click(object sender, EventArgs e)
        {
            btnDoiMatKhau_Click(null, null);
        }
    }
}
