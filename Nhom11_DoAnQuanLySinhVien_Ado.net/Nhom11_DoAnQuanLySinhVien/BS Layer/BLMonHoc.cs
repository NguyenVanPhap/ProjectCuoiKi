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
    class BLMonHoc
    {
        DBMain db = null;
        public BLMonHoc()
        {
            db = new DBMain();
        }
        public DataSet LayMonHoc()
        {
            string sqlstring = "sp_LayMonHoc";
            string[] paramenters = { };
            string[] values = { };
            return db.MyExcuteNonQuery(sqlstring, CommandType.StoredProcedure, paramenters, values, ref err);
        }
        public bool ThemMonHoc(string MaMon, string TenMon, string SoTinChi, ref string err)
        {
            //string sqlString = "Insert Into MON Values('" + MaMon + "',N'" +
            //    TenMon + "','" + SoTinChi + "')";
            string sqlstring = "sp_ThemMonHoc";
            string[] paramenters = { "@MaMH, @TenMH, @SoTinChi" };
            string[] values = { MaMon, TenMon, SoTinChi };
            return db.MyExcuteNonQuery(sqlstring, CommandType.StoredProcedure, paramenters, values, ref err);
        }
        public bool XoaMonHoc(string MaMon, ref string err)
        {
            //string sqlString = "Delete From MON Where MaMon='" + MaMon + "'";
            string sqlstring = "Sp_XoaMonHoc";
            string[] paramenters = { "@MaMH " };
            string[] values = { MaMon};
            return db.MyExcuteNonQuery(sqlstring, CommandType.StoredProcedure, paramenters, values, ref err);
        }
        public bool CapNhatMonHoc(string MaMon, string TenMon, string SoTinChi, ref string err)
        {
            //string sqlString = "Update MON Set TenMon=N'" + TenMon +
            //    "', SoTinChi='" + SoTinChi +
            //    "' Where MaMon='" + MaMon + "'";
            string sqlstring = "sp_CapNhatMonHoc";
            string[] paramenters = { "@MaMH, @TenMH, @SoTinChi" };
            string[] values = { MaMon, TenMon, SoTinChi };
            return db.MyExcuteNonQuery(sqlstring, CommandType.StoredProcedure, paramenters, values, ref err);
        }
        public bool KiemTraMaMonTonTai(string MaMon, ref string err)
        {
            string sqlstring = "sp_KiemTraMaMonTonTai";
            string[] paramenters = { "@MaMH" };
            string[] values = { MaMon };
            SqlDataReader reader = db.MyExcuteReader(sqlstring, CommandType.StoredProcedure, paramenters, values);
            if (reader.Read())
            {
                reader.Dispose();
                return true;
            }
            reader.Dispose();
           
            return false;
        }
        public int KiemTraMonHocTonTaiKhac(string MaMon, ref string err)
        {
            //SqlDataReader reader;
            //string selectcommandKQHT = "Select MaMon From KETQUAHOCTAP Where MaMon='" + MaMon + "'";
            // string selectcommandGV = "Select MaMon From GiangVien where MaMon='" + MaMon + "'";// bảng giảng viên đã bỏ
            string sqlstring = "sp_KiemTraMonHocTonTaiKhac ";
            string[] paramenters = { "@MaMH" };
            string[] values = { MaMon };
            SqlDataReader reader = db.MyExcuteReader(sqlstring, CommandType.StoredProcedure, paramenters, values);
            if (reader.Read())
            {
                reader.Dispose();
                return 1;
            }
            reader.Dispose();
            return 2;
        }
    }
}
