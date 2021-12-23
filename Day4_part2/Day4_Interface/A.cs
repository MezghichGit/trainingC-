using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Interface
{
    class A : I  // on dit que la classe A implemente l'interaface I => cad elle donne l'implementation de toutes les méthodes absttraites
    {
        public void affichage()
        {
            Console.WriteLine("Méthode Affichage de I");
        }

        public void info()
        {
            Console.WriteLine("Méthode Info de I");
        }

        public void printA()
        {
            Console.WriteLine("A");
        }
    }
}
