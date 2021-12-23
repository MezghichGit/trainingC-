using System;
using System.Collections;

namespace Comparaison
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ArrayList names = new ArrayList();
            names.Add("Patrick");
            names.Add("Alain");
            names.Add("Marck");
          
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            names.Sort();
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }*/

            CompteBancaire c1 = new CompteBancaire(20, "Amine", 1200);
            CompteBancaire c2 = new CompteBancaire(10, "Patrick", 4000);
            CompteBancaire c3 = new CompteBancaire(30, "Olivier", 100);
            ArrayList comptes = new ArrayList();
            comptes.Add(c1);
            comptes.Add(c2);
            comptes.Add(c3);
            comptes.Sort();

            foreach (CompteBancaire c in comptes)
            {
                Console.WriteLine(c.Id +" "+c.Nom +" "+c.Solde);
            }
        }
    }
}
