using Microsoft.EntityFrameworkCore;
namespace CodeFirst_Demo.Models
{
    public class EFContext : DbContext
    {

        private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=AMS;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                modelBuilder.Entity<Produit>()
                .HasOne<Categorie>(p => p.Categorie)
                .WithMany(c => c.AllProduits)
                .HasForeignKey(p => p.IdCategorie);
        }

        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Produit> Produits { get; set; }

    }
}
