using BoletoBusMaMonolitica.Data.Entities;
using BoletoBusMaMonolitica.Data.Models;

public class UsuarioUpdateModel : UsuarioModel
{
    public UsuarioUpdateModel()
    {
    }
    public void UpdateEntity(Usuario usuario)
    {



        usuario.FechaCreacion = this.FechaCreacion;
        usuario.Apellidos = this.Apellidos;
        usuario.Correo = this.Correo;
        usuario.TipoUsuario = this.TipoUsuario;
        usuario.Nombres = this.Nombres;
        usuario.IdUsuario = this.IdUsuario;

    }
}