using BoletoBusMaMonolitica.Data.Core;
using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Models.Rut
{
    public class RutaGetModel : Ruta
    {
        public RutaGetModel()
        {

        }

        public static RutaGetModel FromEntity(Ruta ruta)
        {
            return new RutaGetModel
            {
                IdRuta = ruta.IdRuta,
                Origen = ruta.Origen,
                Destino = ruta.Destino,
                FechaCreacion = ruta.FechaCreacion
            };
        }
    }
}