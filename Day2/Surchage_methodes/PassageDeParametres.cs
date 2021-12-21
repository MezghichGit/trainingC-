using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surchage_methodes
{

    class PassageDeParametres
    {
        
        
        public static void permut(ref int x,ref int y)
        {
            Console.WriteLine("valeurs de x = {0} et y = {1} avant permut",x,y);
            int temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("valeurs de x = {0} et y = {1} après permut", x, y);
        }

        public static int somme(int x, int y, out int plusGrand)
        {
            if (x >= y) plusGrand = x;
            else plusGrand = y;
            return x + y;
        }

        static double moyenne(double[] tab, out double min, out double max)
        {
            double somme = 0;
            min = tab[0];
            max = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] <= min)
                {
                    min = tab[i];
                }
                if (tab[i] >= max)
                { max = tab[i]; }
                somme = somme + tab[i];

            }
            return (somme / tab.Length);
        }

        public static void infoStagiaire(string nom, string orgFormation="GK Lyon", string lieu="Lyon")
        {
            Console.WriteLine("Stagiaire = " + nom);
            Console.WriteLine("Organisme de formation = " + orgFormation);
            Console.WriteLine("Lieu de formation = " + lieu);
        }


        public static void infoFormation(string libelle, string formateur, int duree)
        {
            Console.WriteLine("Libelle de la formation = " + libelle);
            Console.WriteLine("Formateur = " + formateur);
            Console.WriteLine("Durée de formation = " + duree);
        }
        static void Main(string[] args)
        {
            const int x = 10;

            //infoFormation(formateur:"Amine",duree:8,libelle:"C#");

            infoStagiaire("Amine", lieu:"Brest");
            /*
            infoStagiaire("Amine");
            infoStagiaire("Olivier","GK Paris");
            infoStagiaire("Thomas", "GK Lille", "Lille");*/


            /*
            double[] tab = new double[3];
            tab[0] = 12.5;
            tab[1] = 14.5;
            tab[2] = 16;

            double grand, petit;
            double res = moyenne(tab, out petit, out grand);

            
            double val = Math.Round(res, 2);

            Console.WriteLine("La moyenne = " + val + " le min = " + petit + " le max = " + grand);
            */
            /*
            int max;
            int res = somme(10, 20, out max);
            Console.WriteLine("La somme = " + res);
            Console.WriteLine("Le max = " + max);*/


            /*
            int a = 10; int b = 20;

            Console.WriteLine("Avant permutation...");


            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            Console.WriteLine("Après permutation...");
            permut(ref a,ref b);
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);*/
        }
    }
}
