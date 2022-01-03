using System;
using CodeFirst_Demo.Models;
using System.Linq;
using System.Collections.Generic;

namespace CodeFirst_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Ajout de catégorie...");
            insertCategorie();
            Console.WriteLine("Insertion avec succès");*/
            readCategories();
            updateCategorie();
            //deleteCategorie();
            readCategories();
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
                Categorie categorie = db.Categories.Find(2);
                categorie.Fournisseur = "Mac Donald";
                categorie.NbrProduits = 10;
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
        static void insertCategorie()
        {
            using (var db = new EFContext())
            {
                Categorie categorie = new Categorie();
                categorie.Libelle = "Sport";
                db.Add(categorie);

                categorie = new Categorie();
                categorie.Libelle = "Food";
                db.Add(categorie);

                db.SaveChanges();
            }
            return;
        }
    }
}
