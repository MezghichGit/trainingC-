using System;

namespace LesTableaux
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Etudiant e1 = new Etudiant(1,"Alain",15.5);

            Console.WriteLine("Vous êtes : {0}", e1.ToString());
            /*
            int compteur = 0;
            int x = 100;
            compteur++;

            compteur = compteur + 2;
            Console.WriteLine("La valeur de compteur = {0}", compteur);
            Console.WriteLine("La valeur de x = {0}", x);
            Console.WriteLine("Fin du programme.");*/
        }
    }
}
