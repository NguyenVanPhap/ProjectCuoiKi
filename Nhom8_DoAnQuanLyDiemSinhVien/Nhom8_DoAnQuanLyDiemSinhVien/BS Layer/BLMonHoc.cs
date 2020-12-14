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
            string sqlstring = "select * from dsMon_View";
            string[] paramenters = { };
            string[] values = { };
            return db.ExcuteQueryDataSet(sqlstring, CommandType.Text, paramenters, values);
        }
        public bool ThemMonHoc(string MaMon, string TenMon, string SoTinChi, ref string err)
        {

            string sqlstring = "sp_ThemMonHoc";
            string[] paramenters = { "@MaMH", "@TenMH", "@SoTinChi" };

            
            string[] values = { MaMon, TenMon, SoTinChi };
            return db.MyExcuteNonQuery(sqlstring, CommandType.StoredProcedure, paramenters, values, ref err);
        }
        public bool XoaMonHoc(string MaMon, ref string err)
        {
            string sqlstring = "Sp_XoaMonHoc";
            string[] paramenters = { "@MaMH" };
            string[] values = { MaMon};
            return db.MyExcuteNonQuery(sqlstring, CommandType.StoredProcedure, paramenters, values, ref err);
        }
        public bool CapNhatMonHoc(string MaMon, string TenMon, string SoTinChi, ref string err)
        {
           
            string sqlstring = "sp_CapNhatMonHoc";
            string[] paramenters = { "@MaMH", "@TenMH", "@SoTinChi" };
            string[] values = { MaMon, TenMon, SoTinChi };
            return db.MyExcuteNonQuery(sqlstring, CommandType.StoredProcedure, paramenters, values, ref err);
        }
        public bool KiemTraMaMonTonTai(string MaMon, ref string err)
        {
            String sqlstring = "SELECT  dbo.fn_KiemTraMaMonTonTai(@MaMH)";
            
            string[] paramenters = { "@MaMH" };
            string[] values = { MaMon };
            string x = db.MyExecuteScalar(sqlstring, CommandType.Text, paramenters, values);

            if (x == "1")
                return true;
            return false;
        }
        public int KiemTraMonHocTonTaiKhac(string MaMon, ref string err)
        {
            String sqlstring = "SELECT  dbo.fn_KiemTraMaMonTonTaiTrongKQHT(@MaMH  )";
            string[] paramenters = { "@MaMH" };
            string[] values = { MaMon };
            string x = db.MyExecuteScalar(sqlstring, CommandType.Text, paramenters, values);

            if (x == "1")
                return 1;
            return 2;
        }
    }
}
