using Microsoft.EntityFrameworkCore;
using GymAPI.Models;

namespace GymAPI.Data
{
    public class GymDbContext : DbContext
    {
        public GymDbContext(DbContextOptions<GymDbContext> options) : base(options)
        {
        }

        // DbSet: representa la tabla Clientes en la base de datos
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(c => c.IdCliente);
                entity.Property(c => c.Nombre).IsRequired().HasMaxLength(100);
                entity.Property(c => c.CuotaMensual).HasColumnType("decimal(10,2)");
            });
        }
    }
}
