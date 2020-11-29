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
using System.Data.SqlClient;
namespace Nhom11_DoAnQuanLySinhVien.FormControl
{
    public partial class DiemSinhVien : UserControl
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

        string mon = "", hk = "", nam = "";
        DataTable dtDiemSinhVien = null;
        bool Them; string err;
        BLDiemSinhVien dbDSV = new BLDiemSinhVien();

        public DiemSinhVien()
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
            dgvDiem.Columns[2].Width = 200;
            dgvDiem.Columns[3].Width = 200;

            dgvDiem.Columns[0].HeaderText = "StudenID";
            dgvDiem.Columns[1].HeaderText = "Name";
            dgvDiem.Columns[2].HeaderText = "Class ID";
            dgvDiem.Columns[3].HeaderText = "Subject ID";
            dgvDiem.Columns[4].HeaderText = "Subject Name";
            dgvDiem.Columns[5].HeaderText = "Semester";
            dgvDiem.Columns[6].HeaderText = "Year";
            dgvDiem.Columns[7].HeaderText = "First Grade";
            dgvDiem.Columns[8].HeaderText = "Second Grade";
            dgvDiem.Columns[9].HeaderText = "Final Grade";

            dgvDiem.AutoResizeColumns();

            
            lblMaMon.Text = "Subject ID:";
            lblDiemSV.Text = "STUDENT GRADES MANAGEMENT";
            lblDiemLan1.Text = "1st grade:";
            lblDiemLan2.Text = "2nd grade:";
            
            lblHK.Text = "Semester:";
            lblNam.Text = "Year:";
            lblLop.Text = "Class:";
            lblkhoa.Text = "Faculty:";
            
