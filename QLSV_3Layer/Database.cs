using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_3Layer
{
    public class Database
    {

        //provider connection string=&quot;data source = HUNGKHANH\SQLEXPRESS;initial catalog = QLNHANSU; persist security info=True;user id = saa; password=123456;MultipleActiveResultSets=True
        private String connectionString = @"Data Source=HUNGKHANH\SQLEXPRESS;Initial Catalog=QLSV;persist security info=True;user id = saa; password=123456;Integrated Security=True";
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;
        public Database()
        {

            try
            {
                conn = new SqlConnection(connectionString);
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại  "+ex.Message);
            }
        }
        public DataTable SelectData(string sql,List<CustomParameter> lstPara)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);//nd sql dc truyen vao 
                cmd.CommandType = CommandType.StoredProcedure;//set command type cho cmd
                foreach (var para in lstPara)//gan cac tham so cho cmd
                {
                    cmd.Parameters.AddWithValue(para.key, para.value);
                }
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: "+ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataRow Select(string sql)
        {
            try
            {
                conn.Open();//mo ket noi
                cmd = new SqlCommand(sql,conn);//tryen gia tri vao cmd
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());//thuc thi cau lenh
                return dt.Rows[0];//tra ve ket qua
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load thông tin chi tiết: "+ex.Message);
                return null;
            }
            finally
            {
                conn.Close();//dong ket noi
            }
        }

        public int ExeCute(string sql,List<CustomParameter> lstPara)
        {
            try
            {
                conn.Open();//mo ket noi
                cmd = new SqlCommand(sql, conn);//thuc thi cau lenh sql
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var p in lstPara)//gan cac tham so cho cmd
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                var rs = cmd.ExecuteNonQuery();//lay ket qua thuc thi truy van
                return (int)rs;//tra ve ket qua
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi câu lệnh"+ex.Message);
                return -100;
            }
            finally
            {
                conn.Close();//dong ket noi
            }
        }
    }
}
