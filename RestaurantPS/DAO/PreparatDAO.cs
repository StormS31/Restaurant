using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPS.DAO
{
    class PreparatDAO : IPreparatDAO
    {
        private static IPreparatDAO preparatDAL = null;
        private String connectionString;
        MySqlConnection conn = null;

        private PreparatDAO()
        {
            connectionString = String.Format("server={0};user id={1}; password={2}; database={3}; pooling=false", "localhost", "root", "pass123", "restaurant_ps");
            conn = new MySqlConnection(connectionString);
        }

        public static IPreparatDAO GetInstance()
        {
            if (preparatDAL == null)
            {
                preparatDAL = new PreparatDAO();
            }
            return preparatDAL;
        }

        public void AddPreparat(Preparat p)
        {
            try
            {
                conn.Open();
                string query = $"insert into preparat (nume, stoc, pret) values ('{p.Nume}', '{p.Stoc}', '{p.Pret.ToString("G", CultureInfo.InvariantCulture)}');";
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

        public void DeletePreparat(int id)
        {
            try
            {
                conn.Open();
                string query = $"delete from preparat where id = {id};";
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

        public Preparat GetPreparat(int _id)
        {
            try
            {
                conn.Open();
                string query = $"select * from preparat where id = {_id};";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string nume = reader["nume"].ToString();
                    int stoc = int.Parse(reader["stoc"].ToString());
                    double pret = double.Parse(reader["pret"].ToString());
                    int id = int.Parse(reader["id"].ToString());
                    return new Preparat(nume, stoc, pret, id);
                }
                else throw new Exception("Preparatul cu ID-ul specificat nu exista!");
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

        public List<Preparat> GetPreparate()
        {
            try
            {
                conn.Open();
                string query = $"select * from preparat;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                List<Preparat> preparate = new List<Preparat>();
                while (reader.Read())
                {
                    string nume = reader["nume"].ToString();
                    int stoc = int.Parse(reader["stoc"].ToString());
                    double pret = double.Parse(reader["pret"].ToString());
                    int id = int.Parse(reader["id"].ToString());
                    preparate.Add(new Preparat(nume, stoc, pret, id));
                }
                return preparate;
            }
            catch (MySqlException e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
        }

        public void UpdatePreparat(Preparat p)
        {
            try
            {
                conn.Open();
                string query = $"update preparat set nume = '{p.Nume}', stoc = '{p.Stoc}', pret = '{p.Pret.ToString("G", CultureInfo.InvariantCulture)}' where id = {p.Id};";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
            }
            catch (MySqlException e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
