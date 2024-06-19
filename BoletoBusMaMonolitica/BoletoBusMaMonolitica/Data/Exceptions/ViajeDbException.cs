using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Exceptions
{
    public class ViajeDbException : Exception
    {
        public ViajeDbException(String message) : base(message)
        {
        }
        public static void VerifyExistence(Viaje viaje, int idViaje)
        {
            if (viaje == null)
            {
                throw new ViajeDbException($"El viaje con la id {idViaje} no está registrado.");
            }
        }
    }
}
