using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Interface
{
    class ImprimanteJetAncre : Imprimante, Scanner, Photocopieuse
    {
        public void allumer()
        {
            Console.WriteLine("Appuyer sur Démarrer");
        }

        public void arreter()
        {
            throw new NotImplementedException();
        }

        public void imprimer()
        {
            Console.WriteLine("Impression en Jet Ancre");
        }

        public void photocopier()
        {
            throw new NotImplementedException();
        }

        public void scanner()
        {
            throw new NotImplementedException();
        }
    }
}
