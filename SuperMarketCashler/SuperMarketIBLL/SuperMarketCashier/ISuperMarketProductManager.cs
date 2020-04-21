using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketModel;

namespace SuperMarketIBLL.SuperMarketCashier
{
    /// <summary>
    /// 商品业务逻辑
    /// </summary>
    public interface ISuperMarketProductManager
    {
        /// <summary>
        /// 通过ID查询售货员信息
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        Produts GetProductWithId(string productId);

        /// <summary>
        /// 销售数据保存
        /// </summary>
        /// <param name="sales"></param>
        /// <param name="members"></param>
        /// <returns></returns>
        bool SaveSalerInfo(SalesList sales, SMMembers members);
    }
}
