using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparaison
{
    class CompSolde : IComparer
    {
        public int Compare(object x, object y)
        {
            CompteBancaire c1 = (CompteBancaire)x;
            CompteBancaire c2 = (CompteBancaire)y;
            return (int)(c1.Solde - c2.Solde);
        }
    }
}
