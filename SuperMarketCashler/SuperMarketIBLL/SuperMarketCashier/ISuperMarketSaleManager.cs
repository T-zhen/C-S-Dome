using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketModel;

namespace SuperMarketIBLL.SuperMarketCashier
{
    public interface ISuperMarketSaleManager
    {
        //接口
        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
         SalesPerson SalesLogin(SalesPerson person);
        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="logs"></param>
        /// <returns></returns>
        int WriteSalesLog(LoginLogs logs);

        bool WriteSalesExitLog(int logid);
        /// <summary>
        /// 返回时间
        /// </summary>
        /// <returns></returns>
        DateTime GetSysTime();

      

    }
}
