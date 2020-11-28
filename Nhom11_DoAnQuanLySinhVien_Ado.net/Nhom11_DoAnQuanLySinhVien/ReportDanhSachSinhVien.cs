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
    public partial class ReportDanhSachSinhVien : Form
    {


        BLTinhHinhHocTap DBTHHT = new BLTinhHinhHocTap();
        DataTable dtTinhHinhHocTap = new DataTable();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public ReportDanhSachSinhVien()
        {
            InitializeComponent();
        }
        public void ChangelanguagetoEngLish()
        {
            lblKhoa.Text = "Faculty ID";
            lblLop.Text = "Class";
            
        }
        public void ChangeLanguageToVietNamese()
        {
            lblKhoa.Text = "Khoa";
            lblLop.Text = "Lớp";
        }
        private void load_khoa()
        {

            cbbKhoa.Items.Clear();
            List<string> dskhoa = new List<string>();
            dskhoa = DBTHHT.LayKhoa();
            cbbKhoa.Items.Add("ALL");
            foreach (string khoa in dskhoa)
            {
                cbbKhoa.Items.Add(khoa);
            }
        }
        private void load_lop()
        {
            List<string> dslop = new List<string>();
            dslop.Clear();
            dslop = DBTHHT.LayLopTrongKhoa(cbbKhoa.Text);
            cbbLop.Items.Clear();
            cbbLop.Items.Add("ALL");
            foreach (string lop in dslop)
            {
                cbbLop.Items.Add(lop);
            }
        }


        private void load_data()
        {
            load_khoa();
            load_lop();
            // TODO: This line of code loads data into the 'BangDiem.SINHVIEN' table. You can move, or remove it, as needed.
            if (cbbLop.Text == "ALL")
            {
                if(cbbKhoa.Text=="ALL")
                    this.SINHVIENTableAdapter.Fill(this.BangDiem.SINHVIEN);
                else
                    this.SINHVIENTableAdapter.FillByKhoa(this.BangDiem.SINHVIEN,cbbKhoa.Text);

            }
            else
                this.SINHVIENTableAdapter.FillByLOp(this.BangDiem.SINHVIEN,cbbLop.Text);


            this.reportViewerDSSV.RefreshReport();
        }
        private void ReportDanhSachSinhVien_Load(object sender, EventArgs e)
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

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_lop();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void reportViewerDSSV_Load(object sender, EventArgs e)
        {

        }

        private void lblKhoa_Click(object sender, EventArgs e)
        {

        }
    }
}
