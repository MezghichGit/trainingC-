using System;
using System.Reflection;

namespace ConsommateurMyAssembly
{
    class TestMathsUtil
    {
        static void Main(string[] args)
        {
            //
            // 1. Load assembly "MyAssembly.dll" from file path. Specify that we will be using class MyAssembly.MyClass
            //
            Assembly asm = Assembly.LoadFrom(@"C:\Users\amine\Desktop\Testing\BibUtile.dll");
            Type t1 = asm.GetType("BibUtile.Calcul");
            Console.WriteLine("Le type t est = " + t1);
            var methods = t1.GetMethods();
            for(int i=0; i<methods.Length;i++)
            Console.WriteLine(methods[i]);
           


            Type t2 = asm.GetType("BibUtile.Personne");
            Console.WriteLine("Le type t est = " + t2);
            var methods2 = t2.GetMethods();
            for (int i = 0; i < methods2.Length; i++)
                Console.WriteLine(methods2[i]);
        }
        }
}
