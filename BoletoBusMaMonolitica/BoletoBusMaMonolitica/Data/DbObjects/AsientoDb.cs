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
    public class AsientoDb : IAsientoDb
    {
        private readonly BoletoBusContext context;
        public AsientoDb(BoletoBusContext context)
        {
            this.context = context;
        }

        public AsientoGetModel GetAsiento(int IdAsiento)
        {
            var asiento = context.Asiento.Find(IdAsiento);
            AsientoException.VerifyExistence(asiento, IdAsiento);
            return AsientoGetModel.FromEntity(asiento);
        }

        public List<AsientoGetModel> GetAsientos()
        {
            return context.Asiento.Select(asiento => AsientoGetModel.FromEntity(asiento)).ToList();
        }

        public void SaveAsiento(AsientoSaveModel asientoSave)
        {
            var asiento = asientoSave.ToEntity();
            context.Asiento.Add(asiento);
            context.SaveChanges();
        }

        public void UpdateAsiento(AsientoUpdateModel updateModel)
        {
            var asiento = context.Asiento.Find(updateModel.IdAsiento);
            AsientoException.VerifyExistence(asiento, updateModel.IdAsiento);
            updateModel.UpdateEntity(asiento);
            context.Asiento.Update(asiento);
            context.SaveChanges();
        }

        public void RemoveAsiento(AsientoRemoveModel asientoRemove)
        {
            var asiento = context.Asiento.Find(asientoRemove.IdAsiento);
            AsientoException.VerifyExistence(asiento, asientoRemove.IdAsiento);
            context.Asiento.Remove(asiento);
            context.SaveChanges();
        }
    }
}


