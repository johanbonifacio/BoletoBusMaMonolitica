using BoletoBusMaMonolitica.Data.Core;
using System.ComponentModel.DataAnnotations;

namespace BoletoBusMaMonolitica.Data.Entities
{
    public class Bus : BaseEntity
    {
        [Key] public int IdBus { get; set; }
        public string? NumeroPlaca { get; set; }
        public string? Nombre { get; set; }
        public int CapacidadPiso1 { get; set; }
        public int CapacidadPiso2 { get; set; }
        public int CapacidadTotal { get; set; }
        public bool Disponible { get; set; }
    }
}
