using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestException
{
    class Etudiant
    {
        readonly string nom="ab";

        private int age;  // attribut d'instance
        private static int nb;  // attribut de classe

        public Etudiant()
        {
            nom = "nouveau";
        }

        public int info()
        {
            //this.nom = "new";

            Console.WriteLine("Info");

            return 10;
        
        }

        public void getAge()
        {
            Console.WriteLine("Age = "+ this.age);
        }

        public static void affichage()
        {
            //this.age = 20;   // interdit
            nb = 20;
        }
    }
}
