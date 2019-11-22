using Microsoft.EntityFrameworkCore;
using Proj.Domain.Entities;

namespace Proj.Repository.Data
{    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Restaurante> Restaurantes { get; set; }
        public DbSet<Consumo> Consumos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurante>() //relacionamento oneToMany
                .HasMany<Consumo>(r => r.consumo)
                .WithOne(c => c.restaurante)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
