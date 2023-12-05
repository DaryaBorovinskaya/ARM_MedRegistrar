using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARM_MedRegistrar.Model.Persons;

namespace ARM_MedRegistrar.Model.Lists
{
    public class GroupOfUsers
    {
        private List<User> _users;
        
        public GroupOfUsers()
        {
            _users = new List<User>();
        }

        public bool AddUser(User user) 
        {
            foreach (var item in _users)
                if (item.Login == user.Login) return false; 
            return true;
        
        }
    }
}
