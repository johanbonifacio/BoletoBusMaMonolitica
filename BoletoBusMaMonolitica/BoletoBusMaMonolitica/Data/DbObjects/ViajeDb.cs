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
    public class ViajeDb : IViajesDb
    {
        private readonly BoletoBusContext context;
        public ViajeDb(BoletoBusContext context)
        {
            this.context = context;
        }

        public ViajeModel GetBus(int IdViaje)
        {
            var viaje = context.Bus.Find(IdViaje);
            return BusModel.FromEntity(viaje);
        }

        public List<BusModel> GetBuses()
        {
            return context.Viaje.Select(viaje => ViajeModel.FromEntity(viaje)).ToList();
        }

        public void SaveViaje(ViajeSaveModel viajeSave)
        {
            var viaje = viajeSave.ToEntity();
            context.Viaje.Add(viaje);
            context.SaveChanges();
        }

        public void UpdateViaje(ViajeUpdateModel updateModel)
        {
            var viaje = context.Viaje.Find(updateModel.IdViaje);
            ViajeException.VerifyExistence(viaje, updateModel.IdViaje);

            updateModel.UpdateEntity(viaje);
            context.Viaje.Update(viaje);
            context.SaveChanges();
        }

        public void RemoveViaje(ViajeRemoveModel viajeRemove)
        {
            var viaje = context.Viaje.Find(viajeRemove.IdViaje);
            ViajeException.VerifyExistence(viaje, viajeRemove.IdViaje);
            context.Viaje.Remove(viaje);
            context.SaveChanges();
        }
}
