using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Models
{
    public class ViajeRemoveModel : ViajeModel
    {
        public ViajeRemoveModel()
        {

        }

        public Viaje ToEntity()
        {
            return new Viaje
            {
                IdViaje = this.IdViaje,
                Idbus = this.Idbus,
                IdRuta = this.IdRuta,
                FechaSalida = this.FechaSalida,
                HoraSalida = this.HoraSalida,
                Precio = this.Precio,
                TotalAsientos = this.TotalAsientos,
                AsientosReservados = this.AsientosReservados,
                AsientosDisponibles = this.AsientosDisponibles,
                Completo = this.Completo,
            };
        }
    }
}