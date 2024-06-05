using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Models
{
    public class ReservaSaveModel : ReservaModel
    {
        public ReservaSaveModel() { }

        public Reserva ToEntity()
        {
            return new Reserva
            {
                AsientosReservados = this.AsientosReservados,
                IdPasajero = this.IdPasajero,
                IdReserva = this.IdReserva,
                MontoTotal = this.MontoTotal,
                IdViaje = this.IdViaje


            };
        }
    }
}

