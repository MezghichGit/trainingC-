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
            /*
            Assembly asm = Assembly.LoadFrom(@"C:\Users\amine\Desktop\Testing\MaBib.dll");
            var totalTypesInAssembly = asm.GetTypes();
            Console.WriteLine("Les types dans l'Assembly ******************");
            for (int i = 0; i < totalTypesInAssembly.Length; i++)
                Console.WriteLine(totalTypesInAssembly[i]);


            
            Type t1 = asm.GetType("MaBib.MyClass");
            Console.WriteLine("\nLe type t est = " + t1);
            Console.WriteLine("\nLes méthodes ******************");
            var methods = t1.GetMethods();
            for(int i=0; i<methods.Length;i++)
            Console.WriteLine(methods[i]);
            Console.WriteLine("\nLes constructeurs ******************");
            var constructors = t1.GetConstructors();
            for (int i = 0; i < constructors.Length; i++)
                Console.WriteLine(constructors[i]);

            
           */
            /*
            Console.WriteLine("Invocation d'un méthode d'instance d'un type de l'assembly");
            //
            // 1. Load assembly "MaBiby.dll" from file path. Specify that we will be using class MyAssembly.MyClass
            //
            Assembly asm = Assembly.LoadFrom(@"C:\Users\amine\Desktop\Testing\MaBib.dll");
            Type t = asm.GetType("MaBib.MyClass");

            //
            // 2. We will be invoking a method: 'public int MyMethod(int count, string text)'
            //
            var methodInfo = t.GetMethod("MyMethod", new Type[] { typeof(int), typeof(string) });
            if (methodInfo == null)
            {
                // never throw generic Exception - replace this with some other exception type
                throw new Exception("No such method exists.");
            }

            //
            // 3. Define parameters for class constructor 'MyClass(int initialX, int initialY)'
            //
            object[] constructorParameters = new object[2];
            constructorParameters[0] = 999; // First parameter.
            constructorParameters[1] = 2;   // Second parameter.

            //
            // 4. Create instance of MyClass.
            //
            var o = Activator.CreateInstance(t, constructorParameters);

            //
            // 5. Specify parameters for the method we will be invoking: 'int MyMethod(int count, string text)'
            //
            object[] parameters = new object[2];
            parameters[0] = 124;            // 'count' parameter
            parameters[1] = "Some text.";   // 'text' parameter

            //
            // 6. Invoke method 'int MyMethod(int count, string text)'
            //
            var r = methodInfo.Invoke(o, parameters);
            Console.WriteLine(r);
            */

            Console.WriteLine("Invocation d'un méthode statique d'un type de l'assembly");
            Assembly asm = Assembly.LoadFrom(@"C:\Users\amine\Desktop\Testing\MaBib.dll");
            Type t = asm.GetType("MaBib.MyClass");
            var methodInfoStatic = t.GetMethod("StaticMethod");
            if (methodInfoStatic == null)
            {
                // never throw generic Exception - replace this with some other exception type
                throw new Exception("No such static method exists.");
            }

            // Specify parameters for static method: 'public static void MyMethod(int count, float radius)'
            object[] staticParameters = new object[2];
            staticParameters[0] = 10;
            staticParameters[1] = 3.14159f;
         
            // Invoke static method
            methodInfoStatic.Invoke(t, staticParameters);


        }
    }
}
