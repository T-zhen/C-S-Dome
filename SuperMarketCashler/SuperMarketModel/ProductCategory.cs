using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketModel
{
    /// <summary>
    /// 商品类别表
    /// </summary>
    [Serializable]
    public class ProductCategory
    {
        /// <summary>
        /// 类别ID
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// 类别名称
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsClock { get; set; }
    }
}
