using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Models
{
    public class AsientoUpdateModel : AsientoModel
    {
        public AsientoUpdateModel() { }

        public void UpdateEntity(Asiento asiento)
        {
            asiento.IdBus = this.IdBus;
            asiento.NumeroPiso = this.NumeroPiso;
            asiento.NumeroAsiento = this.NumeroAsiento;
            asiento.FechaCreacion = this.FechaCreacion;
        }
    }
}
