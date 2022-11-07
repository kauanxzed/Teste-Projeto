using Microsoft.EntityFrameworkCore;
using IfoodApi.Models;

namespace IfoodApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Address>()
                .HasOne(address => address.Restaurante)
                .WithOne(restaurante => restaurante.Address)
                .HasForeignKey<Restaurante>(restaurante => restaurante.AddressId);

            builder.Entity<Produto>()
                .HasOne(produtos => produtos.Restaurante)
                .WithMany(restaurante => restaurante.Produtos)
                .HasForeignKey(produtos => produtos.RestauranteId);
        }

        public DbSet<Restaurante> Restaurantes { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
