using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketModel
{
    /// <summary>
    /// 销售员类 可序列化
    /// </summary>
    [Serializable]
  
    public class SalesPerson
    {
        /// <summary>
        /// 销售员ID
        /// </summary>
        public int SalesPersonId { get; set; }
        /// <summary>
        /// 销售员姓名
        /// </summary>
        public string  SPName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string  LoginPwd { get; set; }
        /// <summary>
        /// 登录记录序列
        /// </summary>
        public int LogId { get; set; }
    }
}
