using System;

namespace Chapitre1_structure_enum
{
    enum Day {Sunday=1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday};

    //struct CompteBancaire {
    struct CompteBancaire
        {

        private double solde;
        private string id;
        
        public CompteBancaire(string id, double montant) // constructeur avec 2 paramètres
        {
            this.id = id;
            this.solde = montant;
        }
       /*
        public CompteBancaire() // constructeur par défaut
        {

        }*/

        public void infoCompte()
        {
            Console.WriteLine("ID = " + id + " Solde = " + solde);
        }
    }

    struct Person {
    
        public string Nom {
            get;
            set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Personne p1 = new Personne();
            //p1.Nom = "Amine";  // acces en mode set
           // Console.WriteLine("Vous êtes = " + p1.Nom); // acces en mode get
            /*
            CompteBancaire cb1 = new CompteBancaire(); // appel au constructeur par défaut
            cb1.infoCompte();

            CompteBancaire cb2 = new CompteBancaire("123",1500); // appel au constructeur avec deux paramètres
            cb2.infoCompte();*/


            /*
            Day myfavoriteDay = Day.Friday;
            Console.WriteLine("myfavoriteDay = " + myfavoriteDay);
            Day day1 = (Day)4;
            Console.WriteLine("day1 = " + day1);
            */

        }
    }
}
