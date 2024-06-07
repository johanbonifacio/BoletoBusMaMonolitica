using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Exceptions
{
    public class UsuarioException : Exception
    {
        public UsuarioException(string message) : base(message)
        {
        }
        public static void VerifyExistence(Usuario usuario, int idUsuario)
        {
            if (usuario == null)
            {
                throw new ReservaException($"el usuario con la id {idUsuario} no está registrado.");
            }
        }

        
    }
}