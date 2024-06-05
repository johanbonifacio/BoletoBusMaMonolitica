using BoletoBusMaMonolitica.Data.Core;
using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Models
{
    public class ReservaModel : Reserva
    {
        public ReservaModel()
        {

        }

        public static ReservaModel FromEntity(Reserva reserva)
        {
            return new ReservaModel
            {
                AsientosReservados = reserva.AsientosReservados,
                MontoTotal = reserva.MontoTotal,
                IdViaje = reserva.IdViaje,
                IdReserva = reserva.IdReserva, IdPasajero = reserva.IdPasajero


            };
        }
    }
}