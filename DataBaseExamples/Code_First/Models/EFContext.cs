using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Code_First.Models
{
    public class EFContext : DbContext
    {

        private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=ams;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Product> Products { get; set; }

    }
}
