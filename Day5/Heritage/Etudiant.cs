using System;
namespace Heritage
{
    class Etudiant:Personne
    {
        public sealed override void info()
        {
            base.info(); //appel à la méthode info de la classe mère
            Console.WriteLine("Adresse : " + Adresse);
        }

        public Etudiant(string adr) : base("aa",20)
        {
            Adresse = adr;
        }

        public Etudiant() : base("aa", 20)
        {
            Console.WriteLine("Constructeur par défaut de Etudiant");
        }
    }
}
