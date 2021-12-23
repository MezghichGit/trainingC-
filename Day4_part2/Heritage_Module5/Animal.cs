using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage_Module5
{
    abstract class Animal
    {
        // méthode abstraite dans la classe abstraite
        public abstract void seDeplacer();
        
        int age;
        string espece;

        public void manger()
        {
            Console.WriteLine("J'ai faim je veux manger");
        }
    }
}
