using BoletoBusMaMonolitica.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BoletoBusMaMonolitica.Data.Context
{
    public class BoletoBusContext : DbContext
    {
        public BoletoBusContext(DbContextOptions<BoletoBusContext> options)
            : base(options)
        {
        }

        public DbSet<Ruta> Ruta { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Ruta>(entity =>
            {
                entity.HasKey(e => e.IdRuta);
            });
        }
    }
}