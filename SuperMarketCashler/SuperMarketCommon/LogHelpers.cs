using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SuperMarketCommon
{
    public class LogHelpers
    {
        /// <summary>
        /// 一般信息
        /// </summary>
        static log4net.ILog logInfo = log4net.LogManager.GetLogger("Info");
        /// <summary>
        /// 一般错误
        /// </summary>
        static log4net.ILog logError = log4net.LogManager.GetLogger("Error");
        /// <summary>
        /// 警告
        /// </summary>
        static log4net.ILog logWarn = log4net.LogManager.GetLogger("Warn");

        /// <summary>
        /// 写入一般信息
        /// </summary>
        /// <param name="msg"></param>
        public void WriteInfo(string msg)
        {
            logInfo.Info(msg);
        }
        /// <summary>
        /// 一般错误
        /// </summary>
        /// <param name="msg"></param>
        public void WriteError(string msg, Exception ex)
        {
            logError.Error(msg,ex);
        }
        /// <summary>
        /// 警告
        /// </summary>
        /// <param name="msg"></param>
        public void WriteWarn(string msg)
        {
            logWarn.Error(msg);
        }
    }
}
