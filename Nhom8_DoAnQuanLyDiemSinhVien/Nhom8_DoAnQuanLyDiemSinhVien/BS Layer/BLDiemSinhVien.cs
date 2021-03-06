﻿using Nhom11_DoAnQuanLySinhVien.DB_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Nhom11_DoAnQuanLySinhVien.BS_Layer
{
    class BLDiemSinhVien
    {
        DBMain db = null;
        public BLDiemSinhVien()
        {
            db = new DBMain();
        }
        public List<string> LayMonHoc()
        {
            List<string> dsMon = new List<string>();
            dsMon.Clear();
           
            String sqlstring = "sp_layMonHoc";
            string[] paramenters = {};
            string[] values = {};
            SqlDataReader reader = db.MyExcuteReader(sqlstring, CommandType.StoredProcedure, paramenters, values);


            dsMon.Add("ALL");
            while (reader.Read())
            {
                dsMon.Add(reader.GetString(0));
            }
            db.myDispose();
            reader.Dispose();
            return dsMon;
        }
        
        public bool kiemTraThongTinSinhVien(string MaSV, string MaMon, string HK, string NamHoc)
        {
            String sqlstring = "Check_SV_inf";
            string[] paramenters = {"@Masv","@MaMH","@HocKi","@NamHoc"};
            string[] values = {MaSV,MaMon,HK,NamHoc};
            SqlDataReader reader = db.MyExcuteReader(sqlstring, CommandType.StoredProcedure, paramenters, values);
        
            if (reader.Read())
            {
                return true;
            }
            return false;
        }
        public List<string> LayKhoa()
        {
            List<string> dskhoa = new List<string>();
            String sqlstring = "sp_Lay_Ma_Khoa";
            string[] paramenters = {};
            string[] values = {};


            SqlDataReader reader = db.MyExcuteReader(sqlstring, CommandType.StoredProcedure, paramenters, values);
            while (reader.Read())
            {
                dskhoa.Add(reader.GetString(0));

            }
            db.myDispose();
            reader.Dispose();
            return dskhoa;
        }
        public List<string> LayMaSinhVien()
        {
            List<string> dssv = new List<string>();
            
            String sqlstring = "sp_LayMaSinhVien_Diem";
            string[] paramenters = {};
            string[] values = {};
            SqlDataReader reader = db.MyExcuteReader(sqlstring, CommandType.StoredProcedure, paramenters, values);
            while (reader.Read())
            {
                dssv.Add(reader.GetString(0));

            }
            db.myDispose();
            reader.Dispose();
            return dssv;
        }

        public string LayMaKhoa_SinhVien(string masv)
        {
            string makhoa = "CNTT";
            string sqlstring = "sp_Lay_Khoa_SinhVien";
            string[] paramenters = { "@MaSV" };
            string[] values = { masv };
            SqlDataReader reader = db.MyExcuteReader(sqlstring, CommandType.StoredProcedure, paramenters, values);
            while (reader.Read())
            {
                 makhoa= reader.GetString(0);
            }
            db.myDispose();
            reader.Dispose();
            return makhoa;
        }
        public string DiemCaNhan(string masv)
        {
            string KQHTCN = "";
           
            return KQHTCN;
            
        }
        public List<string> LayTenSinhVien(string masv)
        {
            List<string> dssv = new List<string>();

            String sqlstring = "sp_LayTenSinhVien";
            string[] paramenters = {"@Masv"};
            string[] values = {masv};
            SqlDataReader reader = db.MyExcuteReader(sqlstring, CommandType.StoredProcedure, paramenters, values);
            while (reader.Read())
            {
                dssv.Add(reader.GetString(0));

            }
            db.myDispose();
            reader.Dispose();
            return dssv;
        }

        public List<string> LayLopTrongKhoa(string maKhoa)
        {
            List<string> dsLop = new List<string>();
            dsLop.Clear();
            string sqlstring = "sp_LayMonHoc_Diem";
            string[] paramenters = {};
            string[] values = {};

            if (maKhoa != "ALL")
            {
                sqlstring = "sp_LayLopTrongKhoa";
                paramenters = new string[]{"@MaKhoa"};
                values = new string[]{ maKhoa };
            }
           
            SqlDataReader reader = db.MyExcuteReader(sqlstring, CommandType.StoredProcedure, paramenters, values);
            dsLop.Add("ALL");
            while (reader.Read())
            {
                dsLop.Add(reader.GetString(0));
            }
            db.myDispose();
            reader.Dispose();
            return dsLop;
        }
        public int laymahocki(string namhoc, string hocki)
        {
            int mahocki=1;
            string sqlstring = "sp_LayMaHocKi"; 
            string[] paramenters = { "@Hocki" ,"@namhoc"};
            string[] values = {namhoc,hocki};
            SqlDataReader reader = db.MyExcuteReader(sqlstring, CommandType.StoredProcedure, paramenters, values);
            while (reader.Read())
            {
                mahocki=reader.GetInt32(0);
            }
            db.myDispose();
            reader.Dispose();
            return mahocki;
        }
        public DataSet LayDiemSinhVien()
        {
            string[] paramenters = { };
            string[] values = { };
            string sqlstring= "select * from dsDiemSV_View";
            return db.ExcuteQueryDataSet(sqlstring, System.Data.CommandType.Text,paramenters,values);
        }
        

        public DataSet LayDiemTheoKhoaLopHocKiMon(string MaKhoa, string Malop, string HK, string Mon, string NamHoc)
        {
            string[] paramenters = { "@MaKhoa","@Lop","@mon","@HocKi","NamHoc"};
            string[] values = { MaKhoa,Malop,Mon,HK,NamHoc};
            string SqlString = "sp_LayDiemSinhVien";
            return db.ExcuteQueryDataSet(SqlString, System.Data.CommandType.StoredProcedure,paramenters,values);

        }
        public bool ThemDiemSinhVien(string MaSV ,string MaMH ,
                       string hocki ,
                       string namhoc,
                       string DiemChuyenCan ,
                       string DiemGiuaKi ,
                       string DiemBaiTap ,
                       string DiemThiLan1 ,
                       string DiemThiLan2 ,
                       string DiemTongKet, ref string err)
        {

            string MaHocKi = laymahocki(hocki, namhoc).ToString();
            if (DiemThiLan1 == "")
                DiemThiLan1 = "0";
            if (DiemThiLan2 == "")
                DiemThiLan2 = "0";
                
            string sqlstring = "sp_insDIEM";
            string[] paramenters = {  "@MaSV","@MaMH", "@MaHK","@DiemChuyenCan","@DiemGiuaKi","@DiemBaiTap","@DiemLan1", "@DiemLan2","@DiemTongKet" };
            string[] values = {MaSV ,
                       MaMH ,
                       MaHocKi ,
                       DiemChuyenCan ,
                       DiemGiuaKi ,
                       DiemBaiTap ,
                       DiemThiLan1 ,
                       DiemThiLan2 ,
                       DiemTongKet };
            return db.MyExcuteNonQuery(sqlstring, CommandType.StoredProcedure, paramenters, values, ref err);
        }
        public bool CapNhatDiemHocTap(string MaSV, string MaMH, string HocKi,string namhoc,string DiemChuyenCan,string DiemGiuaKi,string DiemBaiTap, string DiemThiLan1,string DiemThiLan2, string DiemTongKet, ref string err)
        { 
            if (DiemThiLan1 == "")
                DiemThiLan1 = "0";
            if (DiemThiLan2 == "")
                DiemThiLan2 = "0";
           
            string MaHocKi = laymahocki(HocKi, namhoc).ToString();
            string sqlstring = "sp_updateDIEM";
            string[] paramenters = { "@MaSV", "@MaMH", "@MaHK", "@DiemChuyenCan", "@DiemGiuaKi", "@DiemBaiTap", "@DiemLan1", "@DiemLan2", "@DiemTongKet" };
            string[] values = {MaSV , MaMH ,MaHocKi ,DiemChuyenCan , DiemGiuaKi , DiemBaiTap , DiemThiLan1 ,DiemThiLan2 , DiemTongKet };
            return db.MyExcuteNonQuery(sqlstring, CommandType.StoredProcedure, paramenters, values, ref err);
        }
        public bool XoaDiemHocTap(string masv, string MaMon, string HocKi,string NamHoc ,ref string err)
        {
            string MaHocKi = laymahocki(HocKi, NamHoc).ToString();
            String sqlstring = "sp_del_DIEM";
            string[] paramenters = {  "@MASV","@MaMH","@MaHK"  };
            string[] values = {masv,MaMon,MaHocKi };
            return db.MyExcuteNonQuery(sqlstring, CommandType.StoredProcedure, paramenters, values, ref err);
        }
    }
}
