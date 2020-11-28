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
    public partial class QuanLyKhoa : UserControl
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

        DataTable dtKhoa = null;
        BLKhoa dbKhoa = new BLKhoa();
        bool Them;
        string err;

        public void ChangeLanguageToEngLish()
        {
            lblKhoa.Text = "FACULTY MANAGEMENT";
            lblMaKhoa.Text = "Faculty ID:";
            lblTenKhoa.Text = "Faculty name:";

            grbDanhSach.Text = "List";
            grbLuaChon.Text = "Selection";

            lblLuu.Text = "Save";
            lblSua.Text = "Edit";
            lblThem.Text = "  Add";
            lblXoa.Text = "Delete";
            lblHuyBo.Text = "Cancel";

            dgvKhoa.Columns[0].Width = 200;
            dgvKhoa.Columns[1].Width = 200;

            dgvKhoa.Columns[0].HeaderText = "Faculty ID";
            dgvKhoa.Columns[1].HeaderText = "Faculty Name";

            dgvKhoa.AutoResizeColumns();
        }
        public void ChangeLanguageToVietNamese()
        {
            dgvKhoa.Columns[0].HeaderText = "Mã Khoa";
            dgvKhoa.Columns[1].HeaderText = "Tên Khoa";

            lblKhoa.Text = "QUẢN LÝ KHOA";
            lblMaKhoa.Text = "Mã khoa:";
            lblTenKhoa.Text = "Tên khoa:";

            grbDanhSach.Text = "Danh sách";
            grbLuaChon.Text = "Lựa chọn";

            lblLuu.Text = "Lưu";
            lblSua.Text = "Sửa";
            lblThem.Text = "Thêm";
            lblXoa.Text = " Xóa";
            lblHuyBo.Text = "Hủy bỏ";
        }
        public QuanLyKhoa()
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
                dtKhoa = new DataTable();
                dtKhoa.Clear();
                DataSet ds = dbKhoa.LayKhoa();
                dtKhoa = ds.Tables[0];
                dgvKhoa.DataSource = dtKhoa;
                dgvKhoa.AutoResizeColumns();
                this.txtMaKhoa.ResetText();
                this.txtTenKhoa.ResetText();

                this.btnLuu.Enabled = false;
                this.btnHuyBo.Enabled = false;
                this.grbLuaChon.Enabled = false;

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

                dgvKhoa_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table KHOA. Lỗi rồi!!!" + err);
            }
        }


        private void QuanLyKhoa_Load(object sender, EventArgs e)
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
        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvKhoa.CurrentCell.RowIndex;
            this.txtMaKhoa.Text =
                dgvKhoa.Rows[r].Cells[0].Value.ToString();
            this.txtTenKhoa.Text =
                dgvKhoa.Rows[r].Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;

            this.txtMaKhoa.ResetText();
            this.txtTenKhoa.ResetText();

            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.grbLuaChon.Enabled = true;

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

            this.txtMaKhoa.Enabled = true;
            this.txtMaKhoa.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            dgvKhoa_CellClick(null, null);

            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.grbLuaChon.Enabled = true;

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

            this.txtMaKhoa.Enabled = false;
            this.txtTenKhoa.Focus();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.txtMaKhoa.ResetText();
            this.txtTenKhoa.ResetText();

            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;

            this.btnLuu.Enabled = false;
            this.btnHuyBo.Enabled = false;
            this.grbLuaChon.Enabled = false;

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

            dgvKhoa_CellClick(null, null);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                if (this.txtMaKhoa.Text == "")
                {
                    epvMaKhoa.SetError(this.txtMaKhoa, "!");
                    MessageBox.Show("Bạn chưa nhập Mã Khoa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    epvMaKhoa.Clear();
                    this.txtMaKhoa.Focus();
                }
                else if (dbKhoa.KiemTraMaKhoaTonTai(this.txtMaKhoa.Text))
                {
                    epvMaKhoa.SetError(txtMaKhoa, "!");
                    MessageBox.Show("Mã Khoa đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    epvMaKhoa.Clear();
                    txtMaKhoa.Focus();
                }
                else
                {
                    if (dbKhoa.ThemKhoa(this.txtMaKhoa.Text, this.txtTenKhoa.Text, ref err))
                    {
                        LoadData();
                        MessageBox.Show("Đã thêm xong!");
                    }
                    else
                        MessageBox.Show("Không thêm được, lỗi rồi!!! "+err);
                }
            }
            else
            {
                if (dbKhoa.CapNhatKhoa(this.txtMaKhoa.Text, this.txtTenKhoa.Text, ref err))
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
            DialogResult traLoi;
            traLoi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traLoi == DialogResult.Yes)
            {
                if (dbKhoa.KiemTraMaKhoaTrongLop(this.txtMaKhoa.Text))
                    MessageBox.Show("Bạn phải xóa Mẫu Khoa '" + this.txtMaKhoa.Text.Trim() + "' từ bảng Lớp!!!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (dbKhoa.XoaKhoa(this.txtMaKhoa.Text, ref err))
                    {
                        LoadData();
                        MessageBox.Show("Đã xóa xong!");
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được. Lỗi rồi!!! " + err);
                    }
                }
            }
            else
                MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
        }
    }
}
