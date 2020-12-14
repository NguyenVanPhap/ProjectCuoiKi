using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Nhom11_DoAnQuanLySinhVien.DB_Layer;

namespace Nhom11_DoAnQuanLySinhVien.BS_Layer
{
    class BLSinhVien
    {
        DBMain db = null;
        public BLSinhVien()
        {
            db = new DBMain();
        }
        public DataSet LaySinhVien()
        {
            string sqlstring = "select * from dsSV_View";
            string[] paramenters = {};
            string[] values = { };
            return db.ExcuteQueryDataSet(sqlstring, CommandType.Text, paramenters, values);
           
        }
        public bool ThemSinhVien(string MaSv, string HoTen, string NgaySinh, string GioiTinh, string DiaChi, string MaLop, ref string err)
        {
            //string sqlString = "Insert Into SINHVIEN Values('" + MaSv +
            //    "',N'" + HoTen + "','" + NgaySinh + "',N'" + GioiTinh + "',N'" +
            //    DiaChi + "','" + MaLop + "')";
            string sqlstring = "sp_ThemSinhVien";
            string[] paramenters = { "@MaSV" , "@TenSV", "@NgaySinh", "@GioiTinh", "@QueQuan", "@MaLop" };
            string[] values = { MaSv, HoTen, NgaySinh, GioiTinh, DiaChi, MaLop };
            return db.MyExcuteNonQuery(sqlstring, CommandType.StoredProcedure, paramenters, values, ref err);
        }
        public bool XoaSinhVien(string MaSv, ref string err)
        {
            
            string sqlstring = "sp_XoaSinhVien";
            string[] paramenters = { "@MaSV " };
            string[] values = { MaSv };
            return db.MyExcuteNonQuery(sqlstring, CommandType.StoredProcedure, paramenters, values, ref err);
        }
        public bool CapNhatSinhVien(string MaSv, string HoTen, string NgaySinh, string GioiTinh, string DiaChi, string MaLop, ref string err)
        {
            
            string sqlstring = "sp_CapNhatSinhVien";
            string[] paramenters = { "@MaSV" , "@TenSV", "@NgaySinh", "@GioiTinh", "@QueQuan", "@MaLop" };
            string[] values = { MaSv, HoTen, NgaySinh, GioiTinh, DiaChi, MaLop };
            return db.MyExcuteNonQuery(sqlstring, CommandType.StoredProcedure, paramenters, values, ref err);
        }
        public List<string> LayMaLop()
        {
            List<string> dsMaLop = new List<string>();
            String sqlstring = "sp_LayMaLop";
            string[] paramenters = { };
            string[] values = { };
            SqlDataReader reader = db.MyExcuteReader(sqlstring, CommandType.StoredProcedure, paramenters, values);
            while (reader.Read())
            {
                dsMaLop.Add(reader.GetString(0));

            }
            db.myDispose();
            reader.Dispose();
            return dsMaLop;
        }
        public List<string> LayMaKhoa()
        {
            List<string> dsMaKhoa = new List<string>();
            String sqlstring = "sp_LayMaKhoa";
            string[] paramenters = { };
            string[] values = { };
            SqlDataReader reader = db.MyExcuteReader(sqlstring, CommandType.StoredProcedure, paramenters, values);
            while (reader.Read())
            {
                dsMaKhoa.Add(reader.GetString(0));
            }
            db.myDispose();
            reader.Dispose();
            return dsMaKhoa;
        }
        public List<string> LayMaLopTimKiem(string MaKhoa)
        {
            
            List<string> dsMaLopTimKiem = new List<string>();
            string sqlstring = "sp_LayMaLopTuKhoa";
            string[] paramenters = { "@MaKhoa" };
            string[] values = { MaKhoa };
            SqlDataReader reader = db.MyExcuteReader(sqlstring, CommandType.StoredProcedure, paramenters, values);
            while (reader.Read())
            {
                dsMaLopTimKiem.Add(reader.GetString(0));
            }
            db.myDispose();
            reader.Dispose();
            return dsMaLopTimKiem;
        }
        public DataSet LaySinhVienTimKiem(string MaKhoa, string MaLop)
        {
            string sqlstring = null;
            string[] paramenters = { };
            string[] values = { };

            if (MaKhoa == "ALL" && MaLop == "ALL")
                sqlstring = "sp_LayDanhSachsinhvien";
            else
            if (MaKhoa != "ALL" && MaLop == "ALL")
            {
                sqlstring = "sp_LaySinhVien_Khoa";
                paramenters= new string[] { "@khoa" };
                values = new string[] { MaKhoa };

            }
            else if (MaKhoa != "ALL" && MaLop != "ALL")
            {
                sqlstring = "sp_Lay_SinhVien_Lop_Khoa";
                paramenters = new string[] { "@MaKhoa", "@Malop" };
                values = new string[] { MaKhoa, MaLop };
            }

            return db.ExcuteQueryDataSet(sqlstring, CommandType.StoredProcedure, paramenters, values);

        }
        public bool KiemTraSinhVienTonTai(string MaSV)
        {
            String sqlstring = "SELECT  dbo.fn_KiemTraSinhVienTonTai(@MaSV)";
            string[] paramenters = { "@MaSV" };
            string[] values = { MaSV };
            string x = db.MyExecuteScalar(sqlstring, CommandType.Text, paramenters, values);
            if (x == "1")
                return true;
            return false;
        }

        public bool KiemTraSinhVienTonTaiKhac(string MaSv)
        {
            String sqlstring = "SELECT  dbo.fn_KiemTraSinhVienTonTaiTrongKQHT(@MaSV)";
            string[] paramenters = { "@MaSV" };
            string[] values = { MaSv };
            string x = db.MyExecuteScalar(sqlstring, CommandType.Text, paramenters, values);
            if (x == "1")
                return true;
            return false;
        }

        public bool KiemTraMaLop(string MaLop)
        {
            String sqlstring = "SELECT dbo.fn_KiemTraMaLop(@MaLop)";
            string[] paramenters = { "@MaLop" };
            string[] values = { MaLop };
            string x = db.MyExecuteScalar(sqlstring, CommandType.Text, paramenters, values);

            if (x == "1")
                return true;
            return false;
        }
    }
}
