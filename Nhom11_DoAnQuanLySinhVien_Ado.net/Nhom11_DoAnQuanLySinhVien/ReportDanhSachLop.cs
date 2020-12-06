using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom11_DoAnQuanLySinhVien.BS_Layer;

namespace Nhom11_DoAnQuanLySinhVien
{
    public partial class ReportDanhSachLop : Form
    {
        BLTinhHinhHocTap DBTHHT = new BLTinhHinhHocTap();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public ReportDanhSachLop()
        {
            InitializeComponent();
        }
        public void ChangelanguagetoEngLish()
        {
            lblMaLop.Text = "Class ID:";
        }
        public void ChangeLanguageToVietNamese()
        {
            lblMaLop.Text = "Mã Lớp:";
        }
        private void load_khoa()
        {

            cbbMaKhoa.Items.Clear();
            List<string> dskhoa = new List<string>();
            dskhoa = DBTHHT.LayKhoa();
            cbbMaKhoa.Items.Add("ALL");
            foreach (string khoa in dskhoa)
            {
                cbbMaKhoa.Items.Add(khoa);
            }
        }
        private void load_lop()
        {
            List<string> dslop = new List<string>();
            dslop.Clear();
            dslop = DBTHHT.LayLopTrongKhoa(cbbMaKhoa.Text);
            cbbMaLop.Items.Clear();
            cbbMaLop.Items.Add("ALL");
            foreach (string lop in dslop)
            {
                cbbMaLop.Items.Add(lop);
            }
        }
        private void load_data()
        {
            load_khoa();
            load_lop();
            //TODO: This line of code loads data into the 'BangDiem.SINHVIEN' table.You can move, or remove it, as needed.


            if (cbbMaLop.Text == "ALL")
            {
                if (cbbMaKhoa.Text == "ALL")
                    this.LopTableAdapter.Fill(this.QuanLyDiemSinhVien.Lop);
                else
                    this.LopTableAdapter.FillByKhoa(this.QuanLyDiemSinhVien.Lop, cbbMaKhoa.Text);

            }
            else
                this.LopTableAdapter.FillByLop(this.QuanLyDiemSinhVien.Lop, cbbMaLop.Text);
            this.rpvDSL.RefreshReport();
        }
            private void ReportDanhSachLop_Load(object sender, EventArgs e)
        {
            load_data();

            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void pnlTittlebar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void rpvDSL_Load(object sender, EventArgs e)
        {

        }

        private void cbbMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
