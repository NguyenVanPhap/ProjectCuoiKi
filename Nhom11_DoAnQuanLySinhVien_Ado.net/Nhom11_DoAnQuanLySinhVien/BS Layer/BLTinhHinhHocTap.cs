using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nhom11_DoAnQuanLySinhVien.DB_Layer;
using System.Data;
using System.Data.SqlClient;
namespace Nhom11_DoAnQuanLySinhVien.BS_Layer
{
    class BLTinhHinhHocTap
    {
        DBMain db = new DBMain();
        public BLTinhHinhHocTap()
        {
            db = new DBMain();
        }
        public List<string> LayKhoa()
        {
            List<string> dskhoa = new List<string>();
            String sqlstring = "sp_Lay_Khoa";
            string[] paramenters = { };
            string[] values = { };
            SqlDataReader reader = db.MyExcuteReader(sqlstring, CommandType.StoredProcedure, paramenters, values);
            while (reader.Read())
            {
                dskhoa.Add(reader.GetString(0));
            }
            db.myDispose();
            reader.Dispose();
            return dskhoa;
        }

        public List<string> LayLopTrongKhoa(string maKhoa)
        {
            List<string> dsLop = new List<string>();
            dsLop.Clear();
            String sqlstring = "sp_LayLopTrongKhoa";
            string[] paramenters = { "@MaKhoa" };
            string[] values = { maKhoa };
            SqlDataReader reader = db.MyExcuteReader(sqlstring, CommandType.StoredProcedure, paramenters, values);
            while (reader.Read())
            {
                dsLop.Add(reader.GetString(0));
            }
            db.myDispose();
            reader.Dispose();
            return dsLop;
        }

        //Chưa làm
        public DataSet LayDiemTrungBinhTrongKhoaNamHoc(string Khoa, string NamHoc)
        {
            
            string Sqlstring = "SELECT KQHT.MASV,SV.HoTen,ROUND(SUM(KQHT.DiemTongKet * mn.SoTinChi) / SUM(mn.SoTinChi),2)AS 'TrungBinhTichLuy' FROM dbo.KETQUAHOCTAP AS KQHT" +
                " INNER JOIN dbo.SINHVIEN AS SV ON SV.MaSv = KQHT.MASV" +
                " INNER JOIN dbo.LOP AS lp ON lp.MaLop = SV.MaLop" +
                " INNER JOIN dbo.KHOA AS KH ON KH.MaKhoa = lp.MaKhoa" +
                " INNER JOIN dbo.MON AS mn ON mn.MaMon = KQHT.MaMon" +
                " GROUP BY KQHT.MASV,SV.HoTen ";
            if (Khoa == "ALL")
            {
                if (NamHoc != "ALL")
                {
                    Sqlstring = "SELECT KQHT.MASV,SV.HoTen,ROUND(SUM(KQHT.DiemTongKet * mn.SoTinChi) / SUM(mn.SoTinChi),2) AS 'TrungBinhTichLuy' FROM dbo.KETQUAHOCTAP AS KQHT" +
                 " INNER JOIN dbo.SINHVIEN AS SV ON SV.MaSv = KQHT.MASV" +
                 " INNER JOIN dbo.LOP AS lp ON lp.MaLop = SV.MaLop" +
                 " INNER JOIN dbo.KHOA AS KH ON KH.MaKhoa = lp.MaKhoa" +
                 " INNER JOIN dbo.MON AS mn ON mn.MaMon = KQHT.MaMon WHERE KQHT.NamHoc= "+NamHoc+
                 " GROUP BY KQHT.MASV,SV.HoTen ";
                }
            }
            else
            {
                if (NamHoc == "ALL")
                {
                    Sqlstring = "SELECT KQHT.MASV,SV.HoTen,ROUND(SUM(KQHT.DiemTongKet * mn.SoTinChi) / SUM(mn.SoTinChi),2)AS 'TrungBinhTichLuy' FROM dbo.KETQUAHOCTAP AS KQHT" +
                " INNER JOIN dbo.SINHVIEN AS SV ON SV.MaSv = KQHT.MASV" +
                " INNER JOIN dbo.LOP AS lp ON lp.MaLop = SV.MaLop" +
                " INNER JOIN dbo.KHOA AS KH ON KH.MaKhoa = lp.MaKhoa" +
                " INNER JOIN dbo.MON AS mn ON mn.MaMon = KQHT.MaMon WHERE KH.MaKhoa ='" + Khoa + "' " +
                " GROUP BY KQHT.MASV,SV.HoTen ";
                }
                else
                { 
                    Sqlstring = "SELECT KQHT.MASV,SV.HoTen,ROUND(SUM(KQHT.DiemTongKet * mn.SoTinChi) / SUM(mn.SoTinChi),2)AS 'TrungBinhTichLuy' FROM dbo.KETQUAHOCTAP AS KQHT" +
                 " INNER JOIN dbo.SINHVIEN AS SV ON SV.MaSv = KQHT.MASV" +
                 " INNER JOIN dbo.LOP AS lp ON lp.MaLop = SV.MaLop" +
                 " INNER JOIN dbo.KHOA AS KH ON KH.MaKhoa = lp.MaKhoa" +
                 " INNER JOIN dbo.MON AS mn ON mn.MaMon = KQHT.MaMon WHERE KQHT.NamHoc = " + NamHoc + " and KH.MaKhoa ='" + Khoa + "' " +
                 " GROUP BY KQHT.MASV,SV.HoTen ";
                }

            }

            return db.ExcuteQueryDataSet(Sqlstring, System.Data.CommandType.Text);
        }
    }
}
