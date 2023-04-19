using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using BL;
using Entities;
using RestaurantPS.Util;


namespace DAO
{
    class UserDAO: IUsersDAO
    {
        private static IUsersDAO usersDAL = null;
        private String connectionString;
        MySqlConnection conn = null;

        private UserDAO()
        {
            connectionString = String.Format("server={0};user id={1}; password={2}; database={3}; pooling=false", "localhost", "root", "pass123", "restaurant_ps");
            conn = new MySqlConnection(connectionString);
        }

        public static IUsersDAO GetInstance()
        {
            if (usersDAL == null)
            {
                usersDAL = new UserDAO();
            }
            return usersDAL;
        }


        public User GetUser(String username, String password)
        {
            User u = null;
            String sql = "SELECT * FROM users WHERE username='" + username + "' AND password='" + password + "'";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    u = new User(reader["username"].ToString(), reader["password"].ToString(), Util.getRol(reader["rol"].ToString()));
                }
                else
                {
                    u = null;
                }
                conn.Close();

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                conn.Close();
                return null;
            }
            return u;
        }

        public List<User> ListUsers()
        {
            List<User> users = new List<User>();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string username = reader["username"].ToString();
                    string password = reader["password"].ToString();
                    int id = int.Parse(reader["id"].ToString());
                    string role = reader["rol"].ToString();
                    Rol rol = Util.getRol(role);
                    User u = new User(username, password, rol, id);
                    users.Add(u);
                }
            }
            catch (Exception exc)
            {
                
            }
            finally
            {
                conn.Close();
            }

            return users;
        }

        public void DeleteUser(User u)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM users WHERE id = '" + u.Username + "'", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
            }
            catch (MySqlException exc)
            {
                throw exc;
            }
            finally
            {
                conn.Close();
            }
        }

        public User EditUser(User u)
        {
            return u;
        }

        public void AddUser(User u)
        {
            try
            {
                conn.Open();
                string query = $"insert into users (username, password, rol) values ('{u.Username}', '{u.Password}', '{u.Role.ToString()}');";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
            }
            catch (MySqlException exc)
            {
                throw exc;
            }
            finally
            {
                conn.Close();
            }
        }
    }


}
