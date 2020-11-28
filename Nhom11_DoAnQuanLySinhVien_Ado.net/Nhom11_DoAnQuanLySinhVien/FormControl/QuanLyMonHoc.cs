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
    public partial class QuanLyMonHoc : UserControl
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

        DataTable dtMonHoc = null;
        bool Them;
        string err;
        BLMonHoc dbMonHoc = new BLMonHoc();
        public QuanLyMonHoc()
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
        public void ChangeLanguageToEngLish()
        {
            for (int i = 0; i < 3; i++)
                dgvMonHoc.Columns[i].Width = 200;

            dgvMonHoc.Columns[0].HeaderText = "Subject ID";
            dgvMonHoc.Columns[1].HeaderText = "Subject Name";
            dgvMonHoc.Columns[2].HeaderText = "Credits Number";

            dgvMonHoc.AutoResizeColumns();

            lblMonHoc.Text = "SUBJECTS MANAGEMENT";
            lblSoTinChi.Text = "Credis number:";
            lblTenMon.Text = "Name:";
            lblMaMon.Text = "Subject ID:";

            lblLuu.Text = "Save";
            lblSua.Text = "Edit";
            lblThem.Text = "  Add";
            lblXoa.Text = "Delete";
            lblHuyBo.Text = "Cancel";

            grbTTCT.Text = "Detail";
            grbDanhSach.Text = "List";
        }
        public void ChangeLanguageToVietNamese()
        {
            dgvMonHoc.Columns[0].HeaderText = "Mã Môn";
            dgvMonHoc.Columns[1].HeaderText = "Tên Môn";
            dgvMonHoc.Columns[2].HeaderText = "Số Tín Chỉ";
            lblMonHoc.Text = "    QUẢN LÝ MÔN HỌC";
            lblSoTinChi.Text = "Số tín chỉ:";
            lblTenMon.Text = "Tên môn:";
            lblMaMon.Text = "Mã môn:";

            lblLuu.Text = "Lưu";
            lblSua.Text = "Sửa";
            lblThem.Text = "Thêm";
            lblXoa.Text = " Xóa";
            lblHuyBo.Text = "Hủy bỏ";

            grbTTCT.Text = "Thông tin chi tiết";
            grbDanhSach.Text = "Danh sách";
        }

        public void LoadData()
        {
            try
            {
                dtMonHoc = new DataTable();
                dtMonHoc.Clear();

                DataSet ds = dbMonHoc.LayMonHoc();
                dtMonHoc = ds.Tables[0];

                dgvMonHoc.DataSource = dtMonHoc;
                dgvMonHoc.AutoResizeColumns();

                this.txtMaMon.ResetText();
                this.txtTenMon.ResetText();
                this.txtSoTinChi.ResetText();

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

                dgvMonHoc_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table MON. Lỗi rồi!!!");
            }
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvMonHoc.CurrentCell.RowIndex;
            this.txtMaMon.Text =
                dgvMonHoc.Rows[r].Cells[0].Value.ToString();
            this.txtTenMon.Text =
                dgvMonHoc.Rows[r].Cells[1].Value.ToString();
            this.txtSoTinChi.Text =
                dgvMonHoc.Rows[r].Cells[2].Value.ToString();
        }

        private void QuanLyMonHoc_Load(object sender, EventArgs e)
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
            this.txtMaMon.ResetText();
            this.txtTenMon.ResetText();
            this.txtSoTinChi.ResetText();

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

            this.txtMaMon.Enabled = true;
            this.txtMaMon.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            dgvMonHoc_CellClick(null, null);

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

            this.txtMaMon.Enabled = false;
            this.txtTenMon.Focus();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.txtMaMon.ResetText();
            this.txtTenMon.ResetText();
            this.txtSoTinChi.ResetText();

            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;

            this.btnLuu.Enabled = false;
            this.btnHuyBo.Enabled = false;
            this.grbTTCT.Enabled = false;

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

            dgvMonHoc_CellClick(null, null);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                if (this.txtMaMon.Text == "")
                {
                    epvMaMon.SetError(this.txtMaMon, "!");
                    MessageBox.Show("Bạn chưa nhập Mã môn!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    epvMaMon.Clear();
                    this.txtMaMon.Focus();
                }
                else if (dbMonHoc.KiemTraMaMonTonTai(this.txtMaMon.Text, ref err) == true)
                {
                    epvMaMon.SetError(this.txtMaMon, "!");
                    MessageBox.Show("Mã môn đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    epvMaMon.Clear();
                    txtMaMon.Focus();
                }
                else
                {
                    if (dbMonHoc.ThemMonHoc(this.txtMaMon.Text, this.txtTenMon.Text, this.txtSoTinChi.Text, ref err))
                    {     
                        LoadData();
                        MessageBox.Show("Đã thêm xong!");
                    }
                    else
                    {
                        MessageBox.Show("Không thêm được. Lỗi rồi!"+ err);
                    }
                }
            }
            else
            {
                if (dbMonHoc.CapNhatMonHoc(this.txtMaMon.Text, this.txtTenMon.Text, this.txtSoTinChi.Text, ref err))
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
                int ktTonTaiMHKhac = dbMonHoc.KiemTraMonHocTonTaiKhac(this.txtMaMon.Text, ref err);
                if (ktTonTaiMHKhac > -1 && ktTonTaiMHKhac < 2)
                {
                    if (ktTonTaiMHKhac == 0)
                        MessageBox.Show("Bạn phải xóa Mẫu Môn Học " + this.txtMaMon.Text + " từ bảng Giảng Viên", "Thông báo!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (ktTonTaiMHKhac == 1)
                        MessageBox.Show("Bạn phải xóa Mẫu Môn Học " + this.txtMaMon.Text + " từ bảng Kết Quả Học Tập", "Thông báo!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (dbMonHoc.XoaMonHoc(this.txtMaMon.Text, ref err))
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
