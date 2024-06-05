using BoletoBusMaMonolitica.Data.Core;

namespace BoletoBusMaMonolitica.Data.Entities
{
    public class Ruta : BaseEntity
    {
        public int IdRuta { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }

    }
}
