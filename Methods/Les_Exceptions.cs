using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Les_Exceptions
    {
        private const string Message = "Un autre problème...";

        public static void Main()
        {
            int x = 10;
            int y = 0;
            try
            {
                Console.WriteLine(x / y);
            }

            catch (DivideByZeroException ex)
            {
                
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                try
                {
                    throw;//new Exception(Message);
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
            }
            finally{
                Console.WriteLine("Fin du programme...");
            }
        }

    }
}
