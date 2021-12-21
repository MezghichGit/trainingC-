using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surchage_methodes
{
    class Voiture
    {
        // attributs d'instance
        public int id;
        public string marque;
        public string proprietaire;

        // attribut de classe

        public static int nbV;  // va servir pour stocker le nombre d'instance en mémoire

        public Voiture()   // constructeur par défaut
        {
            nbV++;
        }

        public Voiture(int i,  string prop, string ma)   // constructeur avec paramètres
        {
            this.id = i;
            this.marque = ma;
            this.proprietaire = prop;
            nbV++;
        }

        // C'est une méthode d'instance
        public void info()
        {
            Console.WriteLine("Info voiture : ID = " + this.id + " Marque = " + this.marque + " Prop = " + this.proprietaire);
        }

        //Méthode de classe doit être précédé du mot clé static

        public static void getNombreVoiture()
        {
            Console.WriteLine("Nombre de voitures = " + nbV);
        }
    }
}
