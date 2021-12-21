using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surchage_methodes
{
    public class Calcul
    {
        /*public static void somme(int x, int y)
        {
            Console.WriteLine("La somme = " + (x + y));
        }

        public static void somme(int x, int y, int z)
        {
            Console.WriteLine("La somme = " + (x + y +z));
        }

        public static void somme(int x, int y, int z, int t)
        {
            Console.WriteLine("La somme = " + (x + y + z + t));
        }*/

        public static void somme(params int[] x)
        {
            int res = 0;
            for (int i = 0; i < x.Length; i++)
            {
                res = res + x[i];
            }
            Console.WriteLine("La somme = " + res);
        }

        public static void moyenne(params double[] tab)
        {
            double somme = 0;
            int i;

            for (i = 0; i < tab.Length; i++)
            {
                somme = somme + tab[i];
            }

            Console.WriteLine("La moyenne est de " + somme / tab.Length);

        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Classe Calcul");
            /*
            somme();
            somme(10);
            somme(10, 20);
            somme(10, 20,6);
            somme(10, 20, 6,4);*/
            /*
            moyenne(10,15);
            moyenne(10,20,40);*/

            string formation = "formation c#";
            Console.WriteLine(formation.ToUpper());
        }
    }
}
