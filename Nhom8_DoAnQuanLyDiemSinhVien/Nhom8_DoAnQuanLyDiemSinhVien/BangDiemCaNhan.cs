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
using System.Net;
using System.Net.Mail;
using Nhom11_DoAnQuanLySinhVien.BS_Layer;
namespace Nhom11_DoAnQuanLySinhVien
{
    public partial class BangDiemCaNhan : Form
    {

        public string MASV;
        public string MASINVIEN
        {
            get { return MASV;}
            set { MASV = value; }
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public BangDiemCaNhan()
        {
            InitializeComponent();
        }

        public void ChangelanguagetoEngLish()
        {
            
            lblNamHoc.Text = "Year";
            
        }
        public void ChangeLanguageToVietNamese()
        {
            lblNamHoc.Text = "Năm Học";
            
            
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void load_data()
        {


            if (cbbNamHoc.Text == "ALL")
            {

                this.KetQuaHocTapTableAdapter.FillByMSV(this.QuanLyDiemSinhVien.KetQuaHocTap, MASV);

                lblTBnam.ResetText();
            }
            else
            {
                this.KetQuaHocTapTableAdapter.FillByMSV_NamHoc(this.QuanLyDiemSinhVien.KetQuaHocTap, MASV, cbbNamHoc.Text);
                double? TBNam = KetQuaHocTapTableAdapter.Get_Tb_Nam(MASV, cbbNamHoc.Text);
                lblTBnam.Text = "Trung bình năm :" + Math.Round(Convert.ToDouble(TBNam), 2).ToString();


            }

            double? TB = this.KetQuaHocTapTableAdapter.GetTB(MASV);


            lblTB.Text = "Trung bình tích lũy :" + Math.Round(Convert.ToDouble(TB), 2).ToString();





            this.rpvBDCN.RefreshReport();
        }
        private void BangDiemCaNhan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyDiemSinhVien.KetQuaHocTap' table. You can move, or remove it, as needed.
            this.KetQuaHocTapTableAdapter.FillByMSV(this.QuanLyDiemSinhVien.KetQuaHocTap,MASV);
            // TODO: This line of code loads data into the 'BangDiem.KETQUAHOCTAP' table. You can move, or remove it, as needed.
            load_data();
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

    }
}
