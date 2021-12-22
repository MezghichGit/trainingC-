using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre1_structure_enum
{
    class ProgramEtudiant
    {
        static void Main(string[] args)
        {
            Etudiant e1 = new Etudiant("Amine", 36);
            e1[0] = "C#";
            e1[1] = "Test avec C#";
            e1[2] = "Projet";

            Console.WriteLine("Les modules sont {0} {1} {2}", e1.modules[0], e1[1], e1.modules[2]);
        }
    }
}
