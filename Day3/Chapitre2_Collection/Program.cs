using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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

        public void infoCompte()
        {
            Console.WriteLine("Prop = " + Prop + " Solde = " + Solde);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Création d'une liste de deux comptes");


            // Cas d'un Dictionnaire avec Hashtable
               /*
            Hashtable annuaireComptes = new Hashtable();
            CompteBancaire cb1 = new CompteBancaire("Amine", 200);
            CompteBancaire cb2 = new CompteBancaire("Alain", 400);
            CompteBancaire cb3 = new CompteBancaire("Olivier", 1400);

            annuaireComptes.Add("Paris", cb1);
            annuaireComptes.Add("Lyon", cb2);
            annuaireComptes.Add("Brest", cb3);

            

            Console.WriteLine("Liste des clés du dictionnaire : ");
            foreach (string key in annuaireComptes.Keys)
            {

                Console.WriteLine("La clé = " + key);
            }

            Console.WriteLine("Liste des values du dictionnaire : ");
            foreach (CompteBancaire cb in annuaireComptes.Values)
            {
              
                cb.infoCompte();
            }
               */
            //List<CompteBancaire> mesComptes = new List<CompteBancaire>();

            ArrayList mesComptes = new ArrayList();  // Collection non-generique

            //Stack
            
           // Stack mesComptes = new Stack();
            CompteBancaire cb1 = new CompteBancaire("Amine", 200);
            CompteBancaire cb2 = new CompteBancaire("Alain", 400);
            CompteBancaire cb3 = new CompteBancaire("Olivier", 1400);
            
            mesComptes.Add(cb1);
            mesComptes.Add(cb2);
            mesComptes.Add(cb3);

            IEnumerable<CompteBancaire> selectedComptes = from CompteBancaire compte in mesComptes
                                                          where compte.Solde <= 2000
                                                          select compte;

            Console.WriteLine("Comptes avec un solde  inférieur à 1000 :");
            foreach (CompteBancaire cb in selectedComptes)
            {
                cb.infoCompte();
            }

            /*
            mesComptes.Push(cb1);
            mesComptes.Push(cb2);
            mesComptes.Push(cb3);
            foreach (CompteBancaire cb in mesComptes)
            {
                cb.infoCompte();
            }*/
            //Console.WriteLine("Nombre d'élements dans la collection = "+mesComptes.Count);
            //mesComptes.Clear();
            //Console.WriteLine("Nombre d'élements dans la collection = " + mesComptes.Count);
        }
    }
}
