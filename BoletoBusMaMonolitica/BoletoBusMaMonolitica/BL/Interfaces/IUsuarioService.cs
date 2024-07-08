using BoletoBusMaMonolitica.BL.Core;
using BoletoBusMaMonolitica.Data.Models;

namespace BoletoBusMaMonolitica.BL.Interfaces
{
    public interface IUsuarioService
    {
        ServiceResult GetUsuarios();
        ServiceResult GetUsuario(int id);
        ServiceResult UpdateUsuario(UsuarioUpdateModel UsuarioUpdate);
        ServiceResult RemoveUsuario(UsuarioRemoveModel UsuarioRemove);
        ServiceResult SaveUsuario(UsuarioSaveModel UsuarioAdd);


    }
}