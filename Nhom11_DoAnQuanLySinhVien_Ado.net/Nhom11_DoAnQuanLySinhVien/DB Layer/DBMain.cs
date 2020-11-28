using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Nhom11_DoAnQuanLySinhVien.DB_Layer
{
    class DBMain
    {
        string connStr = "Data Source=DESKTOP-4ULE13O;Initial Catalog=QuanLyDiemSinhVienDB;Integrated Security=True";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter ada = null;

        public DBMain()
        {
            conn = new SqlConnection(connStr);
            comm = conn.CreateCommand();
        }
        public SqlDataReader MyExcuteReader(string strSQl, CommandType ct,string[] parammenters,string[] values)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQl;
            comm.CommandType = ct;
            for(int i=0;i<parammenters.Length;i++)
            {
                comm.Parameters.Add(new SqlParameter(parammenters[i], values[i]));
            }    
            return comm.ExecuteReader();
        }
        public void myDispose()
        {
            comm.Dispose();
        }
        public DataSet ExcuteQueryDataSet(string strSQl, CommandType ct, string[] parammenters, string[] values)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQl;
            comm.CommandType = ct;
            for (int i = 0; i < parammenters.Length; i++)
            {
                comm.Parameters.Add(new SqlParameter(parammenters[i], values[i]));
            }
            ada = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            ada.Fill(ds);
            return ds;
        }
        public bool MyExcuteNonQuery(string strSQl, CommandType ct, string[] parammenters, string[] values, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQl;
            comm.CommandType = ct;
            for (int i = 0; i < parammenters.Length; i++)
            {
                comm.Parameters.Add(new SqlParameter(parammenters[i], values[i]));
            }
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }

    }
}

