using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre1_structure_enum
{

class Personne
    {
        public string[] plat_preferes;
        //int taille =0;


        public string this[int index]
        {
            get { return this.plat_preferes[index]; }
            set { this.plat_preferes[index] = value; }

        }

        public Personne(int nbPlats, params string[] x) {
           // this.taille = nbPlats;
            this.plat_preferes = new string[nbPlats];

            for (int i = 0; i < x.Length; i++) {
                plat_preferes[i] = x[i]; 
            } 
        }

    }

    class Test
    {
        public static void Main()
        {

            //Personne bobby = new Personne(3, new string[] { "choucroute", "tartiflette", "salade composee" });
            Personne bobby = new Personne(3, "choucroute", "tartiflette", "salade composee" );

            //bobby.plat_preferes[1] = "kebab";
            bobby[0] = "fish";  // indexeur en mode set

            Console.WriteLine("Valeur = " +  bobby[0]); // indexeur en mode get
            Console.WriteLine("Valeur = "+ bobby[1]);  // indexeur en mode get
            Console.WriteLine("Valeur = " + bobby[2]); // indexeur en mode get
        }
    }

}
