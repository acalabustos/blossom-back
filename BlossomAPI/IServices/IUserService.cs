using Entities.Entities;

namespace BlossomAPI.IServices
{
    public interface IUserService
    {
        List<UserItem> GetAllUser();
        int InsertUser(UserItem userItem);
        void DeleteUser(int id);
        void UpdateUser(UserItem userItem);
    }
}
