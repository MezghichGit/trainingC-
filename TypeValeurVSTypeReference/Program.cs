using System;
using System.Text;

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

            // exemple avec la classe StringBuilder(mutable)
            
            StringBuilder address = new StringBuilder();
            address.Append("23");
            address.Append(", Main Street");
            address.Append(", Buffalo");
            string concatenatedAddress = address.ToString();
            Console.WriteLine(address);


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
