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
    public partial class QuanLyNguoiDung : UserControl
    {
        Image image_add;
        Image image_update;
        Image image_cancel;
        Image image_save;
        Image image_delete;

        Image image_add_off;
        Image image_update_off;
        Image image_cancel_off;
        Image image_save_off;
        Image image_delete_off;

        DataTable dtLogin = null;
        bool Them;
        string err;
        BLLogin dbLogin = new BLLogin();
        public void ChangeLanguageToEngLish()
        {
            dgvLogin.Columns[0].HeaderText = "Account";
            dgvLogin.Columns[1].HeaderText = "Password";
            dgvLogin.Columns[2].HeaderText =  "Email";
            dgvLogin.Columns[3].HeaderText = "Phone";
            dgvLogin.Columns[4].HeaderText = "Permission";

            dgvLogin.AutoResizeColumns();

            lblUsers.Text = "USERS MANAGEMENT";

           
            lblpassword.Text = "Password:";
            lblQuyen.Text = "Permission:";
            lblTaiKhoan.Text = "Account:";


            grbDanhSach.Text = "List";
            grbTTCT.Text = "Detail";

            lblLuu.Text = "Save";
            lblSua.Text = "Edit";
            lblThem.Text = "  Add";
            lblXoa.Text = "Delete";
            lblHuyBo.Text = "Cancel";


        }
        public void ChangeLanguageToVietNamese()
        {
            dgvLogin.Columns[0].Width = 200;
            dgvLogin.Columns[1].Width = 200;
            dgvLogin.Columns[2].Width = 200;
            dgvLogin.Columns[3].Width = 200;

            dgvLogin.Columns[0].HeaderText = "TenDangNhap";
            dgvLogin.Columns[1].HeaderText = "MatKhau";
            dgvLogin.Columns[2].HeaderText = "Email";
            dgvLogin.Columns[3].HeaderText = "SoDienThoai";
            dgvLogin.Columns[4].HeaderText = "Quyển";

            dgvLogin.AutoResizeColumns();

            
            lblpassword.Text = "Mật khẩu:";
            
            lblQuyen.Text = "Quyền:";
            lblTaiKhoan.Text = "Tài khoản:";
            lblUsers.Text = "QUẢN LÝ NGƯỜI DÙNG";

            grbDanhSach.Text = "Danh sách";
            grbTTCT.Text = "Thông tin chi tiết";

            lblLuu.Text = "Lưu";
            lblSua.Text = "Sửa";
            lblThem.Text = "Thêm";
            lblXoa.Text = " Xóa";
            lblHuyBo.Text = "Hủy bỏ";

        }
        public QuanLyNguoiDung()
        {
            InitializeComponent();

            image_add = Image.FromFile(@"image/image_add.png");
            image_update = Image.FromFile(@"image/image_update.png");
            image_cancel = Image.FromFile(@"image/image_cancel.png");
            image_save = Image.FromFile(@"image/image_save.png");
            image_delete = Image.FromFile(@"image/image_delete.png");

            image_add_off = Image.FromFile(@"image/image_add_off.png");
            image_update_off = Image.FromFile(@"image/image_update_off.png");
            image_cancel_off = Image.FromFile(@"image/image_cancel_off.png");
            image_save_off = Image.FromFile(@"image/image_save_off.png");
            image_delete_off = Image.FromFile(@"image/image_delete_off.png");
        }
        public void LoadData()
        {
            try
            {
                dtLogin = new DataTable();
                dtLogin.Clear();

                DataSet ds = dbLogin.LayLogin();
                dtLogin = ds.Tables[0];

                dgvLogin.DataSource = dtLogin;
                dgvLogin.AutoResizeColumns();
               
                this.mskPhone.ResetText();
                this.txtEmail.ResetText();
                this.txtTaiKhoan.ResetText();
                this.txtMatKhau.ResetText();
                this.cboQuyen.ResetText();

                this.btnLuu.Enabled = false;
                this.btnHuyBo.Enabled = false;
                this.grbTTCT.Enabled = false;

                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;

                this.btnLuu.BackgroundImage = image_save_off;
                this.btnHuyBo.BackgroundImage = image_cancel_off;

                this.btnThem.BackgroundImage = image_add;
                this.btnSua.BackgroundImage = image_update;
                this.btnXoa.BackgroundImage = image_delete;

                this.lblLuu.ForeColor = Color.Gray;
                this.lblHuyBo.ForeColor = Color.Gray;

                this.lblThem.ForeColor = Color.SteelBlue;
                this.lblSua.ForeColor = Color.SteelBlue;
                this.lblXoa.ForeColor = Color.SteelBlue;

                dgvLogin_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table LOGIN. Lỗi rồi!!!" + err);
            }
        }

        private void QuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void UnEnable()
        {
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnHuyBo.Enabled = false;
            this.btnLuu.Enabled = false;
            this.btnXoa.Enabled = false;

            this.btnLuu.BackgroundImage = image_save_off;
            this.btnHuyBo.BackgroundImage = image_cancel_off;

            this.btnThem.BackgroundImage = image_add_off;
            this.btnSua.BackgroundImage = image_update_off;
            this.btnXoa.BackgroundImage = image_delete_off;

            this.lblLuu.ForeColor = Color.Gray;
            this.lblHuyBo.ForeColor = Color.Gray;

            this.lblThem.ForeColor = Color.Gray;
            this.lblSua.ForeColor = Color.Gray;
            this.lblXoa.ForeColor = Color.Gray;
        }
        private void dgvLogin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvLogin.CurrentCell.RowIndex;
            this.txtTaiKhoan.Text =
                dgvLogin.Rows[r].Cells[0].Value.ToString();
            this.txtMatKhau.Text =
                dgvLogin.Rows[r].Cells[1].Value.ToString();

            this.mskPhone.Text =
                dgvLogin.Rows[r].Cells[3].Value.ToString();
            this.txtEmail.Text =
                dgvLogin.Rows[r].Cells[2].Value.ToString();
            this.cboQuyen.Text =
                dgvLogin.Rows[r].Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;

            this.mskPhone.ResetText();
            this.txtEmail.ResetText();
            this.txtTaiKhoan.ResetText();
            this.txtMatKhau.ResetText();
            this.cboQuyen.ResetText();

            this.txtTaiKhoan.Enabled = true;

            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.grbTTCT.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.btnLuu.BackgroundImage = image_save;
            this.btnHuyBo.BackgroundImage = image_cancel;

            this.btnThem.BackgroundImage = image_add_off;
            this.btnSua.BackgroundImage = image_update_off;
            this.btnXoa.BackgroundImage = image_delete_off;

            this.lblLuu.ForeColor = Color.SteelBlue;
            this.lblHuyBo.ForeColor = Color.SteelBlue;

            this.lblThem.ForeColor = Color.Gray;
            this.lblSua.ForeColor = Color.Gray;
            this.lblXoa.ForeColor = Color.Gray;

            this.txtTaiKhoan.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            dgvLogin_CellClick(null, null);

            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.grbTTCT.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.btnLuu.BackgroundImage = image_save;
            this.btnHuyBo.BackgroundImage = image_cancel;

            this.btnThem.BackgroundImage = image_add_off;
            this.btnSua.BackgroundImage = image_update_off;
            this.btnXoa.BackgroundImage = image_delete_off;

            this.lblLuu.ForeColor = Color.SteelBlue;
            this.lblHuyBo.ForeColor = Color.SteelBlue;

            this.lblThem.ForeColor = Color.Gray;
            this.lblSua.ForeColor = Color.Gray;
            this.lblXoa.ForeColor = Color.Gray;

            this.txtTaiKhoan.Enabled = false;
           
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.mskPhone.ResetText();
            this.txtEmail.ResetText();
            this.txtTaiKhoan.ResetText();
            this.txtMatKhau.ResetText();
            this.cboQuyen.ResetText();

            this.btnLuu.Enabled = false;
            this.btnHuyBo.Enabled = false;
            this.grbTTCT.Enabled = false;

            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;

            this.btnLuu.BackgroundImage = image_save_off;
            this.btnHuyBo.BackgroundImage = image_cancel_off;

            this.btnThem.BackgroundImage = image_add;
            this.btnSua.BackgroundImage = image_update;
            this.btnXoa.BackgroundImage = image_delete;

            this.lblLuu.ForeColor = Color.Gray;
            this.lblHuyBo.ForeColor = Color.Gray;

            this.lblThem.ForeColor = Color.SteelBlue;
            this.lblSua.ForeColor = Color.SteelBlue;
            this.lblXoa.ForeColor = Color.SteelBlue;

            dgvLogin_CellClick(null, null);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                if (this.txtTaiKhoan.Text == "")
                {
                    epvTaiKhoan.SetError(this.txtTaiKhoan, "!");
                    MessageBox.Show("Bạn chưa nhập Tài khoản!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    epvTaiKhoan.Clear();
                    this.txtTaiKhoan.Focus();
                }
                else if (dbLogin.KiemTraTaiKhoanTonTai(this.txtTaiKhoan.Text, ref err) == true)
                {
                    epvTaiKhoan.SetError(this.txtTaiKhoan, "!");
                    MessageBox.Show("Tài khoản đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    epvTaiKhoan.Clear();
                    txtTaiKhoan.Focus();
                }
                else
                {
                    if (dbLogin.ThemLogin(this.txtTaiKhoan.Text.Trim(), this.txtMatKhau.Text.Trim(),
                           this.mskPhone.Text, this.txtEmail.Text,
                            this.cboQuyen.Text, ref err))
                    {
                        LoadData();
                        MessageBox.Show("Đã thêm xong!");
                    }
                    else
                    {
                        MessageBox.Show("Không thêm được. Lỗi rồi!!! " + err);
                    }
                }
            }
            else
            {
                if (dbLogin.CapNhatLogin(this.txtTaiKhoan.Text, this.txtMatKhau.Text.Trim(),
                        this.mskPhone.Text, this.txtEmail.Text,
                        this.cboQuyen.Text, ref err))
                {
                    LoadData();
                    MessageBox.Show("Đã sửa xong!");
                }
                else
                {
                    MessageBox.Show("Không sửa được. Lỗi rồi!!! " + err);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                if (dbLogin.XoaLogin(this.txtTaiKhoan.Text, ref err))
                {
                    LoadData();
                    MessageBox.Show("Đã xóa xong!");

                }
                else
                {
                    MessageBox.Show("Không xóa được. Lỗi rồi!!! " + err);
                }
            }
            else
            {
                MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
            }
        }
    }
}
