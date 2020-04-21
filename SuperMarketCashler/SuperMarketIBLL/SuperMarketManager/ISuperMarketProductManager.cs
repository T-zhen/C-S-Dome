using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMarketModel;

namespace SuperMarketIBLL.SuperMarketManager
{
    public interface ISuperMarketProductManager
    {
        List<ProductCategory> GetCategories();
        List<ProductUnit> GetUnit();

        bool InsertProduct(Produts produt, ProductInventory inventory);
        List<Produts> GetAllProduct();
        List<Produts> GetProductsWithWhere(int categoryId, string where);

        bool SetProductDiscount(string pid, float discount);
        bool UpdateProduct(Produts produts);
        Produts GetProductWithId(string pid);
        bool InventoryProduct(string pid, int count);
    }
}
