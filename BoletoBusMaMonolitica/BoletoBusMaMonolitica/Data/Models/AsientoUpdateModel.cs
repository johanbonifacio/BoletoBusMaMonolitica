using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Models
{
    public class AsientoUpdateModel : AsientoBaseModel
    {
        public AsientoUpdateModel() { }

        public void UpdateEntity(Asiento asiento)
        {
            asiento.IdBus = IdBus;
            asiento.NumeroPiso = NumeroPiso;
            asiento.NumeroAsiento = NumeroAsiento;
            asiento.FechaCreacion = FechaCreacion;
        }
    }
}
