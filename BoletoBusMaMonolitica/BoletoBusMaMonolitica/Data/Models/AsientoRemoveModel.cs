using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Models
{
    public class AsientoRemoveModel : AsientoBaseModel
    {
        public AsientoRemoveModel()
        {
        }
        public Asiento ToEntity()
        {
            return new Asiento
            {
                IdAsiento = this.IdAsiento,
                IdBus = this.IdBus,
                NumeroPiso = this.NumeroPiso,
                NumeroAsiento = this.NumeroAsiento,
                FechaCreacion = this.FechaCreacion
            };
        }
    }
}
