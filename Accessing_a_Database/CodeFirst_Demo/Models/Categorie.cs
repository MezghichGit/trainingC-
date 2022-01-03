using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Demo.Models
{
    public class Categorie
    {
        public int Id { get; set; }
        public string Libelle { get; set; }

        public string Fournisseur { get; set; }

        public int NbrProduits { get; set; }

        public ICollection<Produit> AllProduits { get; set; }
    }
}

