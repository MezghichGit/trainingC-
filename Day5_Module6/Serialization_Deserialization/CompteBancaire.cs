using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_Deserialization
{
    class CompteBancaire : IComparable
    {
        public string Prop { set; get; }
        public double Solde { set; get; }

        public int CompareTo(object obj)
        {
            CompteBancaire temp = (CompteBancaire)obj;
            return (int)(temp.Solde - this.Solde);
        }

        public void print()
        {
            Console.WriteLine("Propriétaire : {0} - Solde : {1}", Prop, Solde);
        }
    }
}
