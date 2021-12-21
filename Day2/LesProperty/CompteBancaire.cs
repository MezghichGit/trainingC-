using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesProperty
{
    class CompteBancaire
    {
        private double solde;
        public double Solde   // Solde est une property
        {
            get { return this.solde; }
            set { this.solde = value; }
        }

        private double decouvert = -243.6;
        public double Decouvert
        {
            get { return this.decouvert; }
        }

        private double mdp;
        public double MDP
        {
            get { return this.mdp; }
            set { this.mdp = value; }
        }

    }

}
