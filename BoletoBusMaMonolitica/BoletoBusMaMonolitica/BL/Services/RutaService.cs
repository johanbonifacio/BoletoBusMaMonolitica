using BoletoBusMaMonolitica.BL.Core;
using BoletoBusMaMonolitica.BL.Exceptions;
using BoletoBusMaMonolitica.BL.Interfaces;
using BoletoBusMaMonolitica.Data.Interfaces;
using BoletoBusMaMonolitica.Data.Models.Rut;
using Microsoft.Extensions.Logging;
using System;

namespace BoletoBusMaMonolitica.BL.Services
{
    public class RutaService : IRutaService
    {
        private readonly IRutaDB rutaDB;
        private readonly ILogger<RutaService> logger;

        public RutaService(IRutaDB rutaDB, ILogger<RutaService> logger)
        {
            this.rutaDB = rutaDB;
            this.logger = logger;
        }

        // Método Execute para manejar las excepciones, aplicando el D.R.Y
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

        // Método Validate para manejar y simplificar las validaciones
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

        public ServiceResult GetRutas()
        {
            return Execute(() => {
                var result = new ServiceResult
                {
                    Data = rutaDB.GetRutas()
                };
                return result;
            }, "Ocurrió un error obteniendo las rutas.");
        }

        public ServiceResult GetRutas(int id)
        {
            return Execute(() => {
                var result = new ServiceResult
                {
                    Data = rutaDB.GetRuta(id)
                };
                return result;
            }, "Ocurrió un error obteniendo las rutas.");
        }

        public ServiceResult UpdateRutas(RutaUpdateModel rutaUpdate)
        {
            return Execute(() => {
                var validationResult = Validate(() => rutaUpdate == null, "La Ruta no puede ser nulo.");
                if (!validationResult.Success) return validationResult;

                validationResult = Validate(() => rutaUpdate.Origen.Length > 50, "La Longitud del origen de la ruta debe ser 50 caracteres.");
                if (!validationResult.Success) return validationResult;

                this.rutaDB.UpdateRuta(rutaUpdate);
                return new ServiceResult { Success = true };
            }, "Ocurrió un error actualizando los datos.");
        }

        public ServiceResult RemoveRutas(RutaRemoveModel rutaRemove)
        {
            return Execute(() => {
                var validationResult = Validate(() => rutaRemove == null, "La Ruta no puede ser nulo.");
                if (!validationResult.Success) return validationResult;

                this.rutaDB.RemoveRuta(rutaRemove);
                return new ServiceResult { Success = true };
            }, "Ocurrió un error removiendo los datos.");
        }

        public ServiceResult SaveRutas(RutaSaveModel rutaAdd)
        {
            return Execute(() => {
                var validationResult = Validate(() => rutaAdd == null, "La Ruta no puede ser nulo.");
                if (!validationResult.Success) return validationResult;

                validationResult = Validate(() => rutaAdd.Origen.Length > 50, "La Longitud del origen de la ruta debe ser 50 caracteres.");
                if (!validationResult.Success) return validationResult;

                this.rutaDB.SaveRuta(rutaAdd);
                return new ServiceResult { Success = true };
            }, "Ocurrió un error grabando los datos.");
        }
    }
}