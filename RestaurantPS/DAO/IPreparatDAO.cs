using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPS.DAO
{
    interface IPreparatDAO
    {
        void AddPreparat(Preparat p);
        List<Preparat> GetPreparate();
        Preparat GetPreparat(int id);
        void UpdatePreparat(Preparat p);
        void DeletePreparat(int id);
    }
}
