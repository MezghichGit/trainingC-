using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Interface
{
    class Poisson : Animal
    {
        public void seDeplacer()
        {
            Console.WriteLine("Je nage");
        }

        public string info()
        {
            return "je suis un poisson";
        }
    }
}
