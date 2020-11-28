using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nhom11_DoAnQuanLySinhVien.DB_Layer;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.Sql;
namespace Nhom11_DoAnQuanLySinhVien.BS_Layer
{
    class BLDangNhap
    {
        DBMain db = null;
        public BLDangNhap()
        {
            db = new DBMain();
        }
        public bool kiemTraThongTinDangNhap(string TenDN, string password, ref string err,string Quyen)
        {
            
            String sqlstring = "sp_Check_Login";
            string[] paramenters = { "@tenDN", "@MatKhau", "@Quyen" };
            string[] values = { TenDN, password, Quyen };
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
