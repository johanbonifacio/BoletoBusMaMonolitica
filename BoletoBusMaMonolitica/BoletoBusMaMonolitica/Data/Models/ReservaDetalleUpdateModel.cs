using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Models
{
    public class ReservaDetalleUpdateModel : ReservaDetalleModel
    {
        public ReservaDetalleUpdateModel() { }

        public void UpdateEntity(ReservaDetalle reservaDetalle)
        {
            reservaDetalle.IdReservaDetalle = this.IdReservaDetalle;
            reservaDetalle.IdReserva = this.IdReserva;
            reservaDetalle.IdAsiento = this.IdAsiento;
        }
    }
}
