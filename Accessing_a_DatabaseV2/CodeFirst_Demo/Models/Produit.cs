using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Demo.Models
{
    public class Produit
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public double Prix { get; set; }
        public DateTime Date { get; set; }
        public int IdCategorie { get; set; }
        public Categorie Categorie { get; set; }
    }
}
