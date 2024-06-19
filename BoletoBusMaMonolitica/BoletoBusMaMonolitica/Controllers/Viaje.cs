using BoletoBusMaMonolitica.Data.Context;
using BoletoBusMaMonolitica.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoletoBusMaMonolitica.Controllers
{
    public class ViajeController : Controller
    {
        private readonly IBusDb busDb;

        public ViajeController(IViajeDb ViajeDb)
        {
            this.ViajeDb = ViajeDb;
        }
        // GET: ViajeController
        public ActionResult Index()
        {
            var viaje = this.ViajeDb.GetViajes();
            return View(viaje);
        }

        // GET: ViajeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ViajeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ViajeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ViajeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BusController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ViajeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ViajeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}