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

            public static Complexe operator +(Complexe c1, double x)
            {
                return new Complexe(c1.real + x, c1.imag);
            }

            public static Complexe operator -(Complexe c1, Complexe c2)
            {
                return new Complexe(c1.real - c2.real, c1.imag - c2.imag);
            }

            public static Complexe operator *(Complexe c1, Complexe c2)
            {
                return new Complexe((c1.real * c2.real)- (c1.imag * c2.imag), (c1.real * c2.imag) + (c1.imag * c2.real));
            }

            public static implicit operator Complexe(double x) // conversion de double vers Complexe 
            {
                return new Complexe(x, 0);
            }

            public static implicit operator double(Complexe z) // conversion de Complexe  vers double
            {
                return z.real;
            }
        }
        static void Main(string[] args)
        {
            Complexe z1 = new Complexe();
            z1.real = 1;
            z1.imag = 4;

            Complexe z2= new Complexe();
            z2.real = 5;
            z2.imag = 1;

            Complexe z3 = z1 * z2;
            Console.WriteLine(z3.real + " " + z3.imag);

            Complexe z4 = z1 + (double)2;

            double a = 4;
            Complexe z5 = a; // conversion de double vers Complexe // z5.real = 4; z5.imag = 0

            Console.WriteLine(z5.real + " " + z5.imag);
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
