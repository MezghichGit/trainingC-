using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesEvenements
{
    class SubscriberToEventInvalideString
    {
        public static void callEventInvalideString()
        {
            Console.WriteLine("Votre chaine est trop longue");
        }


        public static void secondCall()
        {
            Console.WriteLine("Merci de changer la chaine");
        }
        public static void Main()
        {
            Console.WriteLine("Entrez une mot contenant moins de 8 caractères :");
            string ch = Console.ReadLine();

            Console.WriteLine("\t Première instance.....");


            ControlString cs1 = new ControlString();
            cs1.ev_LongueurInvalide += new ControlString.dg_LongueurInvalide(callEventInvalideString);
            cs1.ev_LongueurInvalide += new ControlString.dg_LongueurInvalide(secondCall);
            cs1.CheckString(ch);


            Console.WriteLine("\t Deuxième instance.....");
            ControlString cs2 = new ControlString();
           
            cs2.ev_LongueurInvalide += new ControlString.dg_LongueurInvalide(secondCall);
            cs2.CheckString(ch);

        }
    }
}
