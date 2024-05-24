using BoletoBusMaMonolitica.Data.Core;

namespace BoletoBusMaMonolitica.Data.Entities
{
    public class Asiento : BaseEntity
    {
        public int IdAsiento { get; set; }
        public int IdBus {get; set; }
        public int NumeroPiso { get; set; }
        public int NumeroAsiento { get; set; }

    }
}
