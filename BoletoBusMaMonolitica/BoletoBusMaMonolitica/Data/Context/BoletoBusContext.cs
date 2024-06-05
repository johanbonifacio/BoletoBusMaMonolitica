using Microsoft.EntityFrameworkCore;

namespace BoletoBusMaMonolitica.Data.Context
{
    public class BoletoBusContext : DbContext
    {
        public BoletoBusContext(DbContextOptions<BoletoBusContext>options) :base(options) 
        {



        }
    }
}
