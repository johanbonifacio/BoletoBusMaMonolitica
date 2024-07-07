using BoletoBusMaMonolitica.Data.Interfaces;
using BoletoBusMaMonolitica.Data.Models.Rut;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoletoBusMaMonolitica.Controllers
{
    public class RutaController : Controller
    {
        private readonly IRutaDB rutaDb;

        public object RutaUpdate { get; private set; }

        public RutaController(IRutaDB rutaDb)
        {
            this.rutaDb = rutaDb;
        }


        // GET: RutaController
        public ActionResult Index()
        {
            var ruta = this.rutaDb.GetRutas();
            return View(ruta);
        }

        // GET: RutaController/Details/5
        public ActionResult Details(int id)
        {
            var ruta = this.rutaDb.GetRuta(id);
            return View(ruta);
        }

        // GET: RutaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RutaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RutaSaveModel rutaSave)
        {
            try
            {
                rutaSave.ChangeDate = DateTime.Now;
                rutaSave.ChangeUser = 1;
                this.rutaDb.SaveRuta(rutaSave);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RutaController/Edit/5
        public ActionResult Edit(int id)
        {
            var ruta = rutaDb.GetRuta(id);
            return View(ruta);

        }

        // POST: RutaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, RutaUpdateModel rutaUpdate)
        {
            try
            {
                rutaUpdate.ChangeDate = DateTime.Now;
                rutaUpdate.ChangeUser = 1;
                this.rutaDb.UpdateRuta(rutaUpdate);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RutaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RutaController/Delete/5
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
