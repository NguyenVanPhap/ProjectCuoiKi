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
    class BLThongTinTaiKhoan
    {
        DBMain dbThongTinTaiKhoan = null;
        public BLThongTinTaiKhoan()
        {
            dbThongTinTaiKhoan = new DBMain();
        }
        public DataSet LayThongTinTaiKhoan(string TenDN)
        {
            string sqlString = "sp_LayThongTinTaiKhoan";
            string[] paramenters = { "@TenDangNhap" };
            string[] values = { TenDN};
            return dbThongTinTaiKhoan.ExcuteQueryDataSet(sqlString, CommandType.StoredProcedure, paramenters, values);
        }
    }
}
