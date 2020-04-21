using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketModel
{
    /// <summary>
    /// 本次消费总计
    /// </summary>
    [Serializable]
    public class SalesList
    {
        public SalesList()
        {
            ListDetail = new List<SalesListDetail>();
        }

        
        /// <summary>
        /// 流水号
        /// </summary>
        public string SerialNum { get; set; }
        /// <summary>
        /// 购物总价
        /// </summary>
        public decimal TotalMoney { get; set; }
        /// <summary>
        /// 实际收款
        /// </summary>
        public decimal RealReceive { get; set; }
        /// <summary>
        /// 找零
        /// </summary>
        public decimal ReturnMoney { get; set; }
        /// <summary>
        /// 销售员ID
        /// </summary>
        public int SalesPersonId { get; set; }
        /// <summary>
        /// 消费时间
        /// </summary>
        public DateTime SaleDate { get; set; }

        /// <summary>
        /// 与消费明细表相通
        /// </summary>
        public List<SalesListDetail> ListDetail { get; set; }
    }
}
