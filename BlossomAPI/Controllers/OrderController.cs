using BlossomAPI.IServices;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BlossomAPI.Controllers
{
    [ApiController]
    [Route("[controller] /[action]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        private readonly IOrderService _orderService;
        public OrderController(ILogger<OrderController> logger, IOrderService orderService)
        {
            _logger = logger;
            _orderService = orderService;
        }

        [HttpPost(Name = "InsertOrder")]
        public int Post([FromBody] OrderItem orderItem)
        {
            //     _userService.ValidateCredentials(userItem);
            return _orderService.InsertOrder(orderItem);
        }
        [HttpGet(Name = "GetAllOrder")]
        public List<OrderItem> GetAll()
        {
            //     _userService.ValidateCredentials(userItem);
            return _orderService.GetAllOrder();
        }
        [HttpPatch(Name = "ModifyOrder")]
        public void Patch([FromBody] OrderItem orderItem)
        {
            _orderService.UpdateOrder(orderItem);

        }
        [HttpDelete(Name = "DeleteOrder")]
        public void Delete([FromQuery] int id)
        {
            _orderService.DeleteOrder(id);

        }
        [HttpGet(Name = "GetOrderByProduct")]
        public List<OrderItem> GetOrderByProduct([FromQuery] int IdProduct)
        {

            return _orderService.GetOrderByProduct(IdProduct);
        }
    }
}
