using BoletoBusMaMonolitica.Data.Context;
using BoletoBusMaMonolitica.Data.Entities;
using BoletoBusMaMonolitica.Data.Exceptions;
using BoletoBusMaMonolitica.Data.Interfaces;
using BoletoBusMaMonolitica.Data.Models;

namespace BoletoBusMaMonolitica.Data.DbObjects
{
    public class UsuarioDb : IUsuarioDb
    {
        private readonly BoletoBusContext context;

        public UsuarioDb(BoletoBusContext context)
        {
            this.context = context;
        }


        

        public UsuarioModel GetUsuarios(int IdUsuario)
        {
            var usuario = this.context.Usuario.Find(IdUsuario);
            return UsuarioModel.FromEntity(usuario);
        }

        
        public List<UsuarioModel> GetUsuarios()
        {
            return context.Usuario.Select(usuario => UsuarioModel.FromEntity(usuario)).ToList();
        }

        public void RemoveUsuario(UsuarioRemoveModel UsuarioRemove)
        {
            var usuario = context.Usuario.Find(UsuarioRemove.IdUsuario);
            UsuarioException.VerifyExistence(usuario, UsuarioRemove.IdUsuario);
            context.Usuario.Remove(usuario);
            context.SaveChanges();
        }

        public void SaveUsuario(UsuarioSaveModel usuarioSave)
        {
            var usuario = usuarioSave.ToEntity();
            context.Usuario.Add(usuario);
            context.SaveChanges();
        }

        public void UpdateUsuario(UsuarioUpdateModel updateModel)
        {
            var usuario = context.Usuario.Find(updateModel.IdUsuario);
            UsuarioException.VerifyExistence(usuario, updateModel.IdUsuario);
            updateModel.UpdateEntity(usuario);
            context.Usuario.Update(usuario);
            context.SaveChanges();
        }
    }
}
