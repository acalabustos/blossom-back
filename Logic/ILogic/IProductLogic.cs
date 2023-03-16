using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IProductLogic
    {
        List<ProductItem> GetAllProducts();
        int InsertProductItem(ProductItem productItem);
        void UpdateProductItem(ProductItem productItem);
        void DeleteProductItem(int id);
        List<ProductItem> GetProductByCriteria(string NameBrand);

    }
}
