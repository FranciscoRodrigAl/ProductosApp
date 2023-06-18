using Microsoft.EntityFrameworkCore;
namespace productosApp.Models
{
    public class ProductosContext:DbContext
    {
        public ProductosContext(DbContextOptions<ProductosContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Categoria>()
                .HasMany(c => c.Productos)
                .WithOne(p => p.Categoria)
                .HasForeignKey(p => p.CategoriaId);
        }

    }
}
