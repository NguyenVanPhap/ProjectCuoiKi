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
    class BLLopHoc
    {
        DBMain db = null;
        public BLLopHoc()
        {
            db = new DBMain();
        }
        public DataSet LayLopHoc()
        {
            return db.ExcuteQueryDataSet("Select * From LOP", CommandType.Text);
        }
        public bool ThemLopHoc(string MaKhoa, string MaLop, string TenLop, string SiSo, ref string err)
        {
            string sqlString = "Insert Into LOP Values('" + MaKhoa + "','" + MaLop + "',N'" + TenLop + "','"+SiSo+"')";
            return db.MyExcuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaLopHoc(string MaLop, ref string err)
        {
            string sqlString = "Delete From LOP Where MaLop='" + MaLop + "'";
            return db.MyExcuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatLopHoc(string MaKhoa, string MaLop, string TenLop, string SiSo, ref string err)
        {
            string sqlString = "Update LOP Set MaKhoa = '" + MaKhoa + "', TenLop = N'" +
                TenLop +"',SiSo='"+ SiSo +"' Where MaLop = '" + MaLop + "'";
            return db.MyExcuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public List<string> LayMaKhoa()
        {
            List<string> dsMaKhoa = new List<string>();
            String sqlstring = "sp_LayLopHoc";
            string[] paramenters = {};
            string[] values = {};
            SqlDataReader reader = db.MyExcuteReader(sqlstring, CommandType.StoredProcedure, paramenters, values);

            while (reader.Read())
                dsMaKhoa.Add(reader.GetString(0));
            reader.Dispose();
            return dsMaKhoa;
        }
        public bool kiemTraMaLopTonTai(string MaLop, ref string err)
        {


            string selectcommand = "Select * From LOP where MaLop='" + MaLop + "'";
            //SqlDataReader reader = db.MyExcuteReader(selectcommand, CommandType.Text);
            //if (reader.Read())
            //{
            //    reader.Dispose();
            //    return true;
            //}
            //reader.Dispose();
            return false;
        }
        public bool kiemTraMaKhoaChinhXac(string MaKhoa, ref string err)
        {
            string selectcommand = "Select * From Khoa where MaKhoa='" + MaKhoa + "'";
            //SqlDataReader reader = db.MyExcuteReader(selectcommand, CommandType.Text);
            //if (reader.Read())
            //{
            //    reader.Dispose();
            //    return true;
            //}
            //reader.Dispose();
            return false;
        }
        public bool kiemTraSinhVienCoLop(string MaLop, ref string err)
        {
            string selectcommand = "Select MaLop From SINHVIEN where MaLop='" + MaLop + "'";
            //SqlDataReader reader = db.MyExcuteReader(selectcommand, CommandType.Text);
            //if (reader.Read())
            //{
            //    reader.Dispose();
            //    return true;
            //}
            //reader.Dispose();
            return false;
        }
    }
}
