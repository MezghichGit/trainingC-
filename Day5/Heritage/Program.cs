using System;

namespace Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Produit p = new Produit("Jus", 100, new DateTime(2021, 12, 26, 8, 30, 52)
);

            try
            {
                p.verifProduit();
            }
            catch (ProduitExpireException exception)
            {
                Console.WriteLine(exception.Message);
            }
            Console.WriteLine("Fin programme");



            /*
            Produit p = new Produit("PC", 20);

            try
            {
                p.acheterProduit(100);
            }
            catch (ProduitEpuiseException e)
            {
                Console.WriteLine(e.Message);
            }*/

            
            /*C instance = new C(10, 20);
            Console.ReadLine();*/
            //BB b = new BB();

            //A a = new A(2);

            //Etudiant e = new Etudiant();
            //Etudiant e1 = new Etudiant("Paris");
            // e1.Nom = "Olivier";
            // e1.Age = 22;

            //e1.info();

            /* Personne p = new Personne
             {
                 Nom = "Toto",
                 Age = 20
             };*/
            /*
             Animal a = new Animal {
             Espece ="Chien",
             Age = 2

             };*/
        }
    }
}
