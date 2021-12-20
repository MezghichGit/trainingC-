using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesTableaux
{
    class Etudiant
    {
        private int id;
        private string nom;
        private double moyenne;
        public Etudiant(int id, string nom, double moyenne) // constructeur
        {
            this.id = id;
            this.nom = nom;
            this.moyenne = moyenne;
        }
        override
        public string ToString()  // méthode 
        { 
            return "Etudiant = [ID : "+ this.id +", Nom : "+this.nom +", Moyenne : " +this.moyenne+"]";
        }

    }
}
