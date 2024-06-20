using BoletoBusMaMonolitica.Data.Context;
using BoletoBusMaMonolitica.Data.Interfaces;
using BoletoBusMaMonolitica.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoletoBusMaMonolitica.Controllers
{
    public class BusController : Controller
    {
        private readonly IBusDb busDb;
       
        public BusController(IBusDb busDb) 
        {
            this.busDb = busDb;
        }
        // GET: BusController
        public ActionResult Index()
        {
            var bus = this.busDb.GetBuses();
            return View(bus);
        }
                        
        // GET: BusController/Details/5
        public ActionResult Details(int id)
        {
            var bus = this.busDb.GetBus(id);
            return View(bus);
        }

        // GET: BusController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BusController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BusSaveModel busSave)
        {
            try
            {
                busSave.FechaCreacion = DateTime.Now;
                this.busDb.SaveBus(busSave);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BusController/Edit/5
        public ActionResult Edit(int id)
        {
            var bus = this.busDb.GetBus(id);
            return View(bus);
        }

        // POST: BusController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BusUpdateModel busUpdate)
        {
            try
            {
                busUpdate.FechaCreacion = DateTime.Now;
                this.busDb.UpdateBus(busUpdate);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
