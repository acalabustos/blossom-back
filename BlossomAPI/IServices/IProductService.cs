using Entities.Entities;

namespace BlossomAPI.IServices
{
    public interface IProductService
    {
        List<ProductItem> GetAllProducts();
        int InsertProduct(ProductItem productItem);
        void DeleteProduct(int id);
        void UpdateProduct(ProductItem productItem);
        List<ProductItem> GetProductByCriteria(string NameBrand);

    }
}
