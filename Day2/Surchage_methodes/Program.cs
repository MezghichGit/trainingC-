using System;

namespace Surchage_methodes
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Operations op1 = new Operations();
            Operations op2 = new Operations();
            op1.x = 10;
            op1.y = 11;

            op2.x = 20;
            op2.y = 21;
            Console.WriteLine(op1.x + " " + op1.y);
            Console.WriteLine(op2.x + " " + op2.y);
            Console.WriteLine("valeur initiale de nb = " +Operations.nb);
            Console.WriteLine("Modifications de l' attribut static nb");


            op1.modifNb(); // modification par la première instance
            Console.WriteLine("nb après modif de op1 = " +Operations.nb);
            op2.modifNb(); // modification par la deuxième instance
            Console.WriteLine("nb après modif de op2 = " + Operations.nb);

            //op1.somme(10.5, 20);
            //Console.WriteLine("Hello World!");
        }
    }
}
