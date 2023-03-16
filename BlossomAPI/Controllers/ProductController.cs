using BlossomAPI.IServices;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace BlossomAPI.Controllers
{

    [ApiController]
    [Route("[controller] /[action]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;
        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpPost(Name = "InsertProduct")]
        public int Post([FromBody] ProductItem productItem)
        {
            //     _userService.ValidateCredentials(userItem);
            return _productService.InsertProduct(productItem);
        }
        [HttpGet(Name = "GetAllProducts")]
        public List<ProductItem> GetAll()
        {
            //     _userService.ValidateCredentials(userItem);
            return _productService.GetAllProducts();
        }

        [HttpDelete(Name = "DeleteProduct")]
        public void Delete([FromQuery] int id)
        {
            _productService.DeleteProduct(id);

        }
        [HttpPatch(Name = "ModifyProduct")]
        public void Patch([FromBody] ProductItem productItem)
        {
            _productService.UpdateProduct(productItem);
        }


    }
}
