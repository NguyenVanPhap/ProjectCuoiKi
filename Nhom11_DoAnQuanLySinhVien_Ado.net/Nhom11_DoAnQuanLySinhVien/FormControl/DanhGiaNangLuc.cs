using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom11_DoAnQuanLySinhVien.BS_Layer;
namespace Nhom11_DoAnQuanLySinhVien.FormControl
{
    public partial class DanhGiaNangLuc : UserControl
    {
        BLTinhHinhHocTap DBTHHT = new BLTinhHinhHocTap();
        DataTable dtTinhHinhHocTap = new DataTable();
        string err;
        public DanhGiaNangLuc()
        {
            InitializeComponent();
        }

        public void ChangeLanguageToEngLish()
        {
            dgvTHHT.Columns[0].Width = 150;
            dgvTHHT.Columns[0].HeaderText = "Student ID";
            dgvTHHT.Columns[1].HeaderText = "Name";
            dgvTHHT.Columns[2].HeaderText = "Average Cumulative";
            dgvTHHT.AutoResizeColumns();

            lblNam.Text = "   Year:";
            lblKhoa.Text = "Faculty:";
            lblBieuDo.Text = "       Annual Learning Situation Chart";
            lblDGNL.Text = "      RATE CAPACITY";
            grbDiemTB.Text = "Average grades";

        }
        public void ChangeLanguageToVietNamese()
        {
            dgvTHHT.Columns[2].Width = 200;

            dgvTHHT.Columns[0].HeaderText = "Mã SV";
            dgvTHHT.Columns[1].HeaderText = "Họ Tên";
            dgvTHHT.Columns[2].HeaderText = "Trung Bình Tích Lũy";

            dgvTHHT.AutoResizeColumns();

            lblNam.Text = "Năm học:";
            lblKhoa.Text = "Khoa:";
            lblBieuDo.Text = "Biểu đồ Tình Hình Học Tập theo năm ";
            lblDGNL.Text = "ĐÁNH GIÁ NĂNG LỰC";
            grbDiemTB.Text = "Điểm trung bình";
        }

        private void Load_Khoa()
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
        private void Load_Data()
        {
            try
            {
                dtTinhHinhHocTap = new DataTable();
                dtTinhHinhHocTap.Clear();
                DataSet ds = DBTHHT.LayDiemTrungBinhTrongKhoaNamHoc(cbbKhoa.Text, cbbNamHoc.Text);
                dtTinhHinhHocTap = ds.Tables[0];
                dgvTHHT.DataSource = dtTinhHinhHocTap;
                dgvTHHT.AutoResizeColumns();
                Load_Khoa();
                FillChart();
            }
            catch
            {
                MessageBox.Show("Không Load được. Lỗi rồi!!!");
            }
        }
        private void Chart_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
        
        private void FillChart()
        {
            int A = 0;
            int Bplus = 0;
            int B = 0;
            int Cplus = 0;
            int C = 0;
            int Dplus = 0;
            int D = 0;
            int F = 0;

            for(int i=0;i<dgvTHHT.Rows.Count-1;i++)
            {
                if (float.Parse(dgvTHHT.Rows[i].Cells[2].Value.ToString()) < 4)
                    F++;
                else
                if (float.Parse(dgvTHHT.Rows[i].Cells[2].Value.ToString()) < 5)
                    D++;
                else
                if (float.Parse(dgvTHHT.Rows[i].Cells[2].Value.ToString()) < 5.5)
                    Dplus++;
                else
                if (float.Parse(dgvTHHT.Rows[i].Cells[2].Value.ToString()) < 6.5)
                    C++;
                else
                if (float.Parse(dgvTHHT.Rows[i].Cells[2].Value.ToString()) < 7)
                    Cplus++;
                else
                if (float.Parse(dgvTHHT.Rows[i].Cells[2].Value.ToString()) < 8)
                    B++;
                else
                if (float.Parse(dgvTHHT.Rows[i].Cells[2].Value.ToString()) < 8.5)
                    Bplus++;
                else
                    A++;
            }
            
            int[] yValues = { A,Bplus,B,Cplus,C,Dplus,D,F };
            string[] xValues = { "A", "B+", "B", "C+","C","D","D+","F"};

            chartTHHT.Series["Grade"].Points.DataBindXY(xValues, yValues);
            chartTHHT.Series[0].Label = "#PERCENT{P2}";
            chartTHHT.Series["Grade"].Label = "#PERCENT";
            chartTHHT.Series[0].LegendText = "#VALX";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Load_Data();
        }
    }
}
