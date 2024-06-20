using BoletoBusMaMonolitica.Data.Entities;
using Microsoft.EntityFrameworkCore;
using BoletoBusMaMonolitica.Data.Models;

namespace BoletoBusMaMonolitica.Data.Context
{
    public class BoletoBusContext : DbContext
    {
        #region "Constructor"
        public BoletoBusContext(DbContextOptions<BoletoBusContext> options)
            :base(options) 
        {
        }
        #endregion

        #region "Db Sets"
        public DbSet<Bus> Bus { get; set; }
        public DbSet<Asiento> Asiento { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Bus>(entity =>
            {
                entity.HasKey(e => e.IdBus);
                entity.Property(e => e.CapacidadTotal).HasComputedColumnSql("[CapacidadPiso1] + [CapacidadPiso2]");
            });

            modelBuilder.Entity<Asiento>(entity =>
            {
                entity.HasKey(e => e.IdAsiento);
            });
        }
        public DbSet<AsientoGetModel> AsientoGetModel { get; set; } = default!;
        public DbSet<AsientoUpdateModel> AsientoUpdateModel {  get; set; } = default!;
        public DbSet<AsientoSaveModel> AsientoSaveModel { get; set; } = default!;
        public DbSet<BusGetModel> BusGetModel { get; set; } = default!;
        public DbSet<BusSaveModel> BusSaveModel { get; set; } = default!;
        public DbSet<BusUpdateModel> BusUpdateModel { get; set; } = default!;
        
    }
}
