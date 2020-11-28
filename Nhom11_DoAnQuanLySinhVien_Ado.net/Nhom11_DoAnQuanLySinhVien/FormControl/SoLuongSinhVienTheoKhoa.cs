using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Nhom11_DoAnQuanLySinhVien.BS_Layer;

namespace Nhom11_DoAnQuanLySinhVien.FormControl
{
    public partial class SoLuongSinhVienTheoKhoa : UserControl
    {
        DataTable dtSLSVTK = null;
        string err;
        BLSoLuongSVTheoKhoa dbSLSVTK = new BLSoLuongSVTheoKhoa();

        public SoLuongSinhVienTheoKhoa()
        {
            InitializeComponent();
        }
        public void ChangelanguagetoEngLish()
        {
            lbltittle.Text = "NUMBER OF STUDENT BY DEPARTMENT CHART";
            lblBDSVTK.Text = "Number of Students by Faculties chart";
        }
        public void ChangeLanguageToVietNamese()
        {
            lbltittle.Text = "    BIỂU ĐỒ SỐ LƯỢNG SINH VIÊN THEO KHOA";
            lblBDSVTK.Text = "Biểu đồ số lượng Sinh Viên theo Khoa";
        }
        private void SoLuongSinhVienTheoKhoa_Load(object sender, EventArgs e)
        {
            dtSLSVTK = new DataTable();
            dtSLSVTK.Clear();

            DataSet ds = dbSLSVTK.LaySLSVTK();
            dtSLSVTK = ds.Tables[0];

            foreach (DataRow row in dtSLSVTK.Rows)
            {
                chartSVTK.Series["Số SV"].Points.AddXY(row["TenKhoa"].ToString(),Convert.ToInt32(row["SoSinhVien"]));
            }
        }
        

        private void chartSVTK_Click(object sender, EventArgs e)
        {

        }
    }
}
