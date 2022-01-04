using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEcole.Models
{
    public class Groupe
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public int Nombre { get; set; }
        public ICollection<Etudiant> AllEtudiants { get; set; }

    }
}
