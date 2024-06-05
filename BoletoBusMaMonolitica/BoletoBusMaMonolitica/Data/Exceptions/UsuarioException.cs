using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Exceptions
{
    public class UsuarioException : Exception
    {
        public UsuarioException(string message) : base(message)
        {
        }


        internal static void VerifyExistence(Usuario? usuario, string? idUsuario)
        {
            throw new NotImplementedException();
        }
    }
}