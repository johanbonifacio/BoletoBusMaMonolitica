using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Models
{
    public class BusUpdateModel : BusBaseModel
    {
        public BusUpdateModel()
        {
        }
        public void UpdateEntity(Bus bus)
        {
            bus.NumeroPlaca = NumeroPlaca;
            bus.Nombre = Nombre;
            bus.CapacidadPiso1 = CapacidadPiso1;
            bus.CapacidadPiso2 = CapacidadPiso2;
            bus.CapacidadTotal = CapacidadTotal;
            bus.Disponible = Disponible;
            bus.FechaCreacion = FechaCreacion;
        }
    }
}
