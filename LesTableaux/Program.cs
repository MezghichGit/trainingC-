using System;

namespace LesTableaux
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Etudiant e1 = new Etudiant(1,"Alain",15.5);
            Etudiant e2 = new Etudiant(2, "Olivier", 17.5);
            Etudiant e3 = new Etudiant(3, "Mathieu", 12.5);
            Etudiant e4 = new Etudiant(4, "Claude", 11.5);

            Etudiant[] tab = new Etudiant[4];
            tab[0] = e1;
            tab[1] = e2;
            tab[2] = e3;
            tab[3] = e4;
            foreach (Etudiant e in tab)
            {
                Console.WriteLine(e.ToString());
            }



            //Console.WriteLine("Vous êtes : {0}", e1.ToString());
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
