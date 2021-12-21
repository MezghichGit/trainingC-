using System;

namespace MethodesDextensionDeType
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "formation en programmation c#";
            int nbr = phrase.wordCount();
            Console.WriteLine("nbr = "+nbr);
            string ch= "c";
            Console.WriteLine(ch.FirstLetterUpperCase());

            string nom = "Amine";
            Console.WriteLine(nom.addDrFirst());
        }
    }
}
