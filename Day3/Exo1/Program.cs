using System;

namespace Exo1
{
    class Program
    {
        //Exercice 1
        enum Mention { Faible, Moyen, Bien, Excellent };

        struct Etudiant
        {
            // attributs
            private int id;
            private string name;
            private Mention[] mentions;

            // Ajout d'un indexer
            public Mention this[int index] // Indexers
            {
                get { return this.mentions[index]; }
                set { this.mentions[index] = value; }
                //e1 [0] (this.mentions[0]) = Mention.Bien(value);
            }

            // Ajout des properties
            public int Id
            {
                get { return this.id; }
                set { this.id = value; }
            }
           /* public int Id
            {
                get;
                set;
            }*/
            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }

            // Constructeurs
            public Etudiant(int id, string name)
            {
                this.id = id;
                this.name = name;
                this.mentions = new Mention[4];
            }
        }

        static void Main(string[] args)
        {
            Etudiant e1 = new Etudiant(0, "bob");
            e1.Id = 0;
            e1.Name = "Bob";
            e1[0] = Mention.Bien;
            e1[1] = Mention.Bien;
            e1[2] = Mention.Excellent;
            e1[3] = Mention.Faible;

            Console.WriteLine("L'étudiant : {0} possède l'identifiant : {1}", e1.Name, e1.Id);
            Console.WriteLine("Ses notes sont {0}, {1}, {2} et {3}", e1[0], e1[1], e1[2], e1[3]);

        }

    }
}
