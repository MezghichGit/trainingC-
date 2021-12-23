using System;

namespace Heritage_Module5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            // Animal a = new Animal();
            Animal[] tab = new Animal[3];
            tab[0] = new Oiseau();
            tab[1] = new Poisson();
            tab[2] = new Serpent();
            foreach (Animal a in tab)
            {
                a.seDeplacer();
            }
        }
    }
}
