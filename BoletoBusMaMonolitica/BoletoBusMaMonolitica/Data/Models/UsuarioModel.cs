using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Models
{
    public class UsuarioModel
    {


        public string? IdUsuario { get; set; }

        public string? Nombres { get; set; }

        public string? Apellidos { get; set; }
        public string? Correo { get; set; }

        public string? TipoUsuario { get; set; }

        public DateTime FechaCreacion { get; set; }

        

        internal static UsuarioModel FromEntity(Usuario? usuario)
        {
            throw new NotImplementedException();
        }

        internal void UpdateEntity(Usuario? usuario)
        {
            throw new NotImplementedException();
        }
    }
}
