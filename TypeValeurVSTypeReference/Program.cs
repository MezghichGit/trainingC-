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

            // correction exo 1 part 2

            Console.WriteLine("Citez un mois (en nombre) ?");
            string valeurMois = Console.ReadLine();

            int mois = int.Parse(valeurMois);
            Console.WriteLine("vous avez choisi ce moi : {0}", mois);

            switch (mois)
            {
                case 1 or 2 or 3:
                    Console.WriteLine("On est en hiver !"); break;
                case 4 or 5 or 6:
                    Console.WriteLine("On est au printemps !"); break;
                case 7 or 8 or 9:
                    Console.WriteLine("On est en été !"); break;
                case 10 or 11 or 12:
                    Console.WriteLine("On est en automne !"); break;
                default:
                    Console.WriteLine("vous êtes débiles !?!"); break;
            }


            /*
            Console.WriteLine("**************** Les matrices *************");
            int[,] mat = new int[2, 2];
            mat[0, 0] = 1;
            mat[0, 1] = 2;
            mat[1, 0] = 10;
            mat[1, 1] = 20;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                    {
                        Console.Write(mat[i,j]+"\t");
                    }
            }


            Console.WriteLine("\n**************** Jagged Array *************");
            // Les Jagged Array

            int[][] tab = new int[3][];
            tab[0] = new int[4];
            tab[1] = new int[2];
            tab[2] = new int[3];

            tab[0][0] = 1;
            tab[0][1] = 2;
            tab[0][2] = 3;
            tab[0][3] = 4;

            tab[1][0] = 10;
            tab[1][1] = 20;

            tab[2][0] = 100;
            tab[2][1] = 200;
            tab[2][2] = 300;

            foreach (int[] t in tab)
            {
                foreach (int s in t)
                {
                    Console.Write(s +"\t");
                }
                Console.WriteLine();
            }



            // Correction exo 1
            /*
            Console.WriteLine("Donner une moyenne :");
            string valeur = Console.ReadLine();
            char separator = ',';
            valeur = valeur.Replace('.', separator);
            var moy = double.Parse(valeur);
            
            if(moy>=0 && moy <10) Console.WriteLine("Redouble");
            else if (moy >= 10 && moy < 14) Console.WriteLine("Assez bien");
            else if (moy >= 14 && moy < 16) Console.WriteLine("Bien");
            else if (moy >= 16 && moy <= 20) Console.WriteLine("Très Bien");
            else  Console.WriteLine("Moyenne invalide!");*/

            //Console.WriteLine("Vous avez taper {0}", moy);
            //Console.WriteLine(moy + 2);




            /*
            string[] names = new string[3];

            for (int i = 0; i < names.Length; i++)  // La boucle for classique
            {
                Console.WriteLine("Donner un nom");
                names[i] = Console.ReadLine();
            }


            foreach (string s in names)        // La boucle forach sur les collections
            {
                Console.WriteLine("Nom = {0} ", s);
            }*/

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
