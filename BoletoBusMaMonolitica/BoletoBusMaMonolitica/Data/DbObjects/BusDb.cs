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
    public class BusDb : IBusDb
    {
        private readonly BoletoBusContext context;
        public BusDb(BoletoBusContext context)
        {
            this.context = context;
        }

        public BusGetModel GetBus(int IdBus)
        {
            var bus = context.Bus.Find(IdBus);
            BusException.VerifyExistence(bus, IdBus);
            return BusGetModel.FromEntity(bus);
        }

        public List<BusGetModel> GetBuses()
        {
            return context.Bus.Select(bus => BusGetModel.FromEntity(bus)).ToList();
        }

        public void SaveBus(BusSaveModel busSave)
        {
            var bus = busSave.ToEntity();
            context.Bus.Add(bus);
            context.SaveChanges();
        }

        public void UpdateBus(BusUpdateModel updateModel)
        {
            var bus = context.Bus.Find(updateModel.IdBus);
            BusException.VerifyExistence(bus, updateModel.IdBus);
            updateModel.UpdateEntity(bus);
            context.Bus.Update(bus);
            context.SaveChanges();
        }

        public void RemoveBus(BusRemoveModel busRemove)
        {
            var bus = context.Bus.Find(busRemove.IdBus);
            BusException.VerifyExistence(bus, busRemove.IdBus);
            context.Bus.Remove(bus);
            context.SaveChanges();
        }
    }

}






