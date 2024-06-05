using BoletoBusMaMonolitica.Data.Core;
using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Models
{
    public class RutaModel : Ruta
    {
        public RutaModel()
        {

        }

        public static RutaModel FromEntity(Ruta ruta)
        {
            return new RutaModel
            { 
                IdRuta = ruta.IdRuta,
               Origen= ruta.Origen,    
                Destino = ruta.Destino,
               FechaCreacion = ruta.FechaCreacion
            };
        }
    }
}