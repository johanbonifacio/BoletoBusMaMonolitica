
using BoletoBusMaMonolitica.BL.Core;
using BoletoBusMaMonolitica.BL.Interfaces;
using BoletoBusMaMonolitica.BL.Exceptions;
using BoletoBusMaMonolitica.Data.DbObjects;
using BoletoBusMaMonolitica.Data.Interfaces;
using BoletoBusMaMonolitica.Data.Models;
using Microsoft.Extensions.Logging;
using System;

namespace BoletoBusMaMonolitica.BL.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioDb usuarioDb;
        private readonly ILogger logger;

        public UsuarioService(IUsuarioDb usuarioDb, ILogger<UsuarioService> logger)
        {
            this.usuarioDb = usuarioDb;
            this.logger = logger;
        }

        // NOTA, METODO EXECUTE PARA MANEJAR LAS EXCEPCIONES, APLICANDO EL D.R.Y
        private ServiceResult Execute(Func<ServiceResult> action, string errorMessage)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result = action();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = errorMessage;
                this.logger.LogError(result.Message, ex.ToString());
            }
            return result;
        }
        // METODO VALIDATE PARA MANEJAR Y SIMPLIFICAR LAS VALIDACIONES
        private ServiceResult Validate(Func<bool> condition, string errorMessage)
        {
            ServiceResult result = new ServiceResult();
            if (condition())
            {
                result.Success = false;
                result.Message = errorMessage;
                return result;
            }
            result.Success = true;
            return result;
        }

        public ServiceResult GetUsuarios()
        {
            return Execute(() => {
                var result = new ServiceResult
                {
                    Data = usuarioDb.GetUsuarios()
                };
                return result;
            }, "Hubo un error durante la obtención de los usuarios.");
        }

        public ServiceResult GetUsuario(int id)
        {
            return Execute(() => {
                var result = new ServiceResult
                {
                    Data = usuarioDb.GetUsuarios(id)
                };
                return result;
            }, "Ocurrió un error obteniendo los usuarios.");
        }

        public ServiceResult UpdateUsuario(UsuarioUpdateModel usuarioUpdate)
        {
            return Execute(() => {
                var validationResult = Validate(() => usuarioUpdate == null, "Los datos del usuario no pueden ser nulos.");
                if (!validationResult.Success) return validationResult;

                validationResult = Validate(() => usuarioUpdate.IdUsuario <= 0, "El Id del bus es requerido.");
                if (!validationResult.Success) return validationResult;

              

                this.usuarioDb.UpdateUsuario(usuarioUpdate);
                return new ServiceResult { Success = true };
            }, "Ocurrió un error actualizando los datos.");
        }

        public ServiceResult RemoveUsuario(UsuarioRemoveModel usuarioRemove)
        {
            return Execute(() => {
                var validationResult = Validate(() => usuarioRemove == null, "Los datos del usuario no pueden ser nulos.");
                if (!validationResult.Success) return validationResult;

                this.usuarioDb.RemoveUsuario(usuarioRemove);
                return new ServiceResult { Success = true };
            }, "Ocurrió un error removiendo los datos.");
        }

        public ServiceResult SaveUsuario(UsuarioSaveModel usuarioAdd)
        {
            return Execute(() => {
                var validationResult = Validate(() => usuarioAdd == null, "Los datos del usuario no pueden ser nulos.");
                if (!validationResult.Success) return validationResult;

                validationResult = Validate(() => usuarioAdd.IdUsuario <= 0, "El Id del bus es requerido.");
                if (!validationResult.Success) return validationResult;

               
                this.usuarioDb.SaveUsuario(usuarioAdd);
                return new ServiceResult { Success = true };
            }, "Ocurrió un error grabando los datos.");
        }
    }
}
