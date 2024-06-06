using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Models
{
    public class ReservaDetalleSaveModel : ReservaDetalleModel
    {
        public ReservaDetalleSaveModel() { }

        public ReservaDetalle ToEntity()
        {
            return new ReservaDetalle
            {
                IdReservaDetalle = this.IdReservaDetalle,
                IdReserva = this.IdReserva,
                IdAsiento = this.IdAsiento
            };
        }
    }
}
