using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketModel;

namespace SuperMarketIDAL.SuperMarketManager
{
    public interface ISuperMarketProductServer
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        /// <returns></returns>
        List<ProductCategory> GetCategories();

        List<ProductUnit> GetUnit();
        /// <summary>
        /// 添加商品
        /// </summary>
        /// <param name="produt"></param>
        /// <param name="inventory"></param>
        /// <returns></returns>
        bool InsertProduct(Produts produt, ProductInventory inventory);

        List<Produts> GetAllProduct();
        /// <summary>
        /// 商品编号返回商品信息
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        Produts GetProductWithId(string pid);

        int InventoryProduct(string pid, int count);


        List<Produts> GetProductsWithWhere(int categoryId, string where);

        int SetProductDiscount(string pid, float discount);
        /// <summary>
        /// 删除商品
        /// </summary>
        /// <param name="produts"></param>
        /// <returns></returns>
        int UpdateProduct(Produts produts);
    }
}
