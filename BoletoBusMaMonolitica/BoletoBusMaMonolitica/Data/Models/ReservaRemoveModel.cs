using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Models
{
    public class ReservaRemoveModel : ReservaModel
    {
        public ReservaRemoveModel()
        {
        }
        public Reserva ToEntity()
        {
            return new Reserva
            {
                AsientosReservados = this.AsientosReservados,
                IdPasajero = this.IdPasajero,
                IdReserva = this.IdReserva,
                IdViaje = this.IdViaje,
                MontoTotal = this.MontoTotal


            };
        }
    }
}