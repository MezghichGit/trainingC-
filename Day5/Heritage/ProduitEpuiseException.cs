using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class ProduitEpuiseException:Exception
    {
        public ProduitEpuiseException() : base()
        {
            Console.WriteLine("Fin du stock constructeur 1 ..." + base.Message);
        }

        public ProduitEpuiseException(string message) : base(message)
        {
            Console.WriteLine("Fin du stock constructeur 2 ..." + base.Message);
        }

        public ProduitEpuiseException(string message, Exception e) : base(message,e)
        {
            Console.WriteLine("Fin du stock constructeur 3 ..." + base.Message +" "+e.Message);
        }
    }
}
