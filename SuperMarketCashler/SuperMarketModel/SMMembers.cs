using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketModel
{
    /// <summary>
    /// 会员记录表
    /// </summary>
    [Serializable]
    public class SMMembers
    {
        /// <summary>
        /// 会员卡号
        /// </summary>
        public int MemberId { get; set; }
        /// <summary>
        /// /会员姓名
        /// </summary>
        public string MemberName { get; set; }
        /// <summary>
        /// 会员积分
        /// </summary>
        public int Points { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// 家庭住址
        /// </summary>
        public string MemberAddress { get; set; }
        /// <summary>
        /// 开会时间
        /// </summary>
        public DateTime OpenTime { get; set; }
        /// <summary>
        /// 会员状态
        /// </summary>
        public int MemberStatus { get; set; }
    }
}
