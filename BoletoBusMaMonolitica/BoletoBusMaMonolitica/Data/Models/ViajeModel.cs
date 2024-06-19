using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Models
{
    public class ViajeModel : Viaje
    {
        public ViajeModel() { }

        public static ViajeModel FromEntity(Viaje viaje) 
        {
            return new ViajeModel()
            {
                IdViaje = viaje.IdViaje,
                Idbus = viaje.Idbus,
                IdRuta = viaje.IdRuta,
                FechaSalida = viaje.FechaSalida,
                HoraSalida = viaje.HoraSalida,
                Precio = viaje.Precio,
                TotalAsientos = viaje.TotalAsientos,
                AsientosReservados = viaje.AsientosReservados,
                AsientosDisponibles = viaje.AsientosDisponibles,
                Completo = viaje.Completo,

            };
        }

    }
}
