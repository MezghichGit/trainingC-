using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparaison
{
    class CompteBancaire : IComparable
    {
        public double Solde { get; set; }
        public int Id { get; set; }
        public string Nom { get; set; }

        public CompteBancaire(int id, string nom, double solde)
        {
            Id = id;
            Nom = nom;
            Solde = solde;
        }

        public int CompareTo(object obj)
        {
            CompteBancaire temp = (CompteBancaire)obj;
            // return (int)(this.Solde - temp.Solde);
            return this.Id - temp.Id;
        }
    }
}
