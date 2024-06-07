using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Exceptions
{
    public class ReservaException : Exception
    {
        public ReservaException(string message) : base(message)
        {
        }
        public static void VerifyExistence(Reserva reserva, int idReserva)
        {
            if (reserva == null)
            {
                throw new ReservaException($"la reserva con la id {idReserva} no está registrada.");
            }
        }
    }
}
