using Microsoft.EntityFrameworkCore;

namespace EvaluacionWeb.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Venta> Venta { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurar relaciones si deseas ser más explícito (opcional)
            modelBuilder.Entity<Categoria>()
                .HasMany(c => c.Producto)
                .WithOne(p => p.Categoria)
                .HasForeignKey(p => p.CategoriaCodigoCategoria);

            modelBuilder.Entity<Producto>()
                .HasMany(p => p.Venta)
                .WithOne(v => v.Producto)
                .HasForeignKey(v => v.ProductoCodigoProducto);
        }
    }
}
