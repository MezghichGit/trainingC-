using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparaison
{
    class Etudiant : IComparable
    {
        public string Nom { get; set; }

        public int Age { get; set; }

        public double Moyenne { get; set; }

        public Etudiant(string nom, int age, double moyenne)
        {

            Nom = nom;
            Age = age;
            Moyenne = moyenne;

        }
        /*
        public int CompareTo(object obj)
        {
            Etudiant temp = (Etudiant)obj;
            return this.Age - temp.Age;
        }
        */
      
        public int CompareTo(object obj)
        {
            Etudiant temp = (Etudiant)obj;
            return (int)((this.Moyenne - temp.Moyenne) * 100);
        }

    }



}
