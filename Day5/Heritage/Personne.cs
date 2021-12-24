using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Personne
    {
        public string Nom { get; set; }
        public int Age { get; set; }

        protected string Adresse { get; set; }
        public virtual void info()
        {
            Console.WriteLine("Nom : " + Nom + " Age : " + Age);
        }
        public Personne(string nom, int age)
        {
            Nom = nom;
            Age = age;
        
        }

        /*public Personne()
        {
            Console.WriteLine("Constructeur par défaut de Personne");
        }*/
    }
}
