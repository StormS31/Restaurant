using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Comanda
    {
        private List<Preparat> _preparate;
        private double _pret;
        private Status _status;
        private DateTime _date;
        private int _id;
        public Comanda() { }

        public Comanda(List<Preparat> preparate, double pret, Status status, DateTime data)
        {
            Preparate = preparate;
            Pret = pret;
            Statuss = status;
            Data = data;
        }
        public Comanda(List<Preparat> preparate, double pret, Status status, DateTime data, int id)
        {
            Preparate = preparate;
            Pret = pret;
            Statuss = status;
            Data = data;
            Id = id;
        }
        public Comanda(double pret, Status status, DateTime data, int id)
        {
            Pret = pret;
            Statuss = status;
            Data = data;
            Id = id;
        }
        public List<Preparat> Preparate
        {
            get { return _preparate; }
            set { _preparate = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public double Pret
        {
            get { return _pret; }
            set { _pret = value; }
        }
        public Status Statuss
        {
            get { return _status; }
            set { _status = value; }
        }
        public DateTime Data
        {
            get { return _date; }
            set { _date = value; }
        }
    }
}
