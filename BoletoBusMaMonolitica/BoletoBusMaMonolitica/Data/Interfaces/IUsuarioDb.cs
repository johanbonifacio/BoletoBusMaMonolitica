using BoletoBusMaMonolitica.Data.Entities;
using BoletoBusMaMonolitica.Data.Models;

namespace BoletoBusMaMonolitica.Data.Interfaces
{
    public interface IUsuarioDb
    {
        void SaveUsuario(UsuarioSaveModel usuarioSave);
        void UpdateUsuario(UsuarioModel updateModel);

        void RemoveUsuario(UsuarioRemoveModel UsuarioRemove);
        List<UsuarioModel> GetUsuarios();
        UsuarioModel GetUsuarios(int Idusuario);
    }
}
