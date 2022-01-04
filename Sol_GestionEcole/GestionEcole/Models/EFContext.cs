using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEcole.Models
{
    public class EFContext : DbContext
    {
        private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=GestionEcole;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Etudiant>()
            .HasOne<Groupe>(p => p.Groupe)
            .WithMany(c => c.AllEtudiants)
            .HasForeignKey(p => p.IdGroupe);
        }

        public DbSet<Groupe> DAOGroupes { get; set; }
        public DbSet<Etudiant> DAOEtudiants { get; set; }

    }
}
