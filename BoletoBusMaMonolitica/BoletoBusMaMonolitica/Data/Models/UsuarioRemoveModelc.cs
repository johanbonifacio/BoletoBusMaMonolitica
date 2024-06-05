using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Models
{
    public class UsuarioRemoveModel : UsuarioModel
    {
        public UsuarioRemoveModel() { }

        public Usuario ToEntity()
        {
            return new Usuario
            {


                FechaCreacion = this.FechaCreacion,
                Apellidos = this.Apellidos,
                Correo = this.Correo,
                TipoUsuario = this.TipoUsuario,
                Nombres = this.Nombres,
                IdUsuario = this.IdUsuario


            };
        }
    }
}
