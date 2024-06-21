using BoletoBusMaMonolitica.Data.Entities;
using BoletoBusMaMonolitica.Data.Models;

namespace BoletoBusMaMonolitica.Data.Interfaces
{
    public interface IUsuarioDb
    {
        void SaveUsuario(UsuarioSaveModel usuarioSave);
        void UpdateUsuario(UsuarioUpdateModel updateModel);
        void RemoveUsuario(UsuarioRemoveModel UsuarioRemove);
        List<UsuarioGetModel> GetUsuarios();
        UsuarioGetModel GetUsuarios(int Idusuario);
    }
}
