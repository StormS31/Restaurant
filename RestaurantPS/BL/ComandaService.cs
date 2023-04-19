using DAO;
using Entities;
using RestaurantPS.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class ComandaService
    {
        private List<Preparat> comandaActuala;
        private Comanda comanda;
        private IComandaDAO comandaDAO;
        private IPreparatDAO preparatDAO;
        public ComandaService()
        {
            this.comandaDAO = ComandaDAO.GetInstance();
            this.preparatDAO = PreparatDAO.GetInstance();
            comandaActuala = new List<Preparat>();
            this.comanda = new Comanda();
        }
        public List<Comanda> GetComandaBetweenDates(DateTime d1, DateTime d2)
        {
            return comandaDAO.GetComandaBetweenDates(d1, d2);
        }
        public DataTable GetMostOrderedDishes()
        {
            return comandaDAO.GetMostOrderedDishes();
        }

        public int AddToComandaActuala(Preparat p)
        {
            if (p.Stoc > 0)
            {
                comandaActuala.Add(p);
                p.Stoc--;
                preparatDAO.UpdatePreparat(p);
                comanda.Pret += p.Pret;
                return 1;
            }
            else return 0;
        }
        public List<Preparat> ComandaActuala
        {
            get { return comandaActuala; }
        }
        public int StergeDinComandaActuala(int id)
        {
            foreach (Preparat p in comandaActuala)
            {
                if (p.Id == id)
                {
                    Preparat x = preparatDAO.GetPreparat(p.Id);
                    x.Stoc++;
                    comandaActuala.Remove(p);
                    preparatDAO.UpdatePreparat(x);
                    comanda.Pret -= p.Pret;
                    return 1;
                }
            }
            return 0;
        }
        public double TotalPrice()
        {
            return comanda.Pret;
        }
        public void EmptyComandaActuala()
        {
            var p = comandaActuala.ToArray();
            for(int i = 0; i<p.Length; i++)
            {
                StergeDinComandaActuala(p[i].Id);
            }
        }
        public void AddComanda()
        {
            comanda.Statuss = Status.NOUA;
            comanda.Preparate = comandaActuala;
            comanda.Data = DateTime.Now;
            comandaDAO.AddComanda(comanda);
            comanda.Pret = 0.0;
            comandaActuala.Clear();
        }
        public List<Comanda> GetComenzi()
        {
            return this.comandaDAO.GetComenzi();
        }
        public Comanda GetComanda(int id)
        {
            return comandaDAO.GetComanda(id);
        }
        public void UpdateComanda(Comanda c)
        {
            comandaDAO.UpdateComanda(c);
        }
    }
}
