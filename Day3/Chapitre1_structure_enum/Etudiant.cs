using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre1_structure_enum
{
    class Etudiant
    {
        public string nom;
        public int age;
        public string [] modules;

        public string this[int index]   // indexeur de modules
        {
            get { return this.modules[index]; }
            set { this.modules[index] = value; }
        }

        public Etudiant(string nom, int age)
        {
            this.nom = nom;
            this.age = age;
            modules = new string[3];
        }

    }
}
