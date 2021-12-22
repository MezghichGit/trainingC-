using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestException
{
    class CompteBancaire
    {
        private double solde = 0;
        private double decouvet = 200;

        public void debiter(double montant)
        {
            if (montant <= decouvet && solde >= 0)
                this.solde = this.solde - montant;
            else
                Console.WriteLine("Montant non permis");
        
        }

        public void getSolde()
        {
            Console.WriteLine("Solde actuel = "+this.solde);
        }

        public void crediter(double montant)
        {
            if(montant > 0)
                this.solde = this.solde + montant;
            Console.WriteLine("Solde actuel = " + this.solde);
        }
    }
}
