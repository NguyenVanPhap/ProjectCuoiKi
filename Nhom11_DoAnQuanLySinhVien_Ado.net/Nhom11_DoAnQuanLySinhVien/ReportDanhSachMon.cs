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
    public partial class ReportDanhSachMon : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public ReportDanhSachMon()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ChangelanguagetoEngLish()
        {
            lblMaMon.Text = "Subject ID:";
        }
        public void ChangeLanguageToVietNamese()
        {
            lblMaMon.Text = "Mã Môn:";
        }

        private void ReportDanhSachMon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BangDiem.MON' table. You can move, or remove it, as needed.
            //this.MONTableAdapter.Fill(this.BangDiem.MON);

            //this.rpvDSM.RefreshReport();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (this.cbbMaMon.Text != "ALL")
            {
                //this.MONTableAdapter.FillMon(this.BangDiem.MON, "%"+ this.cbbMaMon.Text+ "%");

                //this.rpvDSM.RefreshReport();
            }
            else
            {
                //this.MONTableAdapter.Fill(this.BangDiem.MON);

                //this.rpvDSM.RefreshReport();
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
    }
}
