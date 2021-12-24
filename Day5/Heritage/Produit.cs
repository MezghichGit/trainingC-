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

        public Produit(string lib, int stock)
        {
            Libelle = lib;
            Quantite = stock;

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
