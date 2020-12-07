using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom11_DoAnQuanLySinhVien.BS_Layer;

namespace Nhom11_DoAnQuanLySinhVien.FormControl
{
    public partial class DoiMatKhau : UserControl
    {
        string account;
        string err;

        BLDoiMatKhau DbDMK=new BLDoiMatKhau();
        public DoiMatKhau(string account)
        {
            InitializeComponent();
            this.account = account;
        }

        public void ChangeLanguageToEnglish()
        {
            lblTenTaiKhoan.Text = "Account:";
            lblMKC.Text = "Current password:";
            lblMKM.Text = "New password:";
            lblTTTK.Text = "ACCOUNT INFORMATION";
            lblNLMK.Text = "Re-type new password:";
            grbThongTin.Text = "Information";
        }
        public void ChangeLanguageToVietnamese()
        {
            lblTenTaiKhoan.Text = "Tên tài khoản:";
            lblMKC.Text = "Mật khẩu hiện tại:";
            lblMKM.Text = "Mật khẩu mới:";
            lblTTTK.Text = "THÔNG TIN TÀI KHOẢN";
            lblNLMK.Text = "Nhập lại mật khẩu:";
            grbThongTin.Text = "Thông tin";
        }
        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            this.txtTaiKhoan.Text = account;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            BLDoiMatKhau BLDMK = new BLDoiMatKhau();
            errorProvider.Clear();
            if (txtTaiKhoan.Text == "")
                errorProvider.SetError(txtTaiKhoan, "Chưa nhập tên tài khoản !");
            else if (txtMKc.Text == "")
            {
                errorProvider.SetError(txtMKc, "!");
                txtMKc.Focus();
            }
            else if (txtMKmoi.Text == "")
            {
                errorProvider.SetError(txtMKmoi, "!");
                txtMKmoi.Focus();
            }
            else if (txtConfimMk.Text == "")
            {
                errorProvider.SetError(txtConfimMk, "!");
                txtConfimMk.Focus();
            }
            else if (txtConfimMk.Text != txtMKmoi.Text)
                MessageBox.Show("Mật khẩu mơKhông trùng khớp!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (BLDMK.kiemTraThongTinTaiKhoan(txtTaiKhoan.Text, txtMKc.Text, ref err))
            {
                if (BLDMK.Update(txtTaiKhoan.Text, txtMKmoi.Text, ref err))
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo!");
                else
                    MessageBox.Show("Không đổi được. Lỗi rồi!!! " + err);
            }
            else
            {
                MessageBox.Show("Mật khẩu hiện tại không chính xác!", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus();
            }
            this.txtMKc.ResetText();
            this.txtMKmoi.ResetText();
            this.txtConfimMk.ResetText();
        }
    }
}
