using DAO;
using Entities;
using MySql.Data.MySqlClient;
using RestaurantPS.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    class ComandaDAO : IComandaDAO
    {
        private string connectionString;
        private MySqlConnection conn;
        private static IComandaDAO comandaDAL = null;

        private ComandaDAO()
        {
            connectionString = String.Format("server={0};user id={1}; password={2}; database={3}; pooling=false", "localhost", "root", "pass123", "restaurant_ps");
            conn = new MySqlConnection(connectionString);

        }

        public static IComandaDAO GetInstance()
        {
            if (comandaDAL == null)
            {
                comandaDAL = new ComandaDAO();
            }
            return comandaDAL;
        }
        
        public void AddComanda(Comanda c)
        {
            try
            {
                conn.Open();
                string query = $"insert into comanda (pret, status, data) values ('{c.Pret.ToString("G", CultureInfo.InvariantCulture)}', '{c.Statuss.ToString()}', '{c.Data.ToString("yyyy-MM-dd H:mm:ss")}');select LAST_INSERT_ID() as id;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                int id = -1;
                if(reader.Read())
                    id = int.Parse(reader["id"].ToString());
                conn.Close();
                this.AddComandaPreparat(c, id);
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
        public void AddComandaPreparat(Comanda c, int id)
        {
            try
            {
                foreach(Preparat p in c.Preparate)
                {
                    string query = $"insert into comandapreparate (idComanda, idPreparat) values ('{id}', '{p.Id}');";
                    try
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        MySqlDataReader reader = cmd.ExecuteReader();
                    }
                    catch (Exception exc)
                    {
                        throw exc;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            catch (MySqlException exc)
            {
                throw exc;
            }
        }
        public Comanda GetComanda(int _id)
        {
            try
            {
                conn.Open();
                string query = $"select * from comanda where id = {_id};";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                Comanda comanda = null;
                if (reader.Read())
                {
                    //pret
                    //status
                    //data
                    //id
                    double pret = double.Parse(reader["pret"].ToString());
                    Status status = Util.GetStatus(reader["status"].ToString());
                    DateTime data = DateTime.Parse(reader["data"].ToString());
                    int id = int.Parse(reader["id"].ToString());
                    comanda = new Comanda(pret, status, data, id);
                }
                return comanda;
            }
            catch (Exception exc)
            {
                throw exc;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Comanda> GetComandaBetweenDates(DateTime d1, DateTime d2)
        {
            throw new NotImplementedException();
        }

        public List<Comanda> GetComenzi()
        {
            try
            {
                conn.Open();
                string query = "select * from comanda;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                List<Comanda> comenzi = new List<Comanda>();
                while(reader.Read())
                {
                    //pret
                    //status
                    //data
                    //id
                    double pret = double.Parse(reader["pret"].ToString());
                    Status status = Util.GetStatus(reader["status"].ToString());
                    DateTime data = DateTime.Parse(reader["data"].ToString());
                    int id = int.Parse(reader["id"].ToString());
                    comenzi.Add(new Comanda(pret, status, data, id));
                }
                return comenzi;
            }
            catch (Exception exc)
            {
                throw exc;
            }
            finally
            {
                conn.Close();
            }
        }

        public void UpdateComanda(Comanda c)
        {
            try
            {
                conn.Open();
                string query = $"update comanda set status = '{c.Statuss}' where id = {c.Id};";
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
        public DataTable GetMostOrderedDishes()
        {
            string query = "SELECT p.id as \"ID\", p.nume as \"Nume preparat\", p.pret as \"Pret preparat\", p.stoc as \"Stoc preparat\", count(*) as TimesOrdered " +
                                "FROM comanda c " +
                                "INNER JOIN comandapreparate cp ON c.id = cp.idComanda " +
                                "INNER JOIN preparat p ON cp.idPreparat = p.id " +
                                "GROUP BY p.nume " +
                                "ORDER BY TimesOrdered DESC;";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Executie nereusita");
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
