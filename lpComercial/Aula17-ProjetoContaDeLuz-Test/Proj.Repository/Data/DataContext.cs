using Microsoft.EntityFrameworkCore;
using Proj.Domain.Entities;

namespace Proj.Repository.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<ContaRestaurante> ContasRestaurante { get; set; }
        public DbSet<Restaurante> Restaurantes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurante>()
                .HasMany<ContaRestaurante>(i => i.contasRestaurantes)
                .WithOne(c => c.restaurante)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}