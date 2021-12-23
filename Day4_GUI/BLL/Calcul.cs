using System;

namespace BLL
{
    public class Calcul
    {
        public static double somme(double x, double y)
        {
            return x + y;
        }

        public static double produit(double x, double y)
        {
            return x * y;
        }

        public static double diff(double x, double y)
        {
            return x - y;
        }

        public static double div(double x, double y)
        {
            return x / y;
        }

        public static double mod(double x, double y)
        {
            return x % y;
        }

        public static double puiss(double x, double y)
        {
            return Math.Pow(x,y);
        }
    }
}
