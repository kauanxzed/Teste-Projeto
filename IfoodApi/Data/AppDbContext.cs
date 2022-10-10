using IfoodApi.Models;
using Microsoft.EntityFrameworkCore;

namespace IfoodApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
