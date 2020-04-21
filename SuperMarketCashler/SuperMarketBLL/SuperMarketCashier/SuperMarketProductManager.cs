using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketModel;
using SuperMarketIBLL.SuperMarketCashier;
using SuperMarketIDAL.SuperMarketCashier;
using SuperMarketDAL.SuperMarketCashier;

namespace SuperMarketBLL.SuperMarketCashier
{
    public class SuperMarketProductManager : ISuperMarketProductManager
    {
        ISuperMarketProductServer server = new SuperMarketProductServer();

        /// <summary>
        /// 通过ID查询售货员信息
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Produts GetProductWithId(string productId)
        {
            return server.GetProductWithId(productId);
        }
        /// <summary>
        /// 销售数据保存 更新会员积分
        /// </summary>
        /// <param name="sales"></param>
        /// <param name="members"></param>
        /// <returns></returns>
        public bool SaveSalerInfo(SalesList sales, SMMembers members)
        {
            return server.SaveSalerInfo(sales, members);
        }
    }
}
