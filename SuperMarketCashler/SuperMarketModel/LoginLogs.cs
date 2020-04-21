using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketModel
{
    /// <summary>
    /// 登录日志
    /// </summary>
    [Serializable]
    //登录日志
    public class LoginLogs
    {
        /// <summary>
        /// 登录序列号
        /// </summary>
        public int LogId { get; set; }
        
        /// <summary>
        /// 登录者ID
        /// </summary>
        public int LoginId { get; set; }
        /// <summary>
        /// 登陆者姓名
        /// </summary>
        public string  SPName { get; set; }
        /// <summary>
        /// 登录服务器名称
        /// </summary>
        public string ServerName { get; set; }
        /// <summary>
        /// 登录时间
        /// </summary>
        public DateTime LoginTime { get; set; }
        /// <summary>
        /// 退出时间
        /// </summary>
        public DateTime? ExitTime { get; set; }
    }
}
