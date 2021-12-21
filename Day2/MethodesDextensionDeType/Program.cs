using System;

namespace MethodesDextensionDeType
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Formation en programmation c#";
            int nbr = phrase.wordCount();
            Console.WriteLine("nbr = "+nbr);
        }
    }
}
