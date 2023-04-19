using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Entities;
using System.Security.Cryptography;
namespace BL
{
    class UserService
    {
        private IUsersDAO userDAO;
        public UserService() {
            Initialise();
        }

        public IUsersDAO UsersDAO
        {
            get { return userDAO; }
            set { userDAO = value; }
        }
        public void Initialise()
        {
            this.userDAO = UserDAO.GetInstance();
        }

        public User LogIn(string user, string pass)
        {
            User thisUser = this.UsersDAO.GetUser(user, getMd5Hash(pass));
            return thisUser;
        }

        public void AddUser(User u)
        {
            u.Password = getMd5Hash(u.Password);
            this.UsersDAO.AddUser(u);
        }

        public static string getMd5Hash(string input)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)

            {

                sBuilder.Append(data[i].ToString("x2"));

            }
            return sBuilder.ToString();
        }
        public List<User> getUsers()
        {
            return this.userDAO.ListUsers();
        }
    }
}
