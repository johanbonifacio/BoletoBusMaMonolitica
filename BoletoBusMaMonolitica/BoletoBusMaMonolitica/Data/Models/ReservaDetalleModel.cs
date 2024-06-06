using BoletoBusMaMonolitica.Data.Core;
using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Models
{
    public class ReservaDetalleModel : ReservaDetalle
    {
        public ReservaDetalleModel()
        {

        }

        public static ReservaDetalleModel FromEntity(ReservaDetalle reservaDetalle)
        {
            return new ReservaDetalleModel
            {
                IdReservaDetalle = reservaDetalle.IdReservaDetalle,
                IdReserva = reservaDetalle.IdReserva,
                IdAsiento = reservaDetalle.IdAsiento
            };
        }
    }
}
