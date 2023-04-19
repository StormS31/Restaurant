using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Preparat
    {
        private string _nume;
        private int _stoc;
        private double _pret;
        private int _id;

        public Preparat() { }
        public Preparat(string nume, int stoc, double pret)
        {
            Nume = nume;
            Stoc = stoc;
            Pret = pret;
        }
        public Preparat(string nume, int stoc, double pret, int id)
        {
            Nume = nume;
            Stoc = stoc;
            Pret = pret;
            Id = id;
        }
        public string Nume
        {
            get { return _nume;}
            set { _nume = value; }
        }
        public int Stoc
        {
            get { return _stoc; }
            set { _stoc = value; }
        }
        public double Pret
        {
            get { return _pret; }
            set { _pret = value; }
        }

        public int Id { get => _id; set => _id = value; }
    }
}
