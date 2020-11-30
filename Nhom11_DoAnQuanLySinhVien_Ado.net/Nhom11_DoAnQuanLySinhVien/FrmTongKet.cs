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
    public partial class FrmTongKet : Form
    {

        BLTinhHinhHocTap DBTHHT = new BLTinhHinhHocTap();
        DataTable dtTinhHinhHocTap = new DataTable();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
      
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public FrmTongKet()
        {
            InitializeComponent();
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
            
            if (cbbKhoa.Text == "ALL")
            {
                if (cbbNam.Text == "ALL")
                {
                    if (cbbLop.Text == "ALL")
                        this.DataTableTongKetTableAdapter.FillByALL(this.QuanLyDiemSinhVien.DataTableTongKet);
                    else
                        this.DataTableTongKetTableAdapter.FillBylop(this.QuanLyDiemSinhVien.DataTableTongKet, cbbLop.Text);
                }
                else
                {
                    if (cbbLop.Text == "ALL")
                        this.DataTableTongKetTableAdapter.FillByNamHoc(this.QuanLyDiemSinhVien.DataTableTongKet, cbbNam.Text);
                    else
                        this.DataTableTongKetTableAdapter.FillBylopNamHoc(this.QuanLyDiemSinhVien.DataTableTongKet,cbbLop.Text,cbbNam.Text);
                }

            }
            else
            {
                if (cbbNam.Text == "ALL")
                {
                    if (cbbLop.Text == "ALL")
                        this.DataTableTongKetTableAdapter.FillWithKhoa(this.QuanLyDiemSinhVien.DataTableTongKet, cbbKhoa.Text);
                    else
                        this.DataTableTongKetTableAdapter.FillByKhoa_Lop(this.QuanLyDiemSinhVien.DataTableTongKet, cbbKhoa.Text,cbbLop.Text);
                }
                else
                {
                    if (cbbLop.Text == "ALL")
                       this.DataTableTongKetTableAdapter.FillBynamHoc_Khoa(this.QuanLyDiemSinhVien.DataTableTongKet, cbbKhoa.Text, cbbNam.Text);
                    else
                        this.DataTableTongKetTableAdapter.FillBylopNamHoc(this.QuanLyDiemSinhVien.DataTableTongKet, cbbLop.Text, cbbNam.Text);


                }

            }
            
            this.reportViewer1.RefreshReport();
        }
        private void FrmTongKet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyDiemSinhVien.DataTableTongKet' table. You can move, or remove it, as needed.
            this.DataTableTongKetTableAdapter.FillByALL(this.QuanLyDiemSinhVien.DataTableTongKet);
            // TODO: This line of code loads data into the 'BangDiem.TONGKET' table. You can move, or remove it, as needed.
            load_data();
            load_khoa();
            load_lop();
        }

        private void pnlTittlebar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pnlTittlebar_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_lop();
        }
        public void ChangelanguagetoEngLish()
        {
            lblLop.Text = "Class ID";
            lblNamHoc.Text = "Year";
            lblKhoa.Text = "Faculty";
        }
        public void ChangeLanguageToVietNamese()
        {
            lblNamHoc.Text = "Năm Học";
            lblLop.Text = "Lớp";
            
            lblKhoa.Text = "Khoa";

        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
