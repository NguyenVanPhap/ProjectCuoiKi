using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Nhom11_DoAnQuanLySinhVien.DB_Layer;
using System.Data.SqlTypes;

namespace Nhom11_DoAnQuanLySinhVien.BS_Layer
{
    class BLDoiMatKhau
    {
        DBMain db = null;
        public BLDoiMatKhau()
        {
            db = new DBMain();
        }

        public bool kiemTraThongTinTaiKhoan(string TenDN, string password, ref string err)
        {
            String sqlstring = "sp_Check_Account";
            string[] paramenters = { "@tenDN", "@MatKhau"};
            string[] values = { TenDN, password };
            SqlDataReader reader = db.MyExcuteReader(sqlstring, CommandType.StoredProcedure, paramenters, values);

            if (reader.Read())
            {

                return true;
            }
            reader.Dispose();
            db.myDispose();
            return false;
        }
        public bool Update(string TenDN, string newPassword,ref string err)
        {
            String sqlstring = "sp_update_Pass";
            string[] paramenters = { "@tenDN", "@MatKhau"};
            string[] values = { TenDN,newPassword };

            return db.MyExcuteNonQuery(sqlstring, CommandType.StoredProcedure,paramenters,values,ref err);
            
        }
    }
}
