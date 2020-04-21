using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace SuperMarketDAL
{
    class SQLHelper
    {
        static string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
       
        
        /// <summary>
        /// 返回受影响行数
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="sp"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string procName, SqlParameter[] sp)
        {
            SqlConnection sqlcon = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;//存储过程
            cmd.CommandText = procName;
            if (sp!=null)
            {
                cmd.Parameters.AddRange(sp);
            }
            try
            {
                sqlcon.Open();
                int res = cmd.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                
                return -1;
            }
            finally
            {
                sqlcon.Close(); 
            }
        }


        /// <summary>
        /// 返回单一结果
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="sp"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string procName, SqlParameter[] sp)
        {
            SqlConnection sqlcon = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;//存储过程
            cmd.CommandText = procName;
            if (sp != null)
            {
                cmd.Parameters.AddRange(sp);
            }
            try
            {
                sqlcon.Open();
                object res = cmd.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                sqlcon.Close();
            }
        }

        /// <summary>
        /// 返回DataReader
        /// </summary>
        /// <param name="procName">存储过程的名字</param>
        /// <param name="sp">存储过程的内容</param>
        /// <returns></returns>
        public static SqlDataReader GetDataReader(string procName, SqlParameter[] sp)
        {
            SqlConnection sqlcon = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlcon;
            cmd.CommandText = procName;
            if (sp != null)
            {
                cmd.Parameters.AddRange(sp);
            }
            try
            {
                sqlcon.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        /// <summary>
        /// 返回一个数据表
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="sp"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string procName, SqlParameter[] sp)
        {
            SqlConnection sqlcon = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;//存储过程
            cmd.Connection = sqlcon;
            cmd.CommandText = procName;
            if (sp != null)
            {
                cmd.Parameters.AddRange(sp);
            }
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                sqlcon.Close();
            }
        }

        /// <summary>
        /// 处理一个事务 对所有的存储过程进行处理
        /// </summary>
        /// <param name="procList">存储过程名称集合</param>
        /// <param name="psList"></param>
        /// <returns></returns>
        internal static bool UpdateByTran(List<string> procList, List<SqlParameter[]> psList)
        {
            SqlConnection sqlcon = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;//存储过程名称
            cmd.Connection = sqlcon;//绑定数据库访问
            try
            {
                sqlcon.Open();
                cmd.Transaction = sqlcon.BeginTransaction();//开启数据事务库

                foreach (string procName in procList)
                {
                    cmd.CommandText = procName;
                    if (psList[procList.IndexOf(procName)] != null)
                    {
                        cmd.Parameters.AddRange(psList[procList.IndexOf(procName)]);
                    }
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();//添加一会清理一次
                }
                cmd.Transaction.Commit();//所有的存储过程执行完毕没有异常则提交
                return true;
            }
            catch (Exception)
            {

                if (cmd.Transaction != null)
                {
                    cmd.Transaction.Rollback();//事务回滚
                }
                return false;
            }
            finally
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction = null;
                }
                sqlcon.Close();
            }
        }
    }
}
