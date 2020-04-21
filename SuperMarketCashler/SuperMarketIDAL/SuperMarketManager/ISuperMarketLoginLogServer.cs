using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketModel;

namespace SuperMarketIDAL.SuperMarketManager
{
    public interface ISuperMarketLoginLogServer
    {
        /// <summary>
        /// 登录日志
        /// </summary>
        /// <returns></returns>
        List<LoginLogs> GetLoginLog();

        /// <summary>
        /// 登录时间
        /// </summary>
        /// <param name="starttime"></param>
        /// <param name="dateTime"></param>
        /// <param name="wheres"></param>
        /// <param name="check"></param>
        /// <returns></returns>
        List<LoginLogs> GetLoginLogBy(DateTime starttime, DateTime dateTime, string wheres, int check);
    }
}
