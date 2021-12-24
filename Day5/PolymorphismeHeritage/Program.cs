using System;

namespace PolymorphismeHeritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t0 = new Triangle();
            Shape s = t0; // Conversion de type UpCasting
            // Shape s = new Triangle(); // UpCasting


            //Shape s = new Shape();
            
            Triangle t = (Triangle) s; // DownCasting + Cast Explicite + UpCast Avant
            Console.WriteLine("Fin du programme...");

            Triangle t2 = new Triangle();
            Rectangle r2 = new Rectangle();
            //t2 = r2;
            //r2 = t2;




        }
    }
}
