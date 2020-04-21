using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketModel
{
    /// <summary>
    /// 管理员表
    /// </summary>
    public class SysAdmins
    {
        /// <summary>
        /// 登录账号
        /// </summary>
        public int LoginId { get; set; }
      
        /// <summary>
        /// 管理员姓名
        /// </summary>
        public string AdminName { get; set; }
        /// <summary>
        /// 管理员登录密码
        /// </summary>
        public string LoginPwd { get; set; }
        /// <summary>
        /// 用户账号状态
        /// </summary>
        public int AdminStatus { get; set; }
        /// <summary>
        /// 管理员等级
        /// </summary>
        public int RoleId { get; set; }


        //扩展属性
        /// <summary>
        /// 管理员等级序号
        /// </summary>
        public string StatusName { get; set; }
        /// <summary>
        /// 管理员等级名称
        /// </summary>
        public string RoleName { get; set; }
        /// <summary>
        /// 管理员登录时间与退出时间
        /// </summary>
        public int LoginLogId { get; set; }

    }
}
