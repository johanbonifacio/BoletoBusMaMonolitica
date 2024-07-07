using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Models.Rut
{
    public class RutaRemoveModel : RutaBaseModel
    {
        public RutaRemoveModel()
        {
        }
        public Ruta ToEntity()
        {
            return new Ruta
            {
                IdRuta = this.IdRuta,
                Origen = this.Origen,
                Destino = this.Destino,
                FechaCreacion = this.ChangeDate
            };
        }
    }
}
