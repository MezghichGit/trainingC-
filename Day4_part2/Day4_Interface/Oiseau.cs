using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Interface
{
    class Oiseau : Animal
    {
        public void seDeplacer()
        {
            Console.WriteLine("Je vol");
        }

        public string info()
        {
            return "je suis un oiseau";
        }
    }
}
