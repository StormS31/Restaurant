using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    interface IComandaDAO
    {
        List<Comanda> GetComandaBetweenDates(DateTime d1, DateTime d2);
        List<Comanda> GetComenzi();
        Comanda GetComanda(int id);
        DataTable GetMostOrderedDishes();
        void AddComanda(Comanda c);
        void UpdateComanda(Comanda c);
    }
}
