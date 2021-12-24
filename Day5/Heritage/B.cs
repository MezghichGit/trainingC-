using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class B:A
    {
        public B():base(10)//appel au constructeur avec paramètre de la classe mère A
        {
            Console.WriteLine("B0");
        }

        public B(int num) : this()  //appel du constructeur par defaut de la même classe
        {
            Console.WriteLine("B1");
        }
    }
}
