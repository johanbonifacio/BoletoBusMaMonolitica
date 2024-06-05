using BoletoBusMaMonolitica.Data.Entities;
using Microsoft.EntityFrameworkCore;

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
    }
}
