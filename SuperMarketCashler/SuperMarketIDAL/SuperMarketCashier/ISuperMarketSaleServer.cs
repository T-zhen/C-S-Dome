using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketModel;

namespace SuperMarketIDAL.SuperMarketCashier
{
    /// <summary>
    /// 登录接口服务
    /// </summary>
    public interface ISuperMarketSaleServer
    {
        /// <summary>
        /// 使用存储过程登录
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
         SalesPerson SalesLogin(SalesPerson person);
        /// <summary>
        /// 日志写入序号
        /// </summary>
        /// <param name="logid"></param>
        /// <returns></returns>
        int WriteSalesExitLog(int logid);
        /// <summary>
        /// 记录日志
        /// </summary>
        /// <param name="logs"></param>
        /// <returns></returns>
        int WriteSalesLog(LoginLogs logs);

        /// <summary>
        /// 时间流水账号
        /// </summary>
        /// <returns></returns>
        DateTime GetSysTime();

       
    }
}
