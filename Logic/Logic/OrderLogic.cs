using Data;
using Entities.Entities;
using Logic.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class OrderLogic : BaseContextLogic, IOrderLogic
    {
        public OrderLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public List<OrderItem> GetAllOrders()
        {
            return _serviceContext.Set<OrderItem>().ToList();
        }
        public int InsertOrderItem(OrderItem orderItem)
        {
            _serviceContext.Orders.Add(orderItem);
            _serviceContext.SaveChanges();
            return orderItem.Id;
        }

        public void UpdateOrderItem(OrderItem orderItem)
        {
            _serviceContext.SaveChanges();

        }

        public void DeleteOrderItem(int id)
        {
            var orderToDelete = _serviceContext.Set<OrderItem>()
                 .Where(o => o.Id == id).First();

            orderToDelete.IsActive = false;

            _serviceContext.SaveChanges();

        }
        public List<OrderItem> GetOrderByProduct(int IdProduct)
        {
            var orderFilter = new OrderItem();
            orderFilter.IdProduct = IdProduct;

            var resultList = _serviceContext.Set<OrderItem>()
                                .Where(o => o.IdProduct == IdProduct);

            if (orderFilter.IdProduct == IdProduct)
            {
                resultList = resultList.Where(o => o.IdProduct == IdProduct);
            }


            return resultList.ToList();
        }
    }
}
