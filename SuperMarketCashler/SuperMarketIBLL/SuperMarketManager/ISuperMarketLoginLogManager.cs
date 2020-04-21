using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketModel;

namespace SuperMarketIBLL.SuperMarketManager
{
    public interface ISuperMarketLoginLogManager
    {
        /// <summary>
        /// 登录日志
        /// </summary>
        /// <returns></returns>
        List<LoginLogs> GetLoginLog();

        List<LoginLogs> GetLoginLogBy(DateTime starttime, DateTime datetime, string wheres, int check);
    }

}
