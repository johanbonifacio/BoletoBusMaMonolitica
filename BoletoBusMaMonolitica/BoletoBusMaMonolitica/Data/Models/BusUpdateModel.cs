using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Models
{
    public class BusUpdateModel : BusModel
    {
        public BusUpdateModel()
        {
        }
        public void UpdateEntity(Bus bus)
        {
            bus.NumeroPlaca = this.NumeroPlaca;
            bus.Nombre = this.Nombre;
            bus.CapacidadPiso1 = this.CapacidadPiso1;
            bus.CapacidadPiso2 = this.CapacidadPiso2;
            bus.CapacidadTotal = this.CapacidadTotal;
            bus.Disponible = this.Disponible;
            bus.FechaCreacion = this.FechaCreacion;
        }
    }
}
