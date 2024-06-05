using BoletoBusMaMonolitica.Data.Context;
using BoletoBusMaMonolitica.Data.Entities;
using BoletoBusMaMonolitica.Data.Exceptions;
using BoletoBusMaMonolitica.Data.Interfaces;
using BoletoBusMaMonolitica.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BoletoBusMaMonolitica.Data.DbObjects
{
    public class RutaDB : IRutaDb
    {
        private readonly BoletoBusContext context;
        public RutaDB(BoletoBusContext context)
        {
            this.context = context;
        }

        public RutaModel GetAsiento(int IdRuta)
        {
            var ruta = context.Ruta.Find(IdRuta);
            return RutaModel.FromEntity(ruta);
        }

        public List<RutaModel> GetAsientos()
        {
            return context.Ruta.Select(ruta => RutaModel.FromEntity(ruta)).ToList();
        }

        public void SaveAsiento(RutaSaveModel rutaSave)
        {
            var ruta = rutaSave.ToEntity();
            context.Ruta.Add(ruta);
            context.SaveChanges();
        }

        public void UpdateAsiento(RutaUpdateModel updateModel)
        {
            var ruta = context.Ruta.Find(updateModel.IdRuta);
            RutaException.VerifyExistence(ruta, updateModel.IdRuta);
            updateModel.UpdateEntity(ruta);
            context.Ruta.Update(ruta);
            context.SaveChanges();
        }

        public void RemoveAsiento(RutaRemoveModel rutaRemove)
        {
            var ruta = context.Ruta.Find(rutaRemove.IdRuta);
            RutaException.VerifyExistence(ruta, rutaRemove.IdRuta);
            context.Ruta.Remove(ruta);
            context.SaveChanges();
        }
    }
}