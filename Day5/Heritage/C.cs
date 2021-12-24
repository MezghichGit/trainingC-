using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class C:B
    {
        public C() //appel implicite au constructeur par défaut de la classe mère B
        {
            Console.WriteLine("C0");
        }

        public C(int num)   //appel implicite au constructeur par défaut de la classe mère B
        {
            Console.WriteLine("C1");
        }

        public C(int num1, int num2) : this(num1 + num2)  //appel du constructeur avec 1 paramètre de la même classe
        {
                Console.WriteLine("C2");

        }
     }
}
