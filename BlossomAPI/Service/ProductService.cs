using BlossomAPI.IServices;
using Entities.Entities;
using Logic.ILogic;

namespace BlossomAPI.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductLogic _productLogic;
        public ProductService(IProductLogic productLogic)
        {
            _productLogic = productLogic;
        }
        public int InsertProduct(ProductItem productItem)
        {
            _productLogic.InsertProductItem(productItem);
            return productItem.Id;
        }
        public List<ProductItem> GetAllProducts()
        {
            return _productLogic.GetAllProducts();
        }

        public void DeleteProduct(int id)
        {
            _productLogic.DeleteProductItem(id);
        }

        public void UpdateProduct(ProductItem productItem)
        {
            _productLogic.UpdateProductItem(productItem);
        }
        List<ProductItem> IProductService.GetProductByCriteria(string NameBrand)
        {
            return _productLogic.GetProductByCriteria(NameBrand);
        }
    }
}
