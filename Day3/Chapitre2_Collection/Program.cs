using System;
using System.Collections;
using System.Collections.Generic;

namespace Chapitre2_Collection
{
    struct CompteBancaire {
    public string Prop { get; set; }
    public double Solde { get; set; }
        public CompteBancaire(string nom, double val)
        {
            Prop = nom;
            Solde = val;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Création d'une liste de deux comptes");

            //List<CompteBancaire> mesComptes = new List<CompteBancaire>();

            ArrayList mesComptes = new ArrayList();  // Collection non-generique
            CompteBancaire cb1 = new CompteBancaire("Amine", 200);
            CompteBancaire cb2 = new CompteBancaire("Alain", 400);
            mesComptes.Add(cb1);
            mesComptes.Add(cb2);
            Console.WriteLine("Nombre d'élements dans la collection = "+mesComptes.Count);
            mesComptes.Clear();
            Console.WriteLine("Nombre d'élements dans la collection = " + mesComptes.Count);
        }
    }
}
