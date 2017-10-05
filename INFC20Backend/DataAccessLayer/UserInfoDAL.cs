using INFC20Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INFC20Backend.DataAccessLayer
{
    public class UserInfoDAL
    {
        public UserInfo GetUser(String email)
        {
            return new UserInfo() { Email = "testemail@.com" }; // TODO koppla med DAL
        }
    }
}