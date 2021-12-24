using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Serialization_Deserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Product product = new Product();

            product.Name = "Apple";
            product.ExpiryDate = new DateTime(2008, 12, 28);
            product.Price = 3.99;
            product.Sizes = new string[] { "Small", "Medium", "Large" };

            string output = JsonConvert.SerializeObject(product);
            Console.WriteLine(output);

            Product deserializedProduct = JsonConvert.DeserializeObject<Product>(output);
            Console.WriteLine(deserializedProduct.Name);*/

            // Correction exo 2

            /*
            Etudiant e1 = new Etudiant("Amine", 22);
            Etudiant e2 = new Etudiant("Olivier", 21);

            string path = @"C:\Users\amine\Desktop\Lab\students.txt";
            if (!File.Exists(path))
            {
               
                File.WriteAllText(path, "", Encoding.UTF8); // creation
            }

            Console.WriteLine("Début de la sérialization des Objets");
            //serialisation du premier objet pointé par e1
            string serE1 = JsonConvert.SerializeObject(e1);
            serE1 = serE1 + Environment.NewLine;
            // sauvegarde de cette chaine dans un fichier locale
            File.AppendAllText(path, serE1, Encoding.UTF8);

            //serialisation du premier objet pointé par e2
            string serE2 = JsonConvert.SerializeObject(e2);
            serE2 = serE2 + Environment.NewLine;
            // sauvegarde de cette chaine dans un fichier locale
            File.AppendAllText(path, serE2, Encoding.UTF8);

            Console.WriteLine("Fin de la sérialization des Objets");

            Console.WriteLine("******* Début de la déserialization *******");

            foreach (string line in File.ReadLines(path))
            {
                Etudiant e = JsonConvert.DeserializeObject<Etudiant>(line);
                Console.WriteLine(e.Name+" "+e.Age);

            }
            */

            // Exo 3

            CompteBancaire cb = new CompteBancaire();
            string path = @"C:\Users\amine\Desktop\Lab\cb.txt";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Entrez le propriétaire du compte");
                cb.Prop = Console.ReadLine();
                Console.WriteLine("Entrez le solde de ce compte");
                cb.Solde = Double.Parse(Console.ReadLine()); // conversion

                string output = JsonConvert.SerializeObject(cb) + Environment.NewLine;

                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    File.WriteAllText(path, output, Encoding.UTF8); // creation
                }
                else
                {
                    File.AppendAllText(path, output, Encoding.UTF8); // ajout
                }
            }

            List<CompteBancaire> list = new List<CompteBancaire>(); // Liste générique

            foreach (string line in File.ReadAllLines(path))
            {
                CompteBancaire deserialized_cb = JsonConvert.DeserializeObject<CompteBancaire>(line);
                list.Add(deserialized_cb);
            }

            list.Sort();  // tri décsoissant sur le solde du compte
            foreach (CompteBancaire c in list)
            { 
                c.print(); 
            }

        }
    }
}
