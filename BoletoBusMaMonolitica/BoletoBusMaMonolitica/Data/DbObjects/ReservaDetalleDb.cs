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
    public class ReservaDetalleDb : IReservaDetalleDb
    {
        private readonly BoletoBusContext context;
        public ReservaDetalleDb(BoletoBusContext context)
        {
            this.context = context;
        }

        public ReservaDetalleModel GetReservaDetalle(int IdReservaDetalle)
        {
            var reservaDetalle = context.ReservaDetalle.Find(IdReservaDetalle);
            return ReservaDetalleModel.FromEntity(reservaDetalle);
        }

        public List<ReservaDetalleModel> GetReservaDetalles()
        {
            return context.ReservaDetalle.Select(reservaDetalle => ReservaDetalleModel.FromEntity(reservaDetalle)).ToList();
        }

        public void SaveReservaDetalle(ReservaDetalleSaveModel reservaDetalleSave)
        {
            var reservaDetalle = reservaDetalleSave.ToEntity();
            context.ReservaDetalle.Add(reservaDetalle);
            context.SaveChanges();
        }

        public void UpdateReservaDetalle(ReservaDetalleUpdateModel updateModel)
        {
            var reservaDetalle = context.ReservaDetalle.Find(updateModel.IdReservaDetalle);
            ReservaDetalleException.VerifyExistence(reservaDetalle, updateModel.IdReservaDetalle);
            updateModel.UpdateEntity(reservaDetalle);
            context.ReservaDetalle.Update(reservaDetalle);
            context.SaveChanges();
        }

        public void RemoveReservaDetalle(ReservaDetalleRemoveModel reservaDetalleRemove)
        {
            var reservaDetalle = context.ReservaDetalle.Find(reservaDetalleRemove.IdReservaDetalle);
            ReservaDetalleException.VerifyExistence(reservaDetalle, reservaDetalleRemove.IdReservaDetalle);
            context.ReservaDetalle.Remove(reservaDetalle);
            context.SaveChanges();
        }
    }
}
