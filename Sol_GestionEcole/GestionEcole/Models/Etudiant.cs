using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEcole.Models
{
    public class Etudiant
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int IdGroupe { get; set; }
        public Groupe Groupe { get; set; }

    }
}
