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
    public class UserLogic : BaseContextLogic, IUserLogic
    {
        public UserLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public int InsertUserItem(UserItem userItem)
        {
            _serviceContext.Users.Add(userItem);
            _serviceContext.SaveChanges();
            return userItem.Id;
        }

        public List<UserItem> GetAllUser()
        {
            return _serviceContext.Set<UserItem>().ToList();
        }


        public void UpdateUserItem(UserItem userItem)
        {
            _serviceContext.SaveChanges();
            //NO SABEMOS SI TENEMOS QUE PONER UN RETURN
        }

        public void DeleteUserItem(int id)
        {
            var userToDelete = _serviceContext.Set<UserItem>()
                 .Where(u => u.Id == id).First();

            //userToDelete.IsActive = false;

            _serviceContext.SaveChanges();

        }
    }
}
