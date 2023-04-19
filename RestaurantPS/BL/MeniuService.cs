using Entities;
using RestaurantPS.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class MeniuService
    {
        private IPreparatDAO preparatDAO;

        public MeniuService()
        {
            this.preparatDAO = PreparatDAO.GetInstance();
        }
        public Preparat GetPreparat(int id)
        {
            return this.preparatDAO.GetPreparat(id);
        }
        public List<Preparat> GetPreparate()
        {
            return this.preparatDAO.GetPreparate();
        }
        public void AddPreparat(Preparat p)
        {
            this.preparatDAO.AddPreparat(p);
        }
        public void DeletePreparat(int id)
        {
            this.preparatDAO.DeletePreparat(id);
        }
        public void UpdatePreparat(Preparat p)
        {
            this.preparatDAO.UpdatePreparat(p);
        }
    }
}
