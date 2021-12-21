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
        static void Main(string[] args)
        {
            int a = 10; int b = 20;

            Console.WriteLine("Avant permutation...");


            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            Console.WriteLine("Après permutation...");
            permut(ref a,ref b);
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}
