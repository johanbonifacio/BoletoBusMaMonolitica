using BoletoBusMaMonolitica.Data.Core;

namespace BoletoBusMaMonolitica.Data.Entities
{
    public class ReservaDetalle : BaseEntity 
    {

        public int IdReservaDetalle { get; set; }
        public int Idreserva {  get; set; }     

        public int IdAsiento { get; set; }
    }
}
