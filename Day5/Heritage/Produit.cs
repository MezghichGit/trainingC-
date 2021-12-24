using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Produit
    {
        public string Libelle;
        public int Quantite;
        public DateTime DateExpiration { get; set; }


        public Produit(string lib, int stock)
        {
            Libelle = lib;
            Quantite = stock;

        }

        //Constructeur avec 3 paramètres
        public Produit(string lib, int stock, DateTime dlc)
        {
            Libelle = lib;
            Quantite = stock;
            DateExpiration = dlc;

        }


        public void verifProduit()
        {
            if (DateExpiration > DateTime.Today)
            {
                Console.WriteLine("Le produit est encore bon");

            }
            else
            {
                throw new ProduitExpireException("Mieux vaut ne pas consommer ce produit..");
            }
        }

        public void acheterProduit(int nbre)
        {
            if (Quantite > nbre)
            {
                Quantite = Quantite - nbre;
            }
            else {
                // déclencher une exception
                throw new ProduitEpuiseException("Attention...");
            }
        }
    }
}
