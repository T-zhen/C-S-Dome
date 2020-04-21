using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketIDAL;
using SuperMarketModel;
using System.Data;
using System.Data.SqlClient;

namespace SuperMarketDAL.SuperMarketCashier
{
    /// <summary>
    /// 处理收银员管理信息
    /// </summary>
    public class SuperMarketSaleServer : SuperMarketIDAL.SuperMarketCashier.ISuperMarketSaleServer
    {

        public DateTime GetSysTime()
        {
            string procName = "GetSysTime";
            return Convert.ToDateTime(SQLHelper.ExecuteScalar(procName,null));
        }

        /// <summary>
        /// 使用存储过程登录
        /// </summary>
        /// <param name="person">存储过程名称</param>
        /// <returns></returns>
        public SalesPerson SalesLogin(SalesPerson person)
        {
            string procName = "SalesLogIn";
            SqlParameter[] sp =
            {
                new SqlParameter("@LoginId",SqlDbType.Int),
                new SqlParameter("@LoginPwd",SqlDbType.NVarChar,50)
            };
            sp[0].Value = person.SalesPersonId;
            sp[1].Value = person.LoginPwd;
            SqlDataReader reader = SQLHelper.GetDataReader(procName,sp);
            SalesPerson sales = null;
            while (reader.Read())
            {
                sales = new SalesPerson()
                {
                    LoginPwd = reader["LoginPwd"].ToString(),
                    SPName = reader["SPName"].ToString(),
                    SalesPersonId = Convert.ToInt32(reader["SalesPersonId"].ToString())
                };
            }
            reader.Close();
            return sales;
        }

        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="logid"></param>
        /// <returns></returns>
        public int WriteSalesExitLog(int logid)
        {
            string procName = "ExitSysWriteLog";
            SqlParameter[] sp =
            {
                new SqlParameter("@LogId",SqlDbType.Int)

            };
            sp[0].Value = logid;
            return SQLHelper.ExecuteNonQuery(procName,sp);
        }

        /// <summary>
        /// 日志记录返回本次日志的ID号
        /// </summary>
        /// <param name="logs"></param>
        /// <returns></returns>
        public int WriteSalesLog(LoginLogs logs)
        {
            string procName = "WriteLog";
            SqlParameter[] sp =
            {
                new SqlParameter("@LoginId",SqlDbType.Int),
                new SqlParameter("@SPName",SqlDbType.NVarChar,50),
                new SqlParameter("@ServerName",SqlDbType.NVarChar,50)
            };
            sp[0].Value = logs.LoginId;
            sp[1].Value = logs.SPName;
            sp[2].Value = logs.ServerName;
            object res = SQLHelper.ExecuteScalar(procName,sp);
            if (res==null)
            {
                return -1;
            }
            return int.Parse(res.ToString());
        }
    }
}
