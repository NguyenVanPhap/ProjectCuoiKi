using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Nhom11_DoAnQuanLySinhVien.DB_Layer;
using System.Data.SqlClient;

namespace Nhom11_DoAnQuanLySinhVien.BS_Layer
{
    class BLKhoa
    {
        DBMain db = null;
        public BLKhoa()
        {
            db = new DBMain();
        }
        public DataSet LayKhoa()
        {
            string sqlstring = "select * from dsKhoa_View";
            string[] paramenters = { };
            string[] values = { };
            return db.ExcuteQueryDataSet(sqlstring, CommandType.Text, paramenters, values);
        }
        public bool ThemKhoa(string MaKhoa, string TenKhoa, ref string err)
        {
            String sqlstring = "sp_Them_Khoa";
            string[] paramenters = { "@MaKhoa", "@TenKhoa" };
            string[] values = { MaKhoa, TenKhoa };

            return db.MyExcuteNonQuery(sqlstring, CommandType.StoredProcedure, paramenters, values, ref err);
        }
        public bool XoaKhoa(string MaKhoa, ref string err)
        {
            String sqlstring = "sp_Xoa_Khoa";
            string[] paramenters = { "@MaKhoa" };
            string[] values = { MaKhoa };

            return db.MyExcuteNonQuery(sqlstring, CommandType.StoredProcedure, paramenters, values, ref err);
        }
        public bool CapNhatKhoa(string MaKhoa, string TenKhoa, ref string err)
        {
            String sqlstring = "sp_CapNhat_Khoa";
            string[] paramenters = { "@MaKhoa", "@TenKhoa" };
            string[] values = { MaKhoa, TenKhoa };

            return db.MyExcuteNonQuery(sqlstring, CommandType.StoredProcedure, paramenters, values, ref err);
        }
        public bool KiemTraMaKhoaTonTai(string MaKhoa)
        {
            string sqlstring = "sp_KiemTraKhoa";
            string[] paramenters = { "@MaKhoa" };
            string[] values = {MaKhoa};
            SqlDataReader reader = db.MyExcuteReader(sqlstring, CommandType.StoredProcedure, paramenters, values);
            if (reader.Read())
            {
                reader.Dispose();
                return true;
            }
            reader.Dispose();
            return false;
        }
        public bool KiemTraMaKhoaTrongLop(string MaKhoa)
        {

            string sqlstring = "sp_KT_MaKhoa_Lop";
            string[] paramenters = { "@MaKhoa" };
            string[] values = { MaKhoa };
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
