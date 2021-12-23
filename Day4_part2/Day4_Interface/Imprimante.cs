using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Interface
{
    public interface Imprimante
    {
        public void imprimer();  //méthode abstraite

        public void allumer();

        public void arreter();
    }
}
