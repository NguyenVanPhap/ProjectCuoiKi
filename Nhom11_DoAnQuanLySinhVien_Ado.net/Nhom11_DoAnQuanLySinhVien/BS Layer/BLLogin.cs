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
    class BLLogin
    {
        DBMain db = null;
        public BLLogin()
        {
            db = new DBMain();
        }
        public DataSet LayLogin()
        {
            string sqlstring = "sp_LayTK";
            string[] paramenters = { };
            string[] values = { };
            return db.ExcuteQueryDataSet(sqlstring, CommandType.StoredProcedure, paramenters, values);

        }
        public bool ThemLogin(string TenDN, string MatKhau, string Phone, string Email, string Quyen, ref string err)
        {
            String sqlstring = "sp_ThemTK";
            string[] paramenters = { "@TenDangNhap", "@MatKhau", "@Email", "@SoDienThoai", "@Quyen" };
            string[] values = { TenDN, MatKhau, Email, Phone, Quyen };

            return db.MyExcuteNonQuery(sqlstring, CommandType.StoredProcedure, paramenters, values, ref err);
        }
        public bool XoaLogin(string TenDN, ref string err)
        {
            String sqlstring = "sp_XoaTK";
            string[] paramenters = { "@TenDangNhap" };
            string[] values = { TenDN };

            return db.MyExcuteNonQuery(sqlstring, CommandType.StoredProcedure, paramenters, values, ref err);
        }
        public bool CapNhatLogin(string TenDN, string MatKhau,string Phone, string Email, string Quyen, ref string err)
        {
            String sqlstring = "sp_CapNhatTK";
            string[] paramenters = { "@TenDangNhap", "@MatKhau", "@Email", "@SoDienThoai", "@Quyen" };
            string[] values = { TenDN, MatKhau, Email, Phone, Quyen };

            return db.MyExcuteNonQuery(sqlstring, CommandType.StoredProcedure, paramenters, values, ref err);
        }
        public bool KiemTraTaiKhoanTonTai(string TenDN, ref string err)
        {
            string sqlstring = "sp_KiemTraTKTonTai";
            string[] paramenters = { "@TenDangNhap" };
            string[] values = { TenDN };
            SqlDataReader reader = db.MyExcuteReader(sqlstring, CommandType.StoredProcedure, paramenters, values);
            if (reader.Read())
            {
                reader.Dispose();
                return true;
            }
            reader.Dispose();
            return false;
        }
    }
}
