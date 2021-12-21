using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surchage_methodes
{
    class Etudiant
    {
        int age;  // attribut d'instance
        static int MAXAGE = 120;
        readonly int zipCode;
        const string organisme = "GK";

        public Etudiant(int a, int code)
        {
            this.age = a;
            this.zipCode = code; // ici c'est OK de modifier car on est dans le constructeur
  
        }

        public void modifZipCode(int z)
        {
            //this.zipCode = z;  // ici on peut pas modifier car c'est readOnly
        }
    }
}
