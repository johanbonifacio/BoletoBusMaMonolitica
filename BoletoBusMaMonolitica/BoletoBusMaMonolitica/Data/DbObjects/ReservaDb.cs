

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
    public class ReservaDb : IReservaDb
    {
        private readonly BoletoBusContext context;

        public ReservaDb(BoletoBusContext context)
        {
            this.context = context;
        }

        public ReservaModel GetReservas(int IdReserva)
        {
            var reserva= this.context.Reserva.Find(IdReserva);
             return ReservaModel.FromEntity(reserva);
            
            
        } 

        public List<ReservaModel> GetReservas()
        {
            return context.Reserva.Select(reserva => ReservaModel.FromEntity(reserva)).ToList();
        }

        public void RemoveReserva(ReservaRemoveModel reservaRemove)
        {
             
            var reserva = context.Reserva.Find(reservaRemove.IdReserva);
            ReservaException.VerifyExistence(reserva, reservaRemove.IdReserva);
            context.Reserva.Remove(reserva);
            context.SaveChanges();
        }

        public void SaveReserva(ReservaSaveModel reservaSave)
        {
            var reserva = reservaSave.ToEntity();
            context.Reserva.Add(reserva);
            context.SaveChanges();
        }

        public void UpdateReserva(ReservaUpdateModel updateModel)
        {
            var reserva = context.Reserva.Find(updateModel.IdReserva);
            ReservaException.VerifyExistence(reserva, updateModel.IdReserva);
            updateModel.UpdateEntity(reserva);
            context.Reserva.Update(reserva);
            context.SaveChanges();
        }
    }
}