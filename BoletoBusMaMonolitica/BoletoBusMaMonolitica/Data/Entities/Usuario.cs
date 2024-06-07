using BoletoBusMaMonolitica.Data.Core;

namespace BoletoBusMaMonolitica.Data.Entities
{
    public class Usuario : BaseEntity
    {

        public int IdUsuario { get; set; }

        public string? Nombres { get; set; }

        public string? Apellidos { get; set; }
        public string? Correo { get; set; }

        public string? Clave { get; set; }

        public string? TipoUsuario { get; set; }

        public DateTime FechaCreacion { get; set; }




   

    }
}
