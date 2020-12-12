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
            
            String sqlstring = "SELECT dbo.function_KiemTraThongTinTaiKhoan(@tenDN,@MatKhau,@Quyen)";
            string[] paramenters = { "@tenDN", "@MatKhau", "@Quyen" };
            string[] values = { TenDN, password, Quyen };
            string x  = db.MyExecuteScalar(sqlstring, CommandType.Text, paramenters, values);

            if (x == "1")
                return true;
            return false;
        }

      



    }

}
