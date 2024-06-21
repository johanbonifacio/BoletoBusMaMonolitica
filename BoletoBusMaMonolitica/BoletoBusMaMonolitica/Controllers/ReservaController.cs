using BoletoBusMaMonolitica.Data.Context;
using BoletoBusMaMonolitica.Data.DbObjects;
using BoletoBusMaMonolitica.Data.Interfaces;
using BoletoBusMaMonolitica.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.IdentityModel.Tokens;

namespace BoletoBusMaMonolitica.Controllers
{
    public class ReservaController : Controller
    {
        private readonly IReservaDb reservaDb;

        public ReservaController( IReservaDb reservaDb)
        {
            this.reservaDb = reservaDb;
        }


        // GET: ReservaController
        public ActionResult Index()
        {
            var reserva = this.reservaDb.GetReservas();
            return View(reserva);
        }

        // GET: ReservaController/Details/5
        public ActionResult Details(int id)

        {
            var reserva = this.reservaDb.GetReservas(id);
            return View(reserva);
        }

        // GET: ReservaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReservaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReservaSaveModel reservaSave)
        {
            try
            {
                reservaSave.FechaCreacion = DateTime.Now;
                this.reservaDb.SaveReserva(reservaSave);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReservaController/Edit/5
        public ActionResult Edit(int id)
        {
            var reserva = this.reservaDb.GetReservas(id);
            return View(reserva);
        }

        // POST: ReservaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ReservaUpdateModel reservaUpdate)
        {
            try
            {
                reservaUpdate.FechaCreacion = DateTime.Now;
                this.reservaDb.UpdateReserva(reservaUpdate);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

      
        
        
    }
}