using Nhom11_DoAnQuanLySinhVien.FormControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom11_DoAnQuanLySinhVien
{
    public partial class FrMain : Form
    {
        public string Permission { get; set; }
        private bool Hidden = false;
        public string account;
        
        //SoLuongSinhVienTheoKhoa SLSVTK;
        //DanhGiaNangLuc chart;
        //DoiMatKhau DMK;
        //information inf;
        //FormControl.QuanLyNguoiDung QLND;
       
        QuanLyMonHoc QLMH;
        DiemSinhVien DiemSV;
        //QuanLyKhoa QLK;
        //QuanLyLopHoc QLLH;
        //ThongTinSinhVien TTSV;
        //ThongTinTaiKhoan TTTK;

        int language = 0;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public FrMain()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        private void btndashboard_Click(object sender, EventArgs e)
        {
            tmrMenu.Enabled = true;   
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrMain_Load(object sender, EventArgs e)
        {
            
            //chart = new DanhGiaNangLuc();
            ////THHT = new TinhHinhHocTap();
          
            QLMH = new QuanLyMonHoc();
            DiemSV = new DiemSinhVien();
           // QLK = new QuanLyKhoa();
           // QLLH = new QuanLyLopHoc();
           // TTSV = new ThongTinSinhVien();
           // DMK = new DoiMatKhau(account);
           // TTTK = new ThongTinTaiKhoan(account, DMK);
           // inf = new information();
           // QLND = new QuanLyNguoiDung();
           // SLSVTK = new SoLuongSinhVienTheoKhoa();
           // this.pnlDisplay.Controls.Add(SLSVTK);
           

           //this.pnlDisplay.Controls.Add(QLND);
            
           this.pnlDisplay.Controls.Add(QLMH);
           this.pnlDisplay.Controls.Add(DiemSV);
            //this.pnlDisplay.Controls.Add(QLK);
            //this.pnlDisplay.Controls.Add(QLLH);
            //this.pnlDisplay.Controls.Add(TTSV);
            //this.pnlDisplay.Controls.Add(TTTK);
            //this.pnlDisplay.Controls.Add(inf);
            //this.pnlDisplay.Controls.Add(DMK);
            //this.pnlDisplay.Controls.Add(chart);
            
            //this.SLSVTK.Visible = false;
            //this.chart.Visible = false;
            //this.QLND.Visible = false;
            this.DiemSV.Visible = false;
            
            this.QLMH.Visible = false;
            //this.QLK.Visible = false;
            //this.QLLH.Visible = false;
            //this.TTSV.Visible = false;
            //this.DMK.Visible = false;
            //this.TTTK.Visible = false;
            //this.inf.Visible = false;  
            
            if(Permission=="Sinh Viên"||Permission=="Giảng Viên")
            {
                
                //QLK.UnEnable();
                //QLLH.UnEnable();
                //QLMH.UnEnable();
                //TTSV.UnEnable();
            }   
            if(Permission=="Sinh Viên")
            {
                //DiemSV.UnEnable();
            }    
        }

        private void btnQLdiemSV_Click(object sender, EventArgs e)
        {
            foreach (Control crtl in this.pnlDisplay.Controls)
            {
                crtl.Visible = false;
            }
            
            this.ptbTroVe.Visible = true;
            this.DiemSV.Visible = true;
            this.DiemSV.BringToFront();
        }

       

        private void btnHome_Click(object sender, EventArgs e)
        {
            foreach (Control crtl in this.pnlDisplay.Controls)
            {
                if (crtl is Button)
                {
                    if (crtl.Visible == false)
                        crtl.Visible = true;
                }
                else
                    crtl.Visible = false;
            }
        }

        private void btnQLkhoa_Click(object sender, EventArgs e)
        {
            foreach (Control crtl in this.pnlDisplay.Controls)
            {
                crtl.Visible = false;
            }
            
            this.ptbTroVe.Visible = true;
            //this.QLK.Visible = true;
            //this.QLK.BringToFront();
        }

        private void btnQLlop_Click(object sender, EventArgs e)
        {
            foreach (Control crtl in this.pnlDisplay.Controls)
            {
                crtl.Visible = false;
            }
            
            //this.ptbTroVe.Visible = true;
            //this.QLLH.Visible = true;
            //this.QLLH.BringToFront();

            //this.QLLH.LoadCboMaKhoa();
        }

        private void btnQLSV_Click(object sender, EventArgs e)
        {
            foreach (Control crtl in this.pnlDisplay.Controls)
            {
                crtl.Visible = false;
            }
           
            //this.ptbTroVe.Visible = true;
            //this.TTSV.Visible = true;
            //this.TTSV.BringToFront();

            //this.TTSV.LoadCboMaLop();
            //this.TTSV.LoadCboMaKhoa();
        }

        private void btnQLMH_Click(object sender, EventArgs e)
        {
            //foreach (Control crtl in this.pnlDisplay.Controls)
            //{
            //    crtl.Visible = false;
            //}
            
            this.ptbTroVe.Visible = true;
            this.QLMH.Visible = true;
            this.QLMH.BringToFront();
        }

        

        private void mnLop_Click(object sender, EventArgs e)
        {
            btnQLlop_Click(null, null);
        }

        private void mnMH_Click(object sender, EventArgs e)
        {
            btnQLMH_Click(null, null);
        }

        private void mnKhoa_Click(object sender, EventArgs e)
        {
            btnQLkhoa_Click(null, null);
        }

        private void mnSV_Click(object sender, EventArgs e)
        {
            btnQLSV_Click(null, null);
        }

        private void mnDiemMH_Click(object sender, EventArgs e)
        {
            btnQLdiemSV_Click(null, null);
        }

        private void btnManagre_Click(object sender, EventArgs e)
        {
            if (Permission == "Sinh Viên" || Permission == "Giảng Viên")
            {
                if (language == 0)
                {
                    System.Windows.Forms.MessageBox.Show("Bạn Không được vào chức năng này!", "Warning",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Warning);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("You must not use this function!", "Warning",
                       System.Windows.Forms.MessageBoxButtons.OK,
                       System.Windows.Forms.MessageBoxIcon.Warning);
                }    
            }
            else
            {
                //foreach (Control crtl in this.pnlDisplay.Controls)
                //{
                //    crtl.Visible = false;
                //}
                //this.ptbTroVe.Visible = true;
                //if (Permission == "Sinh Viên" || Permission == "Giảng Viên")
                //{
                //    QLND.UnEnable();
                //}
                //this.QLND.Visible = true;
                //this.QLND.BringToFront();

                //this.QLND.LoadData();
            }
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {            
            frmDangNhap f= new frmDangNhap();
            f.Show();
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control crtl in this.pnlDisplay.Controls)
            {
                crtl.Visible = false;
            }
            this.ptbTroVe.Visible = true;
            //this.inf.Visible = true;
            //this.inf.BringToFront();
        }

        private void mnstrDoiMK_Click(object sender, EventArgs e)
        {
            btnPassword_Click(null, null);
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            foreach (Control crtl in this.pnlDisplay.Controls)
            {
                crtl.Visible = false;
            }
            this.ptbTroVe.Visible = true;
            //this.DMK.Visible = true;
            //this.DMK.BringToFront();
        }

        private void mnstrQuanlinguoidung_Click(object sender, EventArgs e)
        {
            btnManagre_Click(null, null);
        }

        private void mnstrDX_Click(object sender, EventArgs e)
        {
            btnlogout_Click(null, null);
        }

        private void mnstrExit_Click(object sender, EventArgs e)
        {
            btnExit_Click(null, null);
        }

        private void ptbTroVe_Click(object sender, EventArgs e)
        {
            foreach (Control crtl in this.pnlDisplay.Controls)
            {
                crtl.Visible = false;
            }
            ptbTroVe.Visible = false;
            
            btnQLSV.Visible = true;
            btnQLDSV.Visible = true;
            btnQLKhoa.Visible = true;
            btnQLLop.Visible = true;
            btnQLMH.Visible = true;
            btnDGNL.Visible = true;
            
        }

        private void mnstrDSSV_Click(object sender, EventArgs e)
        {
            foreach (Control crtl in this.pnlDisplay.Controls)
            {
                crtl.Visible = false;
            }
            ptbTroVe.Visible = false;
            
            btnQLSV.Visible = true;
            btnQLDSV.Visible = true;
            btnQLKhoa.Visible = true;
            btnQLLop.Visible = true;
            btnQLMH.Visible = true;
            btnDGNL.Visible = true;

            ReportDanhSachSinhVien f = new  ReportDanhSachSinhVien();
            if (language == 0)
                f.ChangeLanguageToVietNamese();
            else
                f.ChangelanguagetoEngLish();
            f.Show();
        }

        private void btnDGNL_Click(object sender, EventArgs e)
        {
            foreach (Control crtl in this.pnlDisplay.Controls)
            {
                crtl.Visible = false;
            }
            
            this.ptbTroVe.Visible = true;
            //this.chart.Visible = true;
            //this.chart.BringToFront();
        }

        private void mnstrDiemTK_Click(object sender, EventArgs e)
        {
            foreach (Control crtl in this.pnlDisplay.Controls)
            {
                crtl.Visible = false;
            }
            ptbTroVe.Visible = false;
           
            btnQLSV.Visible = true;
            btnQLDSV.Visible = true;
            btnQLKhoa.Visible = true;
            btnQLLop.Visible = true;
            btnQLMH.Visible = true;
            btnDGNL.Visible = true;

            FrmTongKet f = new FrmTongKet();
            if (language == 0)
                f.ChangeLanguageToVietNamese();
            else
               f.ChangelanguagetoEngLish();
            f.Show();
        }

        private void TittlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }    
        }

        private void điểmCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control crtl in this.pnlDisplay.Controls)
            {
                crtl.Visible = false;
            }
            ptbTroVe.Visible = false;
            
            btnQLSV.Visible = true;
            btnQLDSV.Visible = true;
            btnQLKhoa.Visible = true;
            btnQLLop.Visible = true;
            btnQLMH.Visible = true;
            btnDGNL.Visible = true;

            BangDiemCaNhan f = new BangDiemCaNhan();
            f.Show();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control crtl in this.pnlDisplay.Controls)
            {
                crtl.Visible = false;
            }
            this.ptbTroVe.Visible = true;
            //this.TTTK.Visible = true;
            //this.TTTK.BringToFront();
        }

        private void tmrMenu_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                pnlSlidebar.Width += 10;
                if (pnlSlidebar.Width >= 175)
                {
                    tmrMenu.Enabled = false;
                    Hidden = false;
                }
            }
            else
            {
                pnlSlidebar.Width -= 10;
                if (pnlSlidebar.Width <= 50)
                {
                    tmrMenu.Enabled = false;
                    Hidden = true;
                }
            }
        }

        private void vietnameseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip.Location = new Point(383, 11);
            pnlPhanCach.Location = new Point(373, 46);
            pnlPhanCach.Size = new Size(590, 1);

            language = 0;
            
            //TTTK.ChangeLanguageToVietNamese();
           
            //TTSV.ChangeLanguageToVietnamese();
            //QLMH.ChangeLanguageToVietNamese();
            //QLLH.ChangeLanguageToVietnamese();
            //QLK.ChangeLanguageToVietNamese();
            //QLND.ChangeLanguageToVietNamese();
            //inf.ChangeLanguageToVietNamese();
            //DiemSV.ChangeLanguageToVietNamese();
            //chart.ChangeLanguageToVietNamese();
            //DMK.ChangeLanguageToVietnamese();
            //SLSVTK.ChangeLanguageToVietNamese();
            btnHome.Text = "      Nhà";
            btnManagre.Text = "       Người dùng";
            btnLogout.Text = "       Đăng xuất";
            btnPassword.Text = "       Mật khẩu";
            btnExit.Text = "      Thoát";

            btnDGNL.Text = "Đánh Giá Năng Lực";
            btnQLMH.Text = "Môn Học";
            
            btnQLKhoa.Text = "Khoa";
            btnQLLop.Text = "Lớp Học";
            btnQLSV.Text = "Sinh Viên";
            btnQLDSV.Text = "Điểm Sinh Viên";

            mnuHeThong.Text = "Hệ Thống";
            mnuDMK.Text = "Đổi mật khẩu";
            mnuQLND.Text = "Quản lý người dùng";
            mnuDX.Text = "Đăng xuất";
            mnuThoat.Text = "Thoát";

            mnuDanhMuc.Text = "Danh Mục";
            mnuKhoa.Text = "Khoa";
            mnuMonHoc.Text = "Môn học";
            mnuLop.Text = "Lớp học";
            mnuGiangVien.Text = "Giảng viên";
            mnuSinhVien.Text = "Sinh viên";
            mnuDSV.Text = "Điểm sinh viên";

            mnuTimKiem.Text = "Tìm Kiếm";
            mnuDCN.Text = "Điểm cá nhân";



            mnuThongKe.Text = "Thống Kê";
            mnuDSK.Text = "Danh sách Khoa";
            mnuDSM.Text = "Danh sách Môn Học";
            mnDSL.Text = "Danh sách Lớp";
            mnuDSSV.Text = "Danh sách SV";
            mnuDiemTK.Text = "Điểm tổng kết của SV";
            mnuDGNL.Text = "Đánh giá năng lực";
            mnuSLGVTM.Text = "Số lượng Giảng Viên theo Môn";
            mnuSLSVTK.Text = "Số lượng Sinh Viên theo Khoa";

            mnuLanguage.Text = "Ngôn ngữ";

            mnuHelp.Text = "Trợ Giúp";
            mnuTTTK.Text = "Thông tin tài khoản";
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip.Location = new Point(415, 11);
            pnlPhanCach.Location = new Point(405, 46);
            pnlPhanCach.Size = new Size(558, 1);

            language = 1;
            btnManagre.Text = "      Manage";
            btnHome.Text = "      Home";
            btnLogout.Text = "      Logout";
            btnPassword.Text = "       Passwork";
            btnExit.Text = "      Exit";
            btnDGNL.Text = "Rated Capacity";
            btnQLDSV.Text = "Scores";
            btnQLKhoa.Text = "Faculty";
            btnQLLop.Text = "Class";
            btnQLMH.Text = "Subjects";
            btnQLSV.Text = "Student";
           

            mnuHeThong.Text = "System";
            mnuDanhMuc.Text = "Manage Category";
            mnuThongKe.Text = "Statistics";
            mnuTimKiem.Text = "Search";
            mnuHelp.Text = "Help";

            mnuDiemTK.Text = "Summary";
            mnuDMK.Text = "Password";
            mnuDSSV.Text = "Student list";
            mnuDX.Text = "Logout";
            mnuThoat.Text = "Exit";
            mnuQLND.Text = "Manage";
            mnuSinhVien.Text = "Student";
            mnuLop.Text = "Class";
            mnuKhoa.Text = "Faculty";
            mnuMonHoc.Text = "Subject";
            mnuGiangVien.Text = "Teacher";
            mnuDGNL.Text = "Rated capacity";
            mnuDSV.Text = "Scores";
            mnuDCN.Text = "Personal scores";

            mnuDSK.Text = "Faculty list";
            mnDSL.Text = "Class list";
            mnuDSM.Text = "Subject list";
            mnuSLSVTK.Text = "Student data by Faculty";
            mnuSLGVTM.Text = "Lecturer data by Subject";

            mnuLanguage.Text = "Language";
            mnuTTTK.Text = "Account information";

            //TTSV.ChangeLanguageToEnglish();
            //QLMH.ChangeLanguageToEngLish();
            //QLLH.ChangeLanguageToEnglish();
            //QLK.ChangeLanguageToEngLish();
          
            //QLND.ChangeLanguageToEngLish();
            //TTTK.ChangeLanguageToEngLish();
            //inf.ChangeLanguageToEngLish();
            //DiemSV.ChangeLanguageToEngLish();
            //chart.ChangeLanguageToEngLish();
            //DMK.ChangeLanguageToEnglish();
            //SLSVTK.ChangelanguagetoEngLish();
        }

        private void danhSáchKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control crtl in this.pnlDisplay.Controls)
            {
                crtl.Visible = false;
            }
            ptbTroVe.Visible = false;
            
            btnQLSV.Visible = true;
            btnQLDSV.Visible = true;
            btnQLKhoa.Visible = true;
            btnQLLop.Visible = true;
            btnQLMH.Visible = true;
            btnDGNL.Visible = true;

            ReportDanhSachKhoa RDSK = new ReportDanhSachKhoa();
            if (language == 0)
                RDSK.ChangeLanguageToVietNamese();
            else
                RDSK.ChangelanguagetoEngLish();
            RDSK.Show();
        }

        private void danhSáchMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control crtl in this.pnlDisplay.Controls)
            {
                crtl.Visible = false;
            }
            ptbTroVe.Visible = false;
            
            btnQLSV.Visible = true;
            btnQLDSV.Visible = true;
            btnQLKhoa.Visible = true;
            btnQLLop.Visible = true;
            btnQLMH.Visible = true;
            btnDGNL.Visible = true;

            ReportDanhSachMon RDSM = new ReportDanhSachMon();
            if (language == 0)
                RDSM.ChangeLanguageToVietNamese();
            else
                RDSM.ChangelanguagetoEngLish();
            RDSM.Show();
        }

        private void danhSáchLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control crtl in this.pnlDisplay.Controls)
            {
                crtl.Visible = false;
            }
            ptbTroVe.Visible = false;
           
            btnQLSV.Visible = true;
            btnQLDSV.Visible = true;
            btnQLKhoa.Visible = true;
            btnQLLop.Visible = true;
            btnQLMH.Visible = true;
            btnDGNL.Visible = true;

            ReportDanhSachLop RDSL = new ReportDanhSachLop();
            if (language == 0)
                RDSL.ChangeLanguageToVietNamese();
            else
                RDSL.ChangelanguagetoEngLish();
            RDSL.Show();
        }

        private void đánhGiáNăngLựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control crtl in this.pnlDisplay.Controls)
            {
                crtl.Visible = false;
            }
            
            this.ptbTroVe.Visible = true;
            //this.chart.Visible = true;
            //this.chart.BringToFront();
        }

        private void sốLiệuSinhViênTheoKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Control crtl in this.pnlDisplay.Controls)
            {
                crtl.Visible = false;
            }
            this.ptbTroVe.Visible = true;
            //this.SLSVTK.Visible = true;
            //this.SLSVTK.BringToFront();
        }

       
    }
}
