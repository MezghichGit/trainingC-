using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Interface
{
    class ImprimanteLazerHP : Imprimante, Scanner, Photocopieuse
    {
        public void imprimer() {
            Console.WriteLine("Impression Lazer");
        }
        public void allumer() {
            Console.WriteLine("Appuyer sur Start");
        }

        public void arreter() {
            Console.WriteLine("Appuyer sur Stop");
        }

        public void scanner()
        {
            Console.WriteLine("Je peux scanner des doc...");
        }

        public void photocopier()
        {
            Console.WriteLine("Je peux faire des photocopies...");
        }
    }
}
