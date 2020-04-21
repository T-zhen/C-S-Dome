using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketModel
{
    /// <summary>
    /// 商品计量单位表
    /// </summary>
    [Serializable]
    public class ProductUnit
    {
        /// <summary>
        /// 单位ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 商品单位
        /// </summary>
        public string Unit { get; set; }
    }
}
