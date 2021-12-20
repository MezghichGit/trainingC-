using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string formation = "Certification en C#";

            string codeCertif = "20483";
            //Console.WriteLine("Hello World!");

            Console.WriteLine("Formation : {0} le code : {1}", formation, codeCertif);  // message mixte
            */

            Console.WriteLine("Donner votre nom : ");
            string nom = Console.ReadLine();
            Console.WriteLine("Vous êtes : {0}", nom);

        }
    }
}
