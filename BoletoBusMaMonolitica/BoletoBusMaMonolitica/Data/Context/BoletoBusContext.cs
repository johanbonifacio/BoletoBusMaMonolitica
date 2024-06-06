using BoletoBusMaMonolitica.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BoletoBusMaMonolitica.Data.Context
{
    public class BoletoBusContext : DbContext
    {
        #region "constructor"
        public BoletoBusContext(DbContextOptions<BoletoBusContext>options) :base(options) 
        {
        }
        #endregion

        #region"Db set"

        public DbSet<ReservaDetalle> ReservaDetalle { get; set; }


        #endregion
    }
}
