using System;
using CodeFirst_Demo.Models;
using System.Collections.Generic;
using System.Linq;
namespace CodeFirst_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("************** Ajout de catégorie **************");
            Console.WriteLine("Donner le libellé");
            string libelle = Console.ReadLine();
            insertCategorie(libelle);
            Console.WriteLine("Insertion avec succès");
            */
            //readCategories();
            //updateCategorie();
            //deleteCategorie();
            //readCategories();

            Console.WriteLine("quel titre ?");
            string titre = Console.ReadLine();

            Console.WriteLine("quel prix ?");
            float prix = float.Parse(Console.ReadLine());

            Console.WriteLine("quel date ?");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("quel idCategorie ?");
            int idC = int.Parse(Console.ReadLine());

           // insertProduit(titre, prix, date, idC);
          
           // readProduit();
        }
        /*
        static void insertProduit(string a, float b, DateTime c, int d)
        {
            using (var db = new EFContext())
            {
                Produit prod = new Produit();
                prod.Titre = a;
                prod.Prix = b;
                prod.Date = c;
                prod.IdCategorie = d;
                db.Add(prod);
                db.SaveChanges();
            }
            return;
        }

        static void readProduit()
        {
            using (var db = new EFContext())
            {
                List<Produit> produits = db.Produits.ToList();
                foreach (Produit p in produits)
                {
                    Console.WriteLine("{0} {1} {2} {3} {4}", p.Id, p.Titre, p.Prix, p.Date, p.IdCategorie);
                    Categorie c = db.Categories.Find(p.IdCategorie);
                    Console.WriteLine("{0} {1} {2} {3}", c.Id, c.Libelle, c.Fournisseur, c.NbrProduits);
                }
            }
            return;
        }

        




        static void deleteCategorie()
        {
            using (var db = new EFContext())
            {
                Categorie categorie = db.Categories.Find(1);
                db.Categories.Remove(categorie);
                db.SaveChanges();
            }
            return;
        }
        static void updateCategorie()
        {
            using (var db = new EFContext())
            {
                Categorie categorie2 = db.Categories.Find(2);
               
                categorie2.Fournisseur = "Mac Donald";
                categorie2.NbrProduits = 15;
               
                Categorie categorie3 = db.Categories.Find(3);
                categorie3.Fournisseur = "Oracle";
                categorie3.NbrProduits = 12;

                Categorie categorie4 = db.Categories.Find(4);
                categorie4.Fournisseur = "Mercred";
                categorie4.NbrProduits = 10;

                db.SaveChanges();
            }
            return;
        }

        static void readCategories()
        {
            using (var db = new EFContext())
            {
                List<Categorie> categories = db.Categories.ToList();
                foreach (Categorie c in categories)
                {
                    Console.WriteLine("{0} {1} {2} {3}", c.Id, c.Libelle, c.Fournisseur, c.NbrProduits);
                }
            }
            return;
        }
        static void insertCategorie(string libelle)
        {
            using (var db = new EFContext())
            {
                Categorie categorie = new Categorie();
                categorie.Libelle = libelle;
                db.Add(categorie);
                db.SaveChanges();

                categorie = new Categorie();
                categorie.Libelle = "Food";
                db.Add(categorie);


            }
            return;
        }*/
    }
}
