using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketModel
{
    /// <summary>
    /// 商品详细信息
    /// </summary>
    [Serializable]
    public class Produts
    {
        /// <summary>
        /// 商品编号商品条码
        /// </summary>
        public string ProductId { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// 计量单位
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal UnitPrice { get; set; }
        /// <summary>
        /// 折扣
        /// </summary>
        public double Discount { get; set; }
        /// <summary>
        /// 商品分类ID
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// 商品库存总数量
        /// </summary>
        public int ToalCount { get; set; }

        //扩展属性
        public int ProductNo { get; set; }
        /// <summary>
        /// 销售数量
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// 小计金额
        /// </summary>
        public decimal SubTotal { get; set; }
        /// <summary>
        /// 商品分类
        /// </summary>
        public string CategoryName { get; set; }
    }
}
