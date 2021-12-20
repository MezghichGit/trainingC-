using System;
using System.Text;
using System.Text.RegularExpressions;

namespace TypeValeurVSTypeReference
{
    //struct Point  // type valeur
    class Point   // type référence
    {
        public int Abcisse;
        public int Ordonné;
        public Point(int x, int y)
        {
            Abcisse = x;
            Ordonné = y;
        }
    }
    enum Planete
    {
        Mercure,
        Venus,
        Terre,
        Mars
    }

    enum Jour {LUNDI, MARDI}
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = new string[3];

            for (int i = 0; i < names.Length; i++)  // La boucle for classique
            {
                Console.WriteLine("Donner un nom");
                names[i] = Console.ReadLine();
            }


            foreach (string s in names)        // La boucle forach sur les collections
            {
                Console.WriteLine("Nom = {0} ", s);
            }

            // la structure à choix multiple switch
            /*
            string mois = "Janvier";

            switch (mois)
            {
                case "Janvier": Console.WriteLine("C'est l'hiver"); break;
                case "Mars": Console.WriteLine("C'est le printemps"); break;
                case "Juillet": Console.WriteLine("C'est l'été"); break;
                case "Octobre": Console.WriteLine("C'est l'automne"); break;
                default: Console.WriteLine("Je sais pas"); break;
            }*/
            /*
            var textToTest = "h00az111 world";
            var regularExpression = "^h\\d{2}az\\d{3}";

            var result = Regex.IsMatch(textToTest, regularExpression, RegexOptions.None);

            if (result)
            {
                Console.WriteLine("Votre chaine vérifie le critère");
            }
            else {
                Console.WriteLine("Votre chaine ne vérifie pas le critère");
            }*/


            /*string s1 = "formation c#";
           
            //String ch1 = new string("formation c#");
            //String ch2 = new string(s1);
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("abcabcabcabcabccb");
            Console.WriteLine(sb1.Capacity);
            Console.WriteLine(sb1.Length);
            //String ch2 = new string("formation c#");
            /*
            string s1 = "formation c#";
            string s2 = "formation c#";
            String ch1 = new string("formation c#");
            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1.Equals(s2));

            Console.WriteLine(s1 == ch1);
            Console.WriteLine(s1.Equals(ch1));*/

            /*StringBuilder sb1 = new StringBuilder("formation c#");
            StringBuilder sb2 = new StringBuilder("formation c#");
            Console.WriteLine(sb1 == sb2);*/
            // exemple avec la classe StringBuilder(mutable)

            /*StringBuilder address = new StringBuilder();
            address.Append("23");
            address.Append(", Main Street");
            address.Append(", Buffalo");
            string concatenatedAddress = address.ToString();
            Console.WriteLine(address);*/


            // exemple avec la classe String(immutable)
            /*
            String ch = new string("Formation C#");
            ch = ch.ToUpper();
            Console.WriteLine(ch);
            Console.WriteLine(ch.ToUpper());*/



            //int a = 4;
            //long b = a;
            //long b = 14;

            // a = (int)b;
            /*short x = -12;
            Console.WriteLine("Max dun byte  : {0} ", short.MaxValue);
            Console.WriteLine("Min dun byte  : {0} ", short.MinValue);*/
            //int x = -655372299;
            //short z = (short)x;

            //Console.WriteLine("Max dun short  : {0} ", short.MaxValue);
            //Console.WriteLine("valeur de z  : {0} ", z);
            //int age = 36;
            //Console.WriteLine("Vous avez : {0}", age);
            /*
            Planete maPlanete = Planete.Mercure;
            Console.WriteLine("{0}", maPlanete);


            Point P1 = new Point(1, 2);  // P1 c'est référence sur l'objet de type Point
            Point P2;
            P2 = P1;
            Console.WriteLine("coord. du point P1 =({0},{1})", P1.Abcisse, P1.Ordonné);  // 1, 2
            Console.WriteLine("coord. du point P2 =({0},{1})", P2.Abcisse, P2.Ordonné);  // 1, 2
            Console.WriteLine("---");
            Console.WriteLine("modification du Point P2");
            P2.Abcisse = 0;
            Console.WriteLine("coord. du point P1 =({0},{1})", P1.Abcisse, P1.Ordonné);
            Console.WriteLine("coord. du point P2 =({0},{1})", P2.Abcisse, P2.Ordonné);
            Console.ReadKey();*/

        }
    }
}
