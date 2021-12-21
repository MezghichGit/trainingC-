using System;

namespace LesProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            CompteBancaire cb = new CompteBancaire();

            cb.Solde = 1000;  // c'est un appel à la property Solde en mode set

            Console.WriteLine(cb.Solde); // c'est une invocation de la property Solde en mode get


            Console.WriteLine("Valeur du découvert =" + cb.Decouvert);
            cb.MDP = 1223; // acces en mode set (ecriture)
            Console.WriteLine("Valeur du MDP =" + cb.MDP);// acces en mode get (lecture)

        }
    }
}
