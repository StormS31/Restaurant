using System;
using System.Collections.Generic;
using Entities;
namespace DAO
{
    interface IUsersDAO
    {
        User GetUser(String username, String password);
        List<User> ListUsers();
        void DeleteUser(User u);
        User EditUser(User u);
        void AddUser(User u);
    }
}
