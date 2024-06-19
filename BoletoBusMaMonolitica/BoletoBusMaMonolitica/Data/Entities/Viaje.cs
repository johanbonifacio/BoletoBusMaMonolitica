using BoletoBusMaMonolitica.Data.Core;

namespace BoletoBusMaMonolitica.Data.Entities
{
    public class Viaje : BaseEntity
    {
        public int IdViaje { get; set; }
        public int Idbus { get; set; }
        public int IdRuta {  get; set; }
        public TimeOnly FechaSalida { get; set; }
        public DateOnly HoraSalida { get; set; }
        public TimeOnly? HoraLlegada { get; set; }
        public decimal Precio { get; set; }
        public int? TotalAsientos { get; set; }
        public int? AsientosReservados { get; set; }
        public int? AsientosDisponibles { get; set; }
        public int Completo {  get; set; }

    }
}
