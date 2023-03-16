using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class UserItem
    {
        public UserItem(string email)
        {
            IsActive = true;
            Email = email;
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; private set; }
        public string EncryptedPassword { get; set; }
        public string Email { get; set; }


    }
}
