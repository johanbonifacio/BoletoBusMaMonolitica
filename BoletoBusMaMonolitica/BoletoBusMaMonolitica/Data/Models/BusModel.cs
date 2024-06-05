using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Models
{
    public class BusModel : Bus
    {
        public BusModel() { }

        public static BusModel FromEntity(Bus bus)
        {
            return new BusModel
            {
                IdBus = bus.IdBus,
                NumeroPlaca = bus.NumeroPlaca,
                Nombre = bus.Nombre,
                CapacidadPiso1 = bus.CapacidadPiso1,
                CapacidadPiso2 = bus.CapacidadPiso2,
                CapacidadTotal = bus.CapacidadTotal,
                Disponible = bus.Disponible,
                FechaCreacion = bus.FechaCreacion
            };
        }
    }
}
