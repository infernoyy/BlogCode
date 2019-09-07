//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data;
//using System.Data.SqlClient;
//using System.Configuration;

//namespace DAL.Helper
//{
//    public class SqlHelper
//    {
//        private static readonly string connString = ConfigurationManager.ConnectionStrings["connectionString"].ToString();
//        //执行增删改方法
//        public static int Update(string sql)
//        {
//            SqlConnection conn = new SqlConnection(connString);
//            SqlCommand cmd = new SqlCommand(sql, conn);
//            try
//            {
//                conn.Open();
//                return cmd.ExecuteNonQuery();
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//            finally
//            {
//                conn.Close();
//            }
//        }

//        //执行返回一条记录的方法
//        public static object SelectOne(string sql)
//        {
//            SqlConnection conn = new SqlConnection(connString);
//            SqlCommand cmd = new SqlCommand(sql, conn);
//            try
//            {
//                conn.Open();
//                return cmd.ExecuteScalar();
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//            finally
//            {
//                conn.Close();
//            }
//        }

//        //执行返回多条记录的方法
//        public static SqlDataReader SelectAll(string sql)
//        {
//            SqlConnection conn = new SqlConnection(connString);
//            SqlCommand cmd = new SqlCommand(sql, conn);
//            try
//            {
//                conn.Open();
//                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
//            }
//            catch (Exception ex)
//            {
//                conn.Close();
//                throw ex;
//            }
//        }
//    }
//}
