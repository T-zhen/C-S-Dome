using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketIBLL;
using SuperMarketModel;
using SuperMarketDAL;
using SuperMarketIDAL;
using SuperMarketIBLL.SuperMarketCashier;

namespace SuperMarketBLL.SuperMarketCashier
{
    public class SuperMarketSaleManager : SuperMarketIBLL.SuperMarketCashier.ISuperMarketSaleManager
    {
        SuperMarketIDAL.SuperMarketCashier.ISuperMarketSaleServer saleServer = new SuperMarketDAL.SuperMarketCashier.SuperMarketSaleServer();

     
        /// <summary>
        /// 返回时间
        /// </summary>
        /// <returns></returns>
        public DateTime GetSysTime()
        {
            return saleServer.GetSysTime();
        }
        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public SalesPerson SalesLogin(SalesPerson person)
        {
           return saleServer.SalesLogin(person);
        }

        public bool WriteSalesExitLog(int logid)
        {
            if (saleServer.WriteSalesExitLog(logid) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        ///  写入日志
        /// </summary>
        /// <param name="logs"></param>
        /// <returns></returns>
        public int  WriteSalesLog(LoginLogs logs)
        {
            return saleServer.WriteSalesLog(logs);
        }
    }
}
