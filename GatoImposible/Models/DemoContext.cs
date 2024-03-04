using GatoImposible.Models;
//using DemoSQL.Models;
using Microsoft.EntityFrameworkCore;

namespace GatoImposible.Models
{
    class DemoContext : DbContext
    {
        public DemoContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=MSI\SQLEXPRESS;Database=GatoImposible;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Partida> Partidas { get; set; }
    }
}

