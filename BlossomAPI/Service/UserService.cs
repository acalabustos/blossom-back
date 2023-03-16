using BlossomAPI.IServices;
using Entities.Entities;
using Logic.ILogic;

namespace BlossomAPI.Service
{
    public class UserService : IUserService
    {
        private readonly IUserLogic _userLogic;
        public UserService(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }
        public int InsertUser(UserItem userItem)
        {
            _userLogic.InsertUserItem(userItem);
            return userItem.Id;
        }
        public List<UserItem> GetAllUser()
        {
            return _userLogic.GetAllUser();

        }
        public void DeleteUser(int id)
        {
            _userLogic.DeleteUserItem(id);
        }
        public void UpdateUser(UserItem userItem)
        {
            _userLogic.UpdateUserItem(userItem);
        }

    }
}

