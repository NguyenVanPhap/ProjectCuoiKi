﻿using System;
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
    public partial class ReportDanhSachKhoa : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public ReportDanhSachKhoa()
        {
            InitializeComponent();
        }
        public void ChangelanguagetoEngLish()
        {
            lblKhoa.Text = "Faculty ID:";
        }
        public void ChangeLanguageToVietNamese()
        {
            lblKhoa.Text = "Mã Khoa:";
        }
        private void ReportDanhSachKhoa_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'BangDiem.KHOA' table. You can move, or remove it, as needed.
            //this.KHOATableAdapter.Fill(this.BangDiem.KHOA);

            //this.rpvDSK.RefreshReport();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (this.cbbMaKhoa.Text != "ALL")
            {
                //this.KHOATableAdapter.FillKhoa(this.BangDiem.KHOA, "%" +this.cbbMaKhoa.Text+ "%");

                //this.rpvDSK.RefreshReport();
            }
            else
            {
                //this.KHOATableAdapter.Fill(this.BangDiem.KHOA);

                //this.rpvDSK.RefreshReport();
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
