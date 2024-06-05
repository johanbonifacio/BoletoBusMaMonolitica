using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Models
{
    public class ReservaUpdateModel
    {

        

        public int IdReserva { get; set; }

        public int IdViaje { get; set; }

        public int IdPasajero { get; set; }

        public int AsientosReservados { get; set; }

        public decimal MontoTotal { get; set; }

        public DateTime Modifydate { get; set; }

        public string? IdUsuario { get; set; }

        internal void UpdateEntity(Reserva? reserva)
        {
            throw new NotImplementedException();
        }
    }
}
