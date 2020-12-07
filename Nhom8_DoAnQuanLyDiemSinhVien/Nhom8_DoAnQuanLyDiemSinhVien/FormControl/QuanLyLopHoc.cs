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
    public partial class QuanLyLopHoc : UserControl
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

        DataTable dtLopHoc = null;
        bool Them;
        string err;
        BLLopHoc dbLopHoc = new BLLopHoc();
        public void ChangeLanguageToEnglish()
        {
            lblLop.Text = "CLASS MANAGEMENT";
            lblMaKhoa.Text = "Faculty ID:";
            //lblSiSo.Text = "ToTal:";
            lblTenLop.Text = "Class name:";
            lblMalop.Text = "Class ID:";

            lblLuu.Text = "Save";
            lblSua.Text = "Edit";
            lblThem.Text = "  Add";
            lblXoa.Text = "Delete";
            lblHuyBo.Text = "Cancel";

            grbDanhSach.Text = "List";
            grbSelection.Text = "Selection";

            dgvLop.Columns[0].Width = 200;
            dgvLop.Columns[2].Width = 200;

            dgvLop.Columns[0].HeaderText = "Faculty ID";
            dgvLop.Columns[1].HeaderText = "Class ID";
            dgvLop.Columns[2].HeaderText = "Class Name";
            dgvLop.Columns[3].HeaderText = "Total";

            dgvLop.AutoResizeColumns();
        }
        public void ChangeLanguageToVietnamese()
        {
            lblLop.Text = "       QUẢN LÝ LỚP";
            lblMaKhoa.Text = "Mã khoa:";
            //lblSiSo.Text = "Sỉ số:";
            lblTenLop.Text = "Tên lớp:";
            lblMalop.Text = "Mã lớp:";


            lblLuu.Text = "Lưu";
            lblSua.Text = "Sửa";
            lblThem.Text = "Thêm";
            lblXoa.Text = " Xóa";
            lblHuyBo.Text = "Hủy bỏ";

            grbDanhSach.Text = "Danh sách";
            grbSelection.Text = "Lựa chọn";

            dgvLop.Columns[03].Width = 200;

            dgvLop.Columns[0].HeaderText = "Mã Khoa";
            dgvLop.Columns[1].HeaderText = "Mã Lớp";
            dgvLop.Columns[2].HeaderText = "Tên Lớp";
            dgvLop.Columns[3].HeaderText = "Sĩ Số";

            dgvLop.AutoResizeColumns();
        }
        public QuanLyLopHoc()
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
        public void LoadCboMaKhoa()
        {
            cboMaKhoa.Items.Clear();
            List<string> dsMaKhoa = dbLopHoc.LayMaKhoa();
            for (int i = 0; i < dsMaKhoa.Count; i++)
                cboMaKhoa.Items.Add(dsMaKhoa[i]);
        }
        public void LoadData()
        {
            try
            {
                dtLopHoc = new DataTable();
                dtLopHoc.Clear();

                DataSet ds = dbLopHoc.LayLopHoc();
                dtLopHoc = ds.Tables[0];

                dgvLop.DataSource = dtLopHoc;
                dgvLop.AutoResizeColumns();

                this.cboMaKhoa.ResetText();
                this.txtMaLop.ResetText();
                this.txtTenLop.ResetText();
                //this.txtSiSo.ResetText();

                this.btnLuu.Enabled = false;
                this.btnHuyBo.Enabled = false;
                this.grbSelection.Enabled = false;

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

                //dgvLop_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table LOP. Lỗi rồi!!!");
            }
        }
        private void QuanLyLopHoc_Load(object sender, EventArgs e)
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

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvLop.CurrentCell.RowIndex;
            //MessageBox.Show(r.ToString());
            this.cboMaKhoa.Text =
                dgvLop.Rows[r].Cells[2].Value.ToString();
            this.txtMaLop.Text =
                dgvLop.Rows[r].Cells[0].Value.ToString();
            this.txtTenLop.Text =
                dgvLop.Rows[r].Cells[1].Value.ToString();
            this.txtSiSo.Text =
                dgvLop.Rows[r].Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;

            this.cboMaKhoa.ResetText();
            this.txtMaLop.ResetText();
            this.txtTenLop.ResetText();
            //this.txtSiSo.ResetText();

            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.grbSelection.Enabled = true;

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

            this.txtMaLop.Enabled = true;
            this.txtMaLop.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            dgvLop_CellClick(null, null);

            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.grbSelection.Enabled = true;

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

            this.txtMaLop.Enabled = false;
            this.txtMaLop.Focus();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.cboMaKhoa.ResetText();
            this.txtMaLop.ResetText();
            this.txtTenLop.ResetText();
            this.txtSiSo.ResetText();

            this.btnLuu.Enabled = false;
            this.btnHuyBo.Enabled = false;
            this.grbSelection.Enabled = false;

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

            dgvLop_CellClick(null, null);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                if (this.txtMaLop.Text == "")
                {
                    epvMaLop.SetError(this.txtMaLop, "!");
                    MessageBox.Show("Bạn chưa nhập Mã Lớp!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    epvMaLop.Clear();
                    this.txtMaLop.Focus();
                }
                else if (dbLopHoc.kiemTraMaLopTonTai(this.txtMaLop.Text, ref err) == true)
                {
                    epvMaLop.SetError(txtMaLop, "!");
                    MessageBox.Show("Mã lớp đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    epvMaLop.Clear();
                    txtMaLop.Focus();
                }
                else if (dbLopHoc.kiemTraMaKhoaChinhXac(this.cboMaKhoa.Text, ref err) == false)
                {
                    MessageBox.Show("Nhập mã khoa không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (dbLopHoc.ThemLopHoc(this.cboMaKhoa.Text, this.txtMaLop.Text, this.txtTenLop.Text,txtSiSo.Text, ref err))
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
                if (dbLopHoc.kiemTraMaKhoaChinhXac(this.cboMaKhoa.Text, ref err) == false)
                {
                    MessageBox.Show("Nhập mã khoa không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (dbLopHoc.CapNhatLopHoc(this.cboMaKhoa.Text, this.txtMaLop.Text, this.txtTenLop.Text,txtSiSo.Text, ref err))
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
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traLoi;
            traLoi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traLoi == DialogResult.Yes)
            {
                if (dbLopHoc.kiemTraSinhVienCoLop(this.txtMaLop.Text, ref err))
                    MessageBox.Show("Bạn phải xóa Mẫu Lớp " + this.txtMaLop.Text + " từ bảng Sinh Viên", "Thông báo!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {

                    if (dbLopHoc.XoaLopHoc(this.txtMaLop.Text, ref err))
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
