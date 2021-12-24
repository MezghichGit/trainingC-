using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_Deserialization
{
    class Etudiant
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Etudiant(string nom, int age)
        {
            Name = nom;
            Age = age;
        }
    }
}
