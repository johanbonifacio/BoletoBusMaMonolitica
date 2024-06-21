using BoletoBusMaMonolitica.Data.Entities;
using BoletoBusMaMonolitica.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BoletoBusMaMonolitica.Data.Context
{
    

        public class BoletoBusContext : DbContext
        {

            #region"Constructor"
            public BoletoBusContext(DbContextOptions<BoletoBusContext> options) : base(options)

            {
            }

            #endregion

            #region "Db Sets"
            public DbSet<Reserva> Reserva { get; set; }

            public DbSet<Usuario> Usuario { get; set; }
        #endregion



       
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Reserva>(entity =>
            {
                entity.HasKey(e => e.IdReserva);
                entity.Property(e => e.IdReserva).ValueGeneratedOnAdd();  // Configura que el valor es generado al agregar
            });


            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.Property(e => e.IdUsuario).ValueGeneratedOnAdd();  // Configura que el valor es generado al agregar
            });

          
        }
         
        public DbSet<ReservaGetModel> ReservaGetModel { get; set; } = default!;
        public DbSet<ReservaUpdateModel> ReservaUpdateModel { get; set; } = default!;
        public DbSet<ReservaSaveModel> ReservaSaveModel { get; set; } = default!;
        public DbSet<UsuarioGetModel> UsuarioGetModel { get; set; } = default!;
        public DbSet<UsuarioSaveModel> UsuarioSaveModel { get; set; } = default!;
        public DbSet<UsuarioUpdateModel> UsuarioUpdateModel { get; set; } = default!;

        
    }
        
}


