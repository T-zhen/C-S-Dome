using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketModel
{
    /// <summary>
    /// 商品库存难详情表
    /// </summary>
    [Serializable]
    public class ProductInventory
    {
        /// <summary>
        /// 库存编号ID
        /// </summary>
        public string ProductId { get; set; }
        /// <summary>
        /// 库存总量
        /// </summary>
        public int TotalCount { get; set; }
        /// <summary>
        /// 最小库存
        /// </summary>
        public int MinCount { get; set; }
        /// <summary>
        /// 最大库存
        /// </summary>
        public int MaxCount { get; set; }
        /// <summary>
        /// 库存状态ID
        /// </summary>
        public int StatusId { get; set; }
        /// <summary>
        /// 库存状态
        /// </summary>
        public string StatusDesc { get; set; }

    }
}
