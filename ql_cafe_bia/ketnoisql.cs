using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ql_cafe_bia
{
    static class ketnoisql
    {
        // Chuỗi kết nối đến cơ sở dữ liệu SQL Server
        private static string str = @"Data Source=LAPTOP-D90-DOXU\SQLEXPRESS;Initial Catalog=CAFE_AND_BIDA;Integrated Security=True";

        // cách 1 chưa tối ưu hóa
        //phương thức tạo kết nối 

        //public static SqlConnection taoketnoi()
        //{
        //    return new SqlConnection(str);
        //}
        //// phương thức lấy dữ liệu 
        //public static DataTable GetDataTable(string sql)
        //{
        //    SqlConnection duongdan = taoketnoi();
        //    duongdan.Open();
        //    SqlDataAdapter laydata = new SqlDataAdapter(sql, duongdan);
        //    DataTable thungchua_data = new DataTable();
        //    laydata.Fill(thungchua_data);
        //    duongdan.Close();
        //    laydata.Dispose();
        //    return thungchua_data;
        //}
        //////// phương thức thêm sửa xóa 
        //public static void themsuaxoa(string sql)
        //{
        //    SqlConnection duongdan = taoketnoi();
        //    duongdan.Open();
        //    SqlCommand cmd = new SqlCommand(sql,duongdan);
        //    cmd.ExecuteNonQuery();
        //    duongdan.Close() ;
        //  cmd.Dispose();
        //}



        ////c2 tối ưu hóa 
        // Phương thức tạo kết nối
        public static SqlConnection TaoKetNoi()
        {
            return new SqlConnection(str);
        }

        // Phương thức lấy dữ liệu
        public static DataTable GetDataTable(string sql)
        {
            using (SqlConnection duongdan = TaoKetNoi())
            {
                duongdan.Open();
                using (SqlDataAdapter laydata = new SqlDataAdapter(sql, duongdan))
                {
                    DataTable thungchua_data = new DataTable();
                    laydata.Fill(thungchua_data);
                    return thungchua_data;
               }
            }
        }

        // Phương thức thực thi câu lệnh không trả về dữ liệu (thêm, sửa, xóa)
        public static void ThucThiCauLenhthemsuaxoa(string sql)
        {
            using (SqlConnection duongdan = TaoKetNoi())
            {
                duongdan.Open();
                using (SqlCommand cmd = new SqlCommand(sql, duongdan))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        // phương thức lấy ra một giá trị
        public static string GetaValue(string sql)
        {
            SqlConnection con = TaoKetNoi();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            object kq = cmd.ExecuteScalar();
            con.Close();
            cmd.Dispose();
            if (kq == null)
                return "";
            else
                return kq.ToString();

        }
        public static string GetaValue(string sql, string parameterName, object parameterValue)
        {
            using (SqlConnection con = TaoKetNoi())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    // Thêm tham số vào câu truy vấn
                    cmd.Parameters.AddWithValue(parameterName, parameterValue);

                    // Thực thi câu truy vấn và trả về giá trị
                    object result = cmd.ExecuteScalar();
                    return result != null ? result.ToString() : "";
                }
            }
        }

        // Phương thức lấy ra một danh sách
        public static ArrayList GetList(string sql)
        {
            ArrayList kq = new ArrayList();
            DataTable tb = GetDataTable(sql);
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                string key = tb.Rows[i][0].ToString();
                if (kq.IndexOf(key) < 0)// điều kiện chỉ lấy ra giá trị 1 lần không lập lại
                    kq.Add(tb.Rows[i][0].ToString());
            }
            return kq;
        }


    }

}
