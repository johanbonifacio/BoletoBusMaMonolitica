using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Models
{
    public class UsuarioModel  : Usuario
    {


        
       
         public static UsuarioModel FromEntity(Usuario usuario)
        {
            return new UsuarioModel
            {
                IdUsuario = usuario.IdUsuario, Apellidos = usuario.Apellidos,
                Correo = usuario.Correo,
                FechaCreacion=usuario.FechaCreacion, 
                Nombres = usuario.Nombres, 
                TipoUsuario = usuario.TipoUsuario  
                

            };
        }

        internal void UpdateEntity(Usuario? usuario)
        {
            throw new NotImplementedException();
        }
    }
}
