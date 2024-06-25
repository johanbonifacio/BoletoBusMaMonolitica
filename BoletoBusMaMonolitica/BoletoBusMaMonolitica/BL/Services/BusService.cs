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
    public class BusService : IBusService
    {
        private readonly IBusDb busDb;
        private readonly ILogger logger;

        public BusService(IBusDb busDb, ILogger<BusService> logger)
        {
            this.busDb = busDb;
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

        public ServiceResult GetBuses()
        {
            return Execute(() => {
                var result = new ServiceResult
                {
                    Data = busDb.GetBuses()
                };
                return result;
            }, "Hubo un error durante la obtención de los buses.");
        }

        public ServiceResult GetBus(int id)
        {
            return Execute(() => {
                var result = new ServiceResult
                {
                    Data = busDb.GetBus(id)
                };
                return result;
            }, "Ocurrió un error obteniendo los buses.");
        }

        public ServiceResult UpdateBuses(BusUpdateModel busUpdate)
        {
            return Execute(() => {
                var validationResult = Validate(() => busUpdate == null, "Los datos del bus no pueden ser nulos.");
                if (!validationResult.Success) return validationResult;

                validationResult = Validate(() => string.IsNullOrEmpty(busUpdate.Nombre), "El nombre del bus es requerido.");
                if (!validationResult.Success) return validationResult;

                validationResult = Validate(() => busUpdate.Nombre.Length > 50, "El nombre del bus no puede superar los 50 caracteres.");
                if (!validationResult.Success) return validationResult;

                this.busDb.UpdateBus(busUpdate);
                return new ServiceResult { Success = true };
            }, "Ocurrió un error actualizando los datos.");
        }

        public ServiceResult RemoveBuses(BusRemoveModel busRemove)
        {
            return Execute(() => {
                var validationResult = Validate(() => busRemove == null, "Los datos del bus no pueden ser nulos.");
                if (!validationResult.Success) return validationResult;

                this.busDb.RemoveBus(busRemove);
                return new ServiceResult { Success = true };
            }, "Ocurrió un error removiendo los datos.");
        }

        public ServiceResult SaveBus(BusSaveModel busAdd)
        {
            return Execute(() => {
                var validationResult = Validate(() => busAdd == null, "Los datos del bus no pueden ser nulos.");
                if (!validationResult.Success) return validationResult;

                validationResult = Validate(() => string.IsNullOrEmpty(busAdd.Nombre), "El nombre del bus es requerido.");
                if (!validationResult.Success) return validationResult;

                validationResult = Validate(() => busAdd.Nombre.Length > 50, "El nombre del bus no puede superar los 50 caracteres.");
                if (!validationResult.Success) return validationResult;

                this.busDb.SaveBus(busAdd);
                return new ServiceResult { Success = true };
            }, "Ocurrió un error grabando los datos.");
        }
    }
}


