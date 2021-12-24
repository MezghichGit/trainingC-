using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class ProduitExpireException : Exception
    {
        public ProduitExpireException() : base()
        {
            Console.WriteLine("1: Produit Expiré... " + base.Message);
        }

        public ProduitExpireException(string message) : base(message)
        {
            Console.WriteLine("2: Produit Expiré... ");
        }

        public ProduitExpireException(string message, Exception e) : base(message, e)
        {
            Console.WriteLine("3: Produit Expiré... " + base.Message + " " + e.Message);
        }
    }
}
