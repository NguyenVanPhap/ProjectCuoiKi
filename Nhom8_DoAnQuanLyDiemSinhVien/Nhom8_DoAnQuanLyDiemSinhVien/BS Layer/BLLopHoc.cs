﻿using System;
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
            string sqlstring = "select * from dsLop_View";
            string[] paramenters = { };
            string[] values = { };
            return db.ExcuteQueryDataSet(sqlstring, CommandType.Text, paramenters, values);
        }
        public bool ThemLopHoc(string MaKhoa, string MaLop, string TenLop,string SiSo, ref string err)
        {
            String sqlstring = "sp_ThemLopHoc";
            string[] paramenters = { "@MaLop", "@TenLop", "@MaKhoa" ,"@SiSo"};
            string[] values = { MaLop, TenLop, MaKhoa,SiSo};

            return db.MyExcuteNonQuery(sqlstring, CommandType.StoredProcedure, paramenters, values, ref err);
        }
        public bool XoaLopHoc(string MaLop, ref string err)
        {
            String sqlstring = "sp_XoaLopHoc";
            string[] paramenters = { "@MaLop" };
            string[] values = { MaLop };

            return db.MyExcuteNonQuery(sqlstring, CommandType.StoredProcedure, paramenters, values, ref err);
        }
        public bool CapNhatLopHoc(string MaKhoa, string MaLop, string TenLop, string SiSo, ref string err)
        {
            String sqlstring = "sp_CapNhapLopHoc";
            string[] paramenters = { "@MaLop", "@TenLop", "@MaKhoa", "@SiSo" };
            string[] values = { MaLop, TenLop, MaKhoa ,SiSo};

            return db.MyExcuteNonQuery(sqlstring, CommandType.StoredProcedure, paramenters, values, ref err);

        }

        public List<string> LayMaKhoa()
        {
            List<string> dsMaKhoa = new List<string>();
            String sqlstring = "sp_LayMaKhoa";
            string[] paramenters = { };
            string[] values = { };
            SqlDataReader reader = db.MyExcuteReader(sqlstring, CommandType.StoredProcedure, paramenters, values);

            while (reader.Read())
                dsMaKhoa.Add(reader.GetString(0));
            reader.Dispose();
            return dsMaKhoa;
        }
        public bool kiemTraMaLopTonTai(string MaLop, ref string err)
        {


            String sqlstring = "sp_KiemTraMaLop";
            string[] paramenters = { "@MaLop" };
            string[] values = { MaLop };
            SqlDataReader reader = db.MyExcuteReader(sqlstring, CommandType.Text, paramenters, values);
            if (reader.Read())
            {
                reader.Dispose();
                return true;
            }
            reader.Dispose();
            return false;
        }
        public bool kiemTraMaKhoaChinhXac(string MaKhoa, ref string err)
        {
            string sqlstring = "sp_KiemTraKhoa";
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
        public bool kiemTraSinhVienCoLop(string MaLop, ref string err)
        {
            string sqlstring = "sp_kiemTraSinhVienCoLop";
            string[] paramenters = { "@MaLop" };
            string[] values = { MaLop };
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