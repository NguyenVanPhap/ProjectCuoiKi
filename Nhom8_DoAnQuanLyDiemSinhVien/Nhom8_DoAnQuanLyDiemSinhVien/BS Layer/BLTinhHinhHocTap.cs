using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nhom11_DoAnQuanLySinhVien.DB_Layer;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Nhom11_DoAnQuanLySinhVien.BS_Layer
{
    class BLTinhHinhHocTap
    {
        DBMain db = new DBMain();
        public BLTinhHinhHocTap()
        {
            db = new DBMain();
        }
        public List<string> LayKhoa()
        {
            List<string> dskhoa = new List<string>();
            String sqlstring = "sp_Lay_Khoa";
            string[] paramenters = { };
            string[] values = { };
            SqlDataReader reader = db.MyExcuteReader(sqlstring, CommandType.StoredProcedure, paramenters, values);
            while (reader.Read())
            {
                dskhoa.Add(reader.GetString(0));
            }
            db.myDispose();
            reader.Dispose();
            return dskhoa;
        }

        public List<string> LayLopTrongKhoa(string maKhoa)
        {
            List<string> dsLop = new List<string>();
            dsLop.Clear();
            String sqlstring = "sp_LayLopTrongKhoa";
            string[] paramenters = { "@MaKhoa" };
            string[] values = { maKhoa };
            SqlDataReader reader = db.MyExcuteReader(sqlstring, CommandType.StoredProcedure, paramenters, values);
            while (reader.Read())
            {
                dsLop.Add(reader.GetString(0));
            }
            db.myDispose();
            reader.Dispose();
            return dsLop;
        }

        //Chưa làm
        public DataSet LayDiemTrungBinhTrongKhoaNamHoc(string Khoa, string NamHoc)
        {

            String sqlstring = "sp_LayDiemTrungBinhTrongKhoaNamHoc";
            string[] paramenters = { "@MaKhoa", "@NamHoc" };
            string[] values = { Khoa,NamHoc};
            return db.ExcuteQueryDataSet(sqlstring, CommandType.StoredProcedure, paramenters, values);

          
        }
    }
}
