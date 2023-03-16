using Entities.Entities;

namespace BlossomAPI.IServices
{
    public interface IOrderService
    {
        List<OrderItem> GetAllOrder();
        int InsertOrder(OrderItem orderItem);
        void UpdateOrder(OrderItem orderItem);
        void DeleteOrder(int id);
        List<OrderItem> GetOrderByProduct(int IdProduct);
    }
}
