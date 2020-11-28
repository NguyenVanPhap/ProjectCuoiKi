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
    class BLSoLuongSVTheoKhoa
    {
        DBMain db = null;
        public BLSoLuongSVTheoKhoa()
        {
            db = new DBMain();
        }
        public DataSet LaySLSVTK()
        {
            string sqlString= "sp_SV_theo_Khoa";
            string[] paramenters = { };
            string[] values = { };
            return db.ExcuteQueryDataSet(sqlString, CommandType.StoredProcedure, paramenters, values);
        }
    }
}