            lblTimKiem.Text = "Search:";
            lblMaSV.Text = "Student ID:";
            lblLuu.Text = "Save";
            lblSua.Text = "Edit";
            lblThem.Text = "  Add";
            lblXoa.Text = "Delete";
            lblHuyBo.Text = "Cancel";
            grbDSV.Text = "List";
            grbGhiChu.Text = "Node";
            grbTTChiTiet.Text = "Detail";
            grpLuaChon.Text = "Selection";
        }
        public void ChangeLanguageToVietNamese()
        {
            dgvDiem.Columns[6].Width = 200;
            dgvDiem.Columns[7].Width = 200;
            dgvDiem.Columns[8].Width = 200;
            dgvDiem.Columns[9].Width = 200;

            dgvDiem.Columns[0].HeaderText = "Mã SV";
            dgvDiem.Columns[1].HeaderText = "Họ Tên";
            dgvDiem.Columns[2].HeaderText = "Mã Lớp";
            dgvDiem.Columns[3].HeaderText = "Mã Môn";
            dgvDiem.Columns[4].HeaderText = "Tên Môn";
            dgvDiem.Columns[5].HeaderText = "Học Kì";
            dgvDiem.Columns[6].HeaderText = "Năm Học";
            dgvDiem.Columns[7].HeaderText = "Điểm Thi Lần 1";
            dgvDiem.Columns[8].HeaderText = "Điểm Thi Lần 2";
            dgvDiem.Columns[9].HeaderText = "Điểm Tổng Kết";

            dgvDiem.AutoResizeColumns();

            lblDiemSV.Text = "QUẢN LÝ ĐIỂM SINH VIÊN";
            lblMaMon.Text = "Môn học:";
            lblDiemLan1.Text = "Điểm thi lần 1:";
            lblDiemLan1.Text = "Điểm thi lần 2:";
            
            lblHK.Text = "Học kì:";
            lblNam.Text = "Năm học:";
            lblLop.Text = "Lớp:";
            lblkhoa.Text = "Khoa:";
            
            lblMaMon.Text = "Môn học:";
            lblMaSV.Text = "Mã SV:";
            lblTimKiem.Text = "Tìm kiếm:";


            lblLuu.Text = "Lưu";
            lblSua.Text = "Sửa";
            lblThem.Text = "Thêm";
            lblXoa.Text = " Xóa";
            lblHuyBo.Text = "Hủy bỏ";
            grbDSV.Text = "Danh sách";
            grbGhiChu.Text = "Ghi chú";

            grbTTChiTiet.Text = "Thông tin chi tiết";
            grpLuaChon.Text = "Lựa chọn";
        }

        private void Load_MonHoc()
        {
            cbbMonHoc.Items.Clear();
            List<string> dsMon = dbDSV.LayMonHoc();
            foreach (string Mon in dsMon)
            {
                cbbMonHoc.Items.Add(Mon);
            }
        }
        private void Load_Khoa()
        {

            cbbKhoa.Items.Clear();
            List<string> dskhoa = new List<string>();
            dskhoa = dbDSV.LayKhoa();
            cbbKhoa.Items.Add("ALL");
            foreach (string khoa in dskhoa)
            {
                cbbKhoa.Items.Add(khoa);
            }
        }
        private void Load_Lop()
        {
            List<string> dslop = new List<string>();
            dslop.Clear();
            dslop = dbDSV.LayLopTrongKhoa(cbbKhoa.Text);
            cbbLop.Items.Clear();
            foreach (string lop in dslop)
            {
                cbbLop.Items.Add(lop);
            }
        }
        public void Load_Data()
        {
            try
            {
                dtDiemSinhVien = new DataTable();
                dtDiemSinhVien.Clear();
                DataSet ds = dbDSV.LayDiemHocLaiTheoKhoaLopHocKiMon(cbbKhoa.Text, cbbLop.Text, cbbHocKi.Text, cbbMonHoc.Text, cbbNamHoc.Text);
                dtDiemSinhVien = ds.Tables[0];
                dgvDiem.DataSource = dtDiemSinhVien;
                dgvDiem.AutoResizeColumns();

                Load_Khoa();
                Load_MonHoc();
                Load_Lop();
                //this.txtHoTen.ResetText();
                this.btnLuu.Enabled = false;
                this.btnHuyBo.Enabled = false;
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.grbTTChiTiet.Enabled = false;

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

                dgvDiem_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không Load được dữ liệu. Lỗi rồi!!! " + err);
            }
        }

        private void DiemSinhVien_Load(object sender, EventArgs e)
        {
            Load_Data();
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            txtDiemthi1.ResetText();
            txtDiemThi2.ResetText();
           
            txtMaSV.ResetText();
            
            errorProvider.Clear();
            if (cbbKhoa.Text == "")
                errorProvider.SetError(cbbKhoa, "Chưa nhập Khoa!");
            else
            {
                try
                {
                    dtDiemSinhVien = new DataTable();
                    dtDiemSinhVien.Clear();
                    DataSet ds = new DataSet();
                    ds = dbDSV.LayDiemHocLaiTheoKhoaLopHocKiMon(cbbKhoa.Text, cbbLop.Text, cbbHocKi.Text, cbbMonHoc.Text, cbbNamHoc.Text);
                    dtDiemSinhVien = ds.Tables[0];
                    dgvDiem.DataSource = dtDiemSinhVien;
                    dgvDiem.AutoResizeColumns();

                    dgvDiem_CellClick(null, null);
                }
                catch
                {
  //                  MessageBox.Show(err);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            mon = cbbMonHoc.Text; hk = cbbHocKi.Text; nam = cbbNamHoc.Text;
            Them = true;
            txtDiemthi1.ResetText();
            txtDiemThi2.ResetText();
            
            this.txtMaSV.ResetText();
            
            this.txtDiemThi2.ResetText();

            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.grbTTChiTiet.Enabled = true;

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
            txtMaSV.Focus();
        }


        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in grpLuaChon.Controls)
            {
                ctrl.Enabled = true;
            }

            txtDiemthi1.ResetText();
            txtDiemThi2.ResetText();
            
            txtMaSV.ResetText();
            
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnLuu.Enabled = false;
            this.btnHuyBo.Enabled = false;
            this.grbTTChiTiet.Enabled = false;

            this.txtMaSV.Enabled = true;

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

            dgvDiem_CellClick(null, null);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in grpLuaChon.Controls)
            {
                if (ctrl.Name != cbbMonHoc.Name && ctrl.Name != cbbHocKi.Name && ctrl.Name != cbbNamHoc.Name && ctrl.Name != lblHK.Name && ctrl.Name != lblMaMon.Name && ctrl.Name != lblNam.Name)
                    ctrl.Enabled = false;
            }
            Them = false;
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.grbTTChiTiet.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            //txtDiemThi1.ResetText();
            //txtDiemThi2.ResetText();
            //txtDiemTK.ResetText();

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
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text != "")
            {
                DialogResult DL = MessageBox.Show("Bạn có muốn xóa mẫu tin này?", "Xác nhận", MessageBoxButtons.YesNoCancel);
                if (DL == DialogResult.Yes)
                {
                    int r = dgvDiem.CurrentCell.RowIndex;
                    if (dbDSV.XoaDiemHocTap(this.txtMaSV.Text, dgvDiem.Rows[r].Cells[3].Value.ToString(),
                        dgvDiem.Rows[r].Cells[5].Value.ToString(), dgvDiem.Rows[r].Cells[6].Value.ToString(), ref err))
                    {
                        Load_Data();
                        Kiemtra();
                        MessageBox.Show("Đã xóa xong!");
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được. Lỗi rồi!!! " + err);
                    }
                }
            }
        }

      
        private void Kiemtra()
        {
            errorProvider.Clear();
            foreach (DataGridViewRow r in dgvDiem.Rows)
                r.Selected = false;
            if (txtMaSV.Text == "")
                errorProvider.SetError(txtMaSV, "Chưa nhập Mã Sinh Viên ");
            else
            {
                int dem = 0;
                for (int i = 0; i < dgvDiem.Rows.Count - 1; i++)
                {
                    if (dgvDiem.Rows[i].Cells[0].Value.ToString() == txtMaSV.Text)
                    {
                        dem++;
                        dgvDiem.Rows[i].Selected = true;
                        txtDiemthi1.Text = dgvDiem.Rows[i].Cells[7].Value.ToString();
                        txtDiemThi2.Text = dgvDiem.Rows[i].Cells[8].Value.ToString();
                       
                        if (Them)
                        {
                            if (dgvDiem.Rows[i].Cells[3].Value.ToString() == cbbMonHoc.Text && dgvDiem.Rows[i].Cells[5].Value.ToString() == cbbHocKi.Text && dgvDiem.Rows[i].Cells[6].Value.ToString() == cbbNamHoc.Text)
                                MessageBox.Show("Sinh Viên này đã được nhập điểm từ trước.");
                        }
                    }
                }
                if (dem == 0)
                {
                    if (Them == false)
                        MessageBox.Show("Không tìm thấy Sinh Viên này!");
                    else
                        MessageBox.Show("Bạn chưa nhập điểm cho Sinh Viên này!");
                }
            }
        }
        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            Kiemtra();
        }

        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvDiem.CurrentCell.RowIndex;
            txtMaSV.Text = dgvDiem.Rows[r].Cells[0].Value.ToString();
            txtDiemthi1.Text = dgvDiem.Rows[r].Cells[7].Value.ToString();
            txtDiemThi2.Text = dgvDiem.Rows[r].Cells[8].Value.ToString();
            
            //cbbHocKi.SelectedIndex = cbbHocKi.Items.IndexOf(dgvDiem.Rows[r].Cells[5].Value.ToString());
            //cbbMonHoc.SelectedIndex = cbbMonHoc.Items.IndexOf(dgvDiem.Rows[r].Cells[3].Value.ToString());
            //cbbNamHoc.SelectedIndex = cbbNamHoc.Items.IndexOf(dgvDiem.Rows[r].Cells[6].Value.ToString());
            //cbbLop.SelectedIndex = cbbLop.Items.IndexOf(dgvDiem.Rows[r].Cells[2].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                if (cbbHocKi.Text == "")
                    errorProvider.SetError(cbbHocKi, "Cần nhập Học Kì!");
                else
                if (cbbNamHoc.Text == "")
                    errorProvider.SetError(cbbNamHoc, "Cần nhập Năm Học!");
                else
                if (cbbMonHoc.Text == "")
                    errorProvider.SetError(cbbMonHoc, "Cần nhập Môn Học!");
                else
                if (txtMaSV.Text == "")
                    errorProvider.SetError(txtMaSV, "Chưa nhập Mã Sinh Viên!");
                else
                {
                    if (dbDSV.kiemTraThongTinSinhVien(txtMaSV.Text, cbbMonHoc.Text, cbbHocKi.Text, cbbNamHoc.Text))
                        MessageBox.Show("Dữ liệu bị trùng!");
                    else
                    {
                        //if (dbDSV.ThemDiemSinhVien(txtMaSV.Text, cbbMonHoc.Text, cbbHocKi.Text, cbbNamHoc.Text, txtDiemthi1.Text, txtDiemThi2.Text, txtGhiChu.Text, ref err))
                        //{
                        //    cbbHocKi.Text = hk;
                        //    cbbMonHoc.Text = mon;
                        //    cbbNamHoc.Text = nam;

                        //    Load_Data();
                        //    btnTimKiem_Click(null, null);
                        //    MessageBox.Show("Đã thêm xong!");
                        //}
                        //else
                        //    MessageBox.Show("Không thêm được. Lỗi rồi!!! " + err);
                    }
                }
            }
            else// Sửa
            {
                int r = dgvDiem.CurrentCell.RowIndex;
                if (txtMaSV.Text=="")
                    MessageBox.Show("Không có mục nào được chọn!");
                else
                {
                    //if (dbDSV.CapNhatDiemHocTap(txtMaSV.Text, dgvDiem.Rows[r].Cells[3].Value.ToString(),
                    //    dgvDiem.Rows[r].Cells[5].Value.ToString(), dgvDiem.Rows[r].Cells[6].Value.ToString(),
                    //    txtDiemthi1.Text, txtDiemThi2.Text, "", txtGhiChu.Text, ref err))
                    //{
                    //    Load_Data();
                    //    btnTimKiem_Click(null, null);
                    //    MessageBox.Show("Đã sửa xong!");
                    //}
                    //else
                    //    MessageBox.Show("Không sửa được. Lỗi rồi!!! " + err);
                }
            }
            foreach (Control ctrl in grpLuaChon.Controls)
            {
                ctrl.Enabled = true;
            }
        }
        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Lop();
        }
    }
}
