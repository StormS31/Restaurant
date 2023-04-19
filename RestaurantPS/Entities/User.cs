using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    class User
    {
        private String _username;
        private String _password;
        private Rol _role;
        private int _id;
        public User() { }

        public User(String username, String password, Rol role, int id)
        {
            Username = username;
            Password = password;
            Role = role;
            Id = id;
        }

        public User(String username, String password, Rol role)
        {
            Username = username;
            Password = password;
            Role = role;
        }


        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public Rol Role
        {
            get { return _role; }
            set { _role = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
