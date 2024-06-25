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
    public class AsientoService : IAsientoService
    {
        private readonly IAsientoDb asientoDb;
        private readonly ILogger logger;

        public AsientoService(IAsientoDb asientoDb, ILogger<AsientoService> logger)
        {
            this.asientoDb = asientoDb;
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

        public ServiceResult GetAsientos()
        {
            return Execute(() => {
                var result = new ServiceResult
                {
                    Data = asientoDb.GetAsientos()
                };
                return result;
            }, "Hubo un error durante la obtención de los asientos.");
        }

        public ServiceResult GetAsiento(int id)
        {
            return Execute(() => {
                var result = new ServiceResult
                {
                    Data = asientoDb.GetAsiento(id)
                };
                return result;
            }, "Ocurrió un error obteniendo los asientos.");
        }

        public ServiceResult UpdateAsiento(AsientoUpdateModel asientoUpdate)
        {
            return Execute(() => {
                var validationResult = Validate(() => asientoUpdate == null, "Los datos del asiento no pueden ser nulos.");
                if (!validationResult.Success) return validationResult;

                validationResult = Validate(() => asientoUpdate.IdBus <= 0, "El Id del bus es requerido.");
                if (!validationResult.Success) return validationResult;

                validationResult = Validate(() => asientoUpdate.NumeroAsiento <= 0, "El número de asiento es requerido.");
                if (!validationResult.Success) return validationResult;

                this.asientoDb.UpdateAsiento(asientoUpdate);
                return new ServiceResult { Success = true };
            }, "Ocurrió un error actualizando los datos.");
        }

        public ServiceResult RemoveAsiento(AsientoRemoveModel asientoRemove)
        {
            return Execute(() => {
                var validationResult = Validate(() => asientoRemove == null, "Los datos del asiento no pueden ser nulos.");
                if (!validationResult.Success) return validationResult;

                this.asientoDb.RemoveAsiento(asientoRemove);
                return new ServiceResult { Success = true };
            }, "Ocurrió un error removiendo los datos.");
        }

        public ServiceResult SaveAsiento(AsientoSaveModel asientoAdd)
        {
            return Execute(() => {
                var validationResult = Validate(() => asientoAdd == null, "Los datos del asiento no pueden ser nulos.");
                if (!validationResult.Success) return validationResult;

                validationResult = Validate(() => asientoAdd.IdBus <= 0, "El Id del bus es requerido.");
                if (!validationResult.Success) return validationResult;

                validationResult = Validate(() => asientoAdd.NumeroAsiento <= 0, "El número de asiento es requerido.");
                if (!validationResult.Success) return validationResult;

                this.asientoDb.SaveAsiento(asientoAdd);
                return new ServiceResult { Success = true };
            }, "Ocurrió un error grabando los datos.");
        }
    }
}


