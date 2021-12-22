using System;

namespace SurchargeOperateurs
{
    class Program
    {
        struct Complexe {
            public double real;
            public double imag;

            public Complexe(double re,double im)
            {
                this.real = re;
                this.imag = im;
            }

            public static Complexe operator +(Complexe c1, Complexe c2)
            {
                return new Complexe(c1.real + c2.real, c1.imag + c2.imag);
            }
        }
        static void Main(string[] args)
        {
            Complexe z1 = new Complexe();
            z1.real = 1;
            z1.imag = 2;

            Complexe z2= new Complexe();
            z2.real = 4;
            z2.imag = 3;

            Complexe z3 = z1 + z2;
            Console.WriteLine(z3.real + " " + z3.imag);

            // l'operateur + est surchargé pour les opérandes nombre et string

            /*t x = 10;
            int y = 20;

            string formateur = "Amine";
            string organisme = "GK";

            Console.WriteLine(x + y);
            Console.WriteLine(formateur + " " + organisme);*/
        }
    }
}
