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

namespace Nhom11_DoAnQuanLySinhVien
{
    public partial class ReportDanhSachLop : Form
    {
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

        private void ReportDanhSachLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BangDiem.LOP' table. You can move, or remove it, as needed.
            this.LOPTableAdapter.Fill(this.BangDiem.LOP);

            this.rpvDSL.RefreshReport();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (this.cbbMaLop.Text != "ALL")
            {
                this.LOPTableAdapter.FillLop(this.BangDiem.LOP, "%"+this.cbbMaLop.Text+"%");

                this.rpvDSL.RefreshReport();
            }
            else
            {
                this.LOPTableAdapter.Fill(this.BangDiem.LOP);

                this.rpvDSL.RefreshReport();
            }    
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
    }
}
