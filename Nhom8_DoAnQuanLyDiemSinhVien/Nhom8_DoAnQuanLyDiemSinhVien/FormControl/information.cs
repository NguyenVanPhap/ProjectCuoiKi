using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom11_DoAnQuanLySinhVien.FormControl
{
    public partial class information : UserControl
    {
        public information()
        {
            InitializeComponent();
        }
        public void ChangeLanguageToEngLish()
        {
            lblGVHD.Text = "Instructor:";
            lbltitle.Text = "   STUDENT MANAGEMENT SYSTEM PROGRAM";
            lblSVTH.Text = "Performer:";
        }
        public void ChangeLanguageToVietNamese()
        {
            lblGVHD.Text = "Giảng viên hướng dẫn:";
            lbltitle.Text = "             CHƯƠNG TRÌNH QUẢN LÝ SINH VIÊN";
            lblSVTH.Text = "Nhóm sinh viên thực hiện:";

        }

        private void information_Load(object sender, EventArgs e)
        {

        }

        private void lblname1_Click(object sender, EventArgs e)
        {

        }
    }
}
