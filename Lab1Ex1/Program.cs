using System;
using MessageProvider;
namespace Lab1Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello from C#!");

            String msg = Provider.GetMessage();
            String msgPerson = Person.InfoPerson();
            Console.WriteLine("Les deux messages du VB dans C# sont : {0} - {1} ",msg, msgPerson);

        }
    }
}
