using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IUserLogic
    {
        int InsertUserItem(UserItem userItem);
        List<UserItem> GetAllUser();
        void UpdateUserItem(UserItem userItem);
        void DeleteUserItem(int id);

    }
}
