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
    public partial class ThongTinSinhVien : UserControl
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

        DataTable dtSinhVien = null;
        bool Them;
        string err;
        BLSinhVien dbSinhVien = new BLSinhVien();

        public void ChangeLanguageToEnglish()
        {
            dgvSinhVien.Columns[0].HeaderText = "Student ID";
            dgvSinhVien.Columns[1].HeaderText = "Name";
            dgvSinhVien.Columns[2].HeaderText = "Birthday";
            dgvSinhVien.Columns[3].HeaderText = "Sex";
            dgvSinhVien.Columns[4].HeaderText = "Address";
            dgvSinhVien.Columns[0].HeaderText = "Class ID";

            lblMaLop.Text = "Class ID:";
            lblDiaChi.Text = "Addresss:";
            lblGioiTinh.Text = "Sex:";
            lblHoTen.Text = "Name:";
            lblKhoa.Text = "Faculty:";
            lblLop.Text = "       Class:";
            lblMaSV.Text = "Student ID:";
            lblNgaySinh.Text = "Birthday:";
            lblSV.Text = "STUDENT INFORMATION MANAGEMENT";

            lblLuu.Text = "Save";
            lblSua.Text = "Edit";
            lblThem.Text = "  Add";
            lblXoa.Text = "Delete";
            lblHuyBo.Text = "Cancel";

            grbTTCT.Text = "Detail";
            grbTimKiem.Text = "Search";
            grbDanhSach.Text = "List";
        }
        public void ChangeLanguageToVietnamese()
        {

            dgvSinhVien.Columns[0].HeaderText = "Mã Sinh Viên";
            dgvSinhVien.Columns[1].HeaderText = "Họ Tên";
            dgvSinhVien.Columns[2].HeaderText = "Ngày Sinh";
            dgvSinhVien.Columns[3].HeaderText = "Giới Tính";
            dgvSinhVien.Columns[4].HeaderText = "Địa Chỉ";
            dgvSinhVien.Columns[0].HeaderText = "Mã Lớp";
            lblMaLop.Text = "Mã lớp:";
            lblDiaChi.Text = "Địa chỉ:";
            lblGioiTinh.Text = "Giới tính:";
            lblHoTen.Text = "Họ và tên:";
            lblKhoa.Text = "Khoa:";
            lblLop.Text = "Lớp học:";
            lblMaSV.Text = "Mã SV:";
            lblNgaySinh.Text = "Ngày Sinh:";
            lblSV.Text = "       QUẢN LÝ THÔNG TIN SINH VIÊN";

            lblLuu.Text = "Lưu";
            lblSua.Text = "Sửa";
            lblThem.Text = "Thêm";
            lblXoa.Text = " Xóa";
            lblHuyBo.Text = "Hủy bỏ";

            grbTTCT.Text = "Thông tin chi tiết";
            grbTimKiem.Text = "Tìm kiếm";
            grbDanhSach.Text = "Danh sách";
        }

        public ThongTinSinhVien()
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
        public void LoadCboMaLop()
        {
            cboMaLop.Items.Clear();
            List<string> dsMaLop = dbSinhVien.LayMaLop();
            for (int i = 0; i < dsMaLop.Count; i++)
            {
                cboMaLop.Items.Add(dsMaLop[i]);
            }
        }
        public void LoadCboMaKhoa()
        {
            cboMaKhoa.Items.Clear();
            cboMaKhoa.Items.Add("ALL");
            List<string> dsMaKhoa = dbSinhVien.LayMaKhoa();
            for (int i = 0; i < dsMaKhoa.Count; i++)
            {
                cboMaKhoa.Items.Add(dsMaKhoa[i]);
            }
        }
        public void LoadCboMaLopTimKiem()
        {
            cboTimMaLop.Items.Clear();
            cboTimMaLop.Items.Add("ALL");
            List<string> dsTimMaLop = dbSinhVien.LayMaLopTimKiem(this.cboMaKhoa.Text);
            for (int i = 0; i < dsTimMaLop.Count; i++)
            {
                cboTimMaLop.Items.Add(dsTimMaLop[i]);
            }
        }

        void LoadData()
        {
            try
            {
                dtSinhVien = new DataTable();
                dtSinhVien.Clear();

                DataSet ds = dbSinhVien.LaySinhVien();
                dtSinhVien = ds.Tables[0];

                dgvSinhVien.DataSource = dtSinhVien;
                dgvSinhVien.AutoResizeColumns();

                this.txtMaSV.ResetText();
                this.txtHoTen.ResetText();
                this.mskNgaySinh.ResetText();
                this.cboGioiTinh.ResetText();
                this.txtDiaChi.ResetText();
                this.cboMaLop.ResetText();

                this.btnLuu.Enabled = false;
                this.btnHuyBo.Enabled = false;
                this.grbTTCT.Enabled = false;

                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;

                this.cboMaKhoa.Text = "ALL";
                this.cboTimMaLop.Text = "ALL";
                this.cboTimMaLop.Enabled = false;

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

                dgvSinhVien_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Sinh Viên. Lỗi rồi!!!");
            }
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvSinhVien.CurrentCell.RowIndex;

            this.txtMaSV.Text =
                dgvSinhVien.Rows[r].Cells[0].Value.ToString();
            this.txtHoTen.Text =
                dgvSinhVien.Rows[r].Cells[1].Value.ToString();
            this.cboGioiTinh.Text =
                dgvSinhVien.Rows[r].Cells[2].Value.ToString();
            this.mskNgaySinh.Text =
                dgvSinhVien.Rows[r].Cells[3].Value.ToString();
            this.txtDiaChi.Text =
                dgvSinhVien.Rows[r].Cells[4].Value.ToString();
            this.cboMaLop.Text =
                dgvSinhVien.Rows[r].Cells[5].Value.ToString();
        }

        private void ThongTinSinhVien_Load(object sender, EventArgs e)
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;

            this.txtMaSV.ResetText();
            this.txtHoTen.ResetText();
            this.mskNgaySinh.ResetText();
            this.cboGioiTinh.ResetText();
            this.txtDiaChi.ResetText();
            this.cboMaLop.ResetText();

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

            this.txtMaSV.Enabled = true;
            this.txtMaSV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;

            dgvSinhVien_CellClick(null, null);

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

            this.txtMaSV.Enabled = false;
            this.txtHoTen.Focus();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.txtMaSV.ResetText();
            this.txtHoTen.ResetText();
            this.mskNgaySinh.ResetText();
            this.cboGioiTinh.ResetText();
            this.txtDiaChi.ResetText();
            this.cboMaLop.ResetText();

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

            dgvSinhVien_CellClick(null, null);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                if (this.txtMaSV.Text == "")
                {
                    epvSinhVien.SetError(this.txtMaSV, "!");
                    MessageBox.Show("Bạn chưa nhập Mã SV", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    epvSinhVien.Clear();
                    this.txtMaSV.Focus();
                }
                else if(dbSinhVien.KiemTraSinhVienTonTai(this.txtMaSV.Text))
                {
                    epvSinhVien.SetError(this.txtMaSV, "!");
                    MessageBox.Show("Mã SV đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    epvSinhVien.Clear();
                    this.txtMaSV.Focus();
                }
                else if(dbSinhVien.KiemTraMaLop(this.cboMaLop.Text)==false)
                {
                    MessageBox.Show("Mã Lớp không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
                else
                {
                    if (dbSinhVien.ThemSinhVien(this.txtMaSV.Text, this.txtHoTen.Text,
                            this.mskNgaySinh.Text, this.cboGioiTinh.Text, this.txtDiaChi.Text
                            , this.cboMaLop.Text, ref err))
                    {
                        LoadData();
                        MessageBox.Show("Đã thêm xong!");
                    }
                    else
                    {
                        MessageBox.Show("Không thêm được. Lỗi rồi!!! "+err);
                    }
                }
            }
            else
            {
                if (dbSinhVien.KiemTraMaLop(this.cboMaLop.Text) == false)
                {
                    MessageBox.Show("Mã Lớp không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if(dbSinhVien.CapNhatSinhVien(this.txtMaSV.Text, this.txtHoTen.Text,
                            this.mskNgaySinh.Text, this.cboGioiTinh.Text, this.txtDiaChi.Text
                            , this.cboMaLop.Text, ref err))
                    {     
                        LoadData();
                        MessageBox.Show("Đã sửa xong!");
                    }
                    else
                    {
                        MessageBox.Show("Không sửa được. Lỗi rồi!!! "+err);
                    }
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
                if (dbSinhVien.KiemTraSinhVienTonTaiKhac(this.txtMaSV.Text))
                    MessageBox.Show("Bạn phải xóa Mẫu SinhVien " + this.txtMaSV.Text + " từ bảng KẾT QUẢ HỌC TẬP.", "Thông báo!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (dbSinhVien.XoaSinhVien(this.txtMaSV.Text, ref err))
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
            {
                MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
            }
        }

        private void cboMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboMaKhoa.Text != "ALL")
            {
                this.cboTimMaLop.Enabled = true;
                this.cboTimMaLop.Text = "ALL";
                LoadCboMaLopTimKiem();
            }
            else
            {
                this.cboTimMaLop.Text = "ALL";
                this.cboTimMaLop.Enabled = false;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            /*try
            {*/
                this.txtMaSV.ResetText();
                this.txtHoTen.ResetText();
                this.mskNgaySinh.ResetText();
                this.cboGioiTinh.ResetText();
                this.txtDiaChi.ResetText();
                this.cboMaLop.ResetText();

                dtSinhVien = new DataTable();
                dtSinhVien.Clear();

                DataSet ds = dbSinhVien.LaySinhVienTimKiem(this.cboMaKhoa.Text, this.cboTimMaLop.Text);
                dtSinhVien = ds.Tables[0];

                dgvSinhVien.DataSource = dtSinhVien;
                dgvSinhVien.AutoResizeColumns();
                if (dgvSinhVien.Rows.Count != 1)
                    dgvSinhVien_CellClick(null, null);
            /*}
            catch
            {
                MessageBox.Show("Không tìm kiếm được lỗi rồi!" + err);
            }*/
        }

        
    }
}
