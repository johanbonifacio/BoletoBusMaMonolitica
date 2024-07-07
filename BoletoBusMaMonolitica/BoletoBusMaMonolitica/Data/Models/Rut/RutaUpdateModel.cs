using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Models.Rut
{
    public class RutaUpdateModel : RutaBaseModel
    {
        public RutaUpdateModel() { }



        public void UpdateEntity(Ruta ruta)
        {
            ruta.IdRuta = IdRuta;
            ruta.Origen = Origen;
            ruta.Destino = Destino;
            ruta.FechaCreacion = ChangeDate;
        }
    }
}
