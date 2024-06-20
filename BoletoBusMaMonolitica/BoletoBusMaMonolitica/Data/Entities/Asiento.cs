using BoletoBusMaMonolitica.Data.Core;
using System.ComponentModel.DataAnnotations;

namespace BoletoBusMaMonolitica.Data.Entities
{
    public class Asiento : BaseEntity
    {
        [Key] public int IdAsiento { get; set; }
        public int IdBus { get; set; }
        public int NumeroPiso { get; set; }
        public int NumeroAsiento { get; set; }
    }
}

