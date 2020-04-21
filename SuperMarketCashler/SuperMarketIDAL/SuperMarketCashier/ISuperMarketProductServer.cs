using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketModel;

namespace SuperMarketIDAL.SuperMarketCashier
{
    /// <summary>
    /// 商品服务接口
    /// </summary>
    public interface ISuperMarketProductServer
    {
        /// <summary>
        /// 通过商品编号查询
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        Produts GetProductWithId(string productId);

        /// <summary>
        /// 启动事物处理购买商品对象更新会员积分
        /// </summary>
        /// <param name="ales"></param>
        /// <param name="members"></param>
        /// <returns></returns>
        bool SaveSalerInfo(SalesList ales,SMMembers members);
    }
}
