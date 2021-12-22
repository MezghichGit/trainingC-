using System;

namespace TestException
{
    class Program
    {

        public static void genereparam(out string chaine)
        {
            chaine = "Hello C#";
            Console.WriteLine(chaine);
        }
        static void Main()
        {

            int[] tab = new int[3]; // declaration + initialisation avec des zéro
            int[] moy = {10, 12, 4, 6};  // declaration + initialisation

            //Console.WriteLine("tab[0] = " + tab[0]);
            //Console.WriteLine("taile de moy = {0} et moy[3] = {1}", moy.Length, moy[3]);
            string ch = null;

            /*
            while(true)
            {
                Console.WriteLine("Donner votre nom : ");
                ch = Console.ReadLine();
                if (ch.Length != 0)
                {
                    //ch = null;
                    break;
                }

            }*/
            

            try {

                

                //Console.WriteLine("Longueur de la chaine = " + ch.Length);
                for (int i = 0; i < moy.Length; i++)
                {
                    Console.WriteLine("moy[" + i + "]=" + moy[i]);
                }

                throw new Exception("Je declenche moi même une exception");
            }
            
            catch (IndexOutOfRangeException e)
            {

                Console.WriteLine("Attention tu sort du tabelau");
                Console.WriteLine(e.StackTrace);
                return;
            }
            catch(NullReferenceException e)
            {
                //Console.WriteLine("Réference sur un String null");
                Console.WriteLine("Votre chaine est invalide, essayer une autre");
                //Console.WriteLine(e.StackTrace);
            }
            catch (Exception e)
            {

                Console.WriteLine("Oups un problème : "+ e.Message);
                //Console.WriteLine(e.StackTrace);
            }

            finally { 
            Console.WriteLine("Fin du programme...merci et à bientôt");
            Console.ReadLine();
            }

            /*
            CompteBancaire cb = new CompteBancaire();

            cb.crediter(1000);
            cb.debiter(150);
            cb.debiter(150);
            cb.debiter(200);
            cb.debiter(200);
            cb.debiter(200);
            cb.debiter(200);
            cb.debiter(200);
            cb.getSolde();*/
            /*
             Etudiant e = new Etudiant();

             int res = e.info();*/

            //int a = e.getAge();

            /*
            string nom;  // non initialisé

            genereparam(out nom);

            Console.WriteLine("Message =" + nom);*/


            //string ch = null;

            /*
            string ch = "formation";
            try
            {
                Console.WriteLine(ch.Length);
            }
            
            finally { 
            Console.WriteLine("Fin du programme...");
            Console.ReadLine();
            }*/

        }
    }
}
