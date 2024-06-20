using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Models
{
    public class BusSaveModel : BusBaseModel
    {
        public BusSaveModel()
        {
        }

        public Bus ToEntity()
        {
            return new Bus
            {
                IdBus = this.IdBus,
                NumeroPlaca = this.NumeroPlaca,
                Nombre = this.Nombre,
                CapacidadPiso1 = this.CapacidadPiso1,
                CapacidadPiso2 = this.CapacidadPiso2,
                CapacidadTotal = this.CapacidadTotal,
                Disponible = this.Disponible,
                FechaCreacion = this.FechaCreacion
            };
        }
    }
}
