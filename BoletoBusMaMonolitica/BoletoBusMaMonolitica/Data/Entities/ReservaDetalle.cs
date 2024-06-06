using BoletoBusMaMonolitica.Data.Core;

namespace BoletoBusMaMonolitica.Data.Entities
{
    public class ReservaDetalle : BaseEntity 
    {

        public int IdReservaDetalle { get; set; }
        public int IdReserva {  get; set; }     

        public int IdAsiento { get; set; }
    }
}
