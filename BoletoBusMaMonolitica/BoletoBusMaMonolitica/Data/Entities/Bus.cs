using BoletoBusMaMonolitica.Data.Core;

namespace BoletoBusMaMonolitica.Data.Entities
{
    public class Bus : BaseEntity
    {
        public int IdBus {  get; set; }
        public string? NumeroPlaca { get; set; }
        public int CapacidadPiso1 { get; set; }
        public int CapacidadPiso2 { get; set; }
        public int CapacidadTotal { get; set; }
        public bool Disponible { get; set; }
    }
}
