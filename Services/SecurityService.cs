using RegisterandLoginExp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterandLoginExp.Services
{
    public class SecurityService
    {
        UsersDAO userDAO = new UsersDAO();

        public SecurityService()
        {
           

        }

        public bool IsValid(UserModel user)
        {
            // return value if found in list
            return userDAO.FindUserByNameAndPassword(user);
        }
    }
}
