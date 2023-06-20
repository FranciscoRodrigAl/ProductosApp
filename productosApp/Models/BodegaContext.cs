using Microsoft.EntityFrameworkCore;
namespace productosApp.Models
{
    public class BodegaContext:DbContext
    {
        public BodegaContext(DbContextOptions<BodegaContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Categoria>()
                .HasMany(c => c.Productos)
                .WithOne(p => p.Categoria)
                .HasForeignKey(p => p.CategoriaId);
        }

    }
}
