using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Exceptions
{
    public class RutaException : Exception
    {
        public RutaException(string message) : base(message)
        {
        }
        public static void VerifyExistence(Ruta ruta, int idRuta)
        {
            if (ruta == null)
            {
                throw new RutaException($"La ruta con la id {idRuta} no está disponible.");
            }
        }
    }
}
