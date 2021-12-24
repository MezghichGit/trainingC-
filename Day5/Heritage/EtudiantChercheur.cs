using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
     class EtudiantChercheur:Etudiant
    {
        public EtudiantChercheur() : base("Paris")
        {

        }

        public  void info()
        {
            base.info(); //appel à la méthode info de la classe mère
            Console.WriteLine("Adresse : " + Adresse);
        }
    }
}
