using System;

namespace Day4_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            // animaux est une structure polymorphe
            Animal[] animaux = new Animal[4];
            animaux[0] = new Poisson();
            animaux[1] = new Oiseau();
            animaux[2] = new Chat();
            animaux[3] = new Serpent();

           foreach(Animal a in animaux)
           {
                a.seDeplacer();
           }
            /*
            ImprimanteLazerHP imp = new ImprimanteLazerHP();
            imp.photocopier();
            imp.scanner();
            imp.imprimer();

            //Imprimante i = new Imprimante();// une interface n'est pas instanciable

            C c1 = new C();  // instance de C
            c1.printA();
            c1.printB();
            c1.printC();

            I a1 = new A();
            A a2 = new A();

            a1.affichage();
            a1.info();
           
            a2.printA();
            a2.affichage();
            a2.info();*/

        }
    }
}
