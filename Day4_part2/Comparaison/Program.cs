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


            CompSolde compSolde = new CompSolde();
            CompId compId = new CompId();
            CompteBancaire c1 = new CompteBancaire(20, "Amine", 1200);
            CompteBancaire c2 = new CompteBancaire(10, "Patrick", 4000);
            CompteBancaire c3 = new CompteBancaire(30, "Olivier", 100);
            ArrayList comptes = new ArrayList();
            comptes.Add(c1);
            comptes.Add(c2);
            comptes.Add(c3);
           


            Console.WriteLine("Tri selon le Solde");
            comptes.Sort(compSolde);

            foreach (CompteBancaire c in comptes)
            {
                Console.WriteLine(c.Id +" "+c.Nom +" "+c.Solde);
            }


            Console.WriteLine("Tri selon le l'Id ");
            comptes.Sort(compId);

            foreach (CompteBancaire c in comptes)
            {
                Console.WriteLine(c.Id + " " + c.Nom + " " + c.Solde);
            }


            // Exo Etudiants
            /*
            Etudiant e1 = new Etudiant("Jean", 28, 12.5);
            Etudiant e2 = new Etudiant("Georges", 12, 15);
            Etudiant e3 = new Etudiant("Arthur", 35, 17);
            Etudiant e4 = new Etudiant("Pascal", 60, 11);
            ArrayList etu = new ArrayList();

            etu.Add(e1);
            etu.Add(e2);
            etu.Add(e3);
            etu.Add(e4);
            etu.Sort();

            foreach (Etudiant e in etu)
            {

                Console.WriteLine("Nom : " + e.Nom + " Age : " + e.Age + " Moyenne  : " + e.Moyenne);

            }

             */
        }
    }
}
