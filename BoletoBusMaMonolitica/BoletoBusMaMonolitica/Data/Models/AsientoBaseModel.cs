using System.ComponentModel.DataAnnotations;

namespace BoletoBusMaMonolitica.Data.Models
{
    public class AsientoBaseModel : ModelBase
    {
        [Key] public int IdAsiento { get; set; }
        public int IdBus { get; set; }
        public int NumeroPiso { get; set; }
        public int NumeroAsiento { get; set; }
    }
}
