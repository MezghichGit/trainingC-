using System;

namespace Gestion_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 0;
            string ch = null;
            int[] tab = new int[2];

            try
            {
                Console.WriteLine(tab[4]);
                //Console.WriteLine("x/y = " + (x / y));
                //Console.WriteLine(ch.Length);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Problème de division par zéro...");

            }

            catch (Exception ex)
            {
                Console.WriteLine("Problème Attention...");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return;
            }

            finally {
               Console.WriteLine("Suite du programme...");
             }

            /**/
            /*catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Problème d'indice de tableau...");
            }*/






           
        }
    }
}
