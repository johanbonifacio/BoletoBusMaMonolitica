using System.ComponentModel.DataAnnotations;

namespace BoletoBusMaMonolitica.Data.Models.Rut
{
    public abstract class RutaBaseModel : ModelBase
     
    {
        [Key] public int IdRuta { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
    }
}
