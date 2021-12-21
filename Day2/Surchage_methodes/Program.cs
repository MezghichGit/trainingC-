using System;

namespace Surchage_methodes
{
    class Program
    {
        
        static void Main(string[] args)
        {

            const int y = 10;
            //y++;
            int x = 10;
            double moy = 12.5;
            String ch = new String("abc"); // dans le heap
            string s = "formation";  // dans le stack
            Personne p = new Personne(); // appel au constructeur par défaut

            Console.WriteLine(x.GetHashCode());
            Console.WriteLine(p.GetHashCode());
            /*
            Console.WriteLine("Nombre initiale d'instance créer = " + Voiture.nbV);
            Voiture v1 = new Voiture();  // appel au constructeur par défaut
            // nbV = 1
            Voiture v2 = new Voiture(1,"Amine", "Peugeot");// appel au constructeur avec param
           // nbV = 2
            Voiture v3 = new Voiture(2, "Olivier", "BMW"); // appel au constructeur avec param
           // nbV = 3
           Console.WriteLine("Nombre finale d'instance créer = " + Voiture.nbV);

            Voiture.getNombreVoiture();  // appel à une méthode statique

            v1.info(); // appel à une méthode d'instance
            v2.info(); // appel à une méthode d'instance
            */
            /*
            Operations op1 = new Operations();
            Operations op2 = new Operations();
            op1.x = 10;
            op1.y = 11;

            op2.x = 20;
            op2.y = 21;
            Console.WriteLine(op1.x + " " + op1.y);
            Console.WriteLine(op2.x + " " + op2.y);
            Console.WriteLine("valeur initiale de nb = " +Operations.nb);
            Console.WriteLine("Modifications de l' attribut static nb");


            op1.modifNb(); // modification par la première instance
            Console.WriteLine("nb après modif de op1 = " +Operations.nb);
            op2.modifNb(); // modification par la deuxième instance
            Console.WriteLine("nb après modif de op2 = " + Operations.nb);
            */
            //op1.somme(10.5, 20);
            //Console.WriteLine("Hello World!");
        }
    }
}
