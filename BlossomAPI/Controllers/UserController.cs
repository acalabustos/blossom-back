using BlossomAPI.IServices;
using BlossomAPI.Service;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BlossomAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;
        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpPost(Name = "InsertUser")]
        public int Post([FromBody] UserItem userItem)
        {
            return _userService.InsertUser(userItem);
        }
        [HttpGet(Name = "GetAllUser")]
        public List<UserItem> GetAll()
        {
            //     _userService.ValidateCredentials(userItem);
            return _userService.GetAllUser();
        }
        [HttpPatch(Name = "ModifyUser")]
        public void Patch([FromBody] UserItem userItem)
        {
            _userService.UpdateUser(userItem);

        }
        [HttpDelete(Name = "DeleteUser")]
        public void Delete([FromQuery] int id)
        {
            _userService.DeleteUser(id);

        }
    }
}