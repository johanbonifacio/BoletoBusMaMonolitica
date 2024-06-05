using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Exceptions
{
    public class ReservaException : Exception
    {
        public ReservaException(string message) : base(message)
        {
        }

        internal static void VerifyExistence(Reserva? reserva, int idReserva)
        {
            throw new NotImplementedException();
        }
    }
}
