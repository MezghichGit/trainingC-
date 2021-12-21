using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surchage_methodes
{
    class Operations
    {
        public int x;  // x et y sont des attributs d'instance
        public int y;
        public static int nb;  // nb est un attribut de classe

        public void modifNb()
        {
            nb++;
        }
        public void somme(double a, double b)
        {
            Console.WriteLine("double a + b = " + (a + b));
        }
        
        public  void somme(int a, int b)
        {
            Console.WriteLine("int a + b = " + (a + b));
        }
        /*
        public int somme(int a, int b)
        {
            //Console.WriteLine("int a + b = " + (a + b));

            return a + b;
        }*/

        public  void somme(int a, int b, int c)
        {
            Console.WriteLine("a + b + c = " + (a + b + c));
        }
    }
}
