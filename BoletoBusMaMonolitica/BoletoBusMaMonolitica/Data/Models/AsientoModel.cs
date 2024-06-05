using BoletoBusMaMonolitica.Data.Core;
using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Models
{
    public class AsientoModel : Asiento
    {
        public AsientoModel() 
        {

        }

        public static AsientoModel FromEntity(Asiento asiento)
        {
            return new AsientoModel
            {
                IdAsiento = asiento.IdAsiento,
                IdBus = asiento.IdBus,
                NumeroPiso = asiento.NumeroPiso,
                NumeroAsiento = asiento.NumeroAsiento,
                FechaCreacion = asiento.FechaCreacion
            };
        }
    }
}
