using BoletoBusMaMonolitica.Data.DbObjects;
using BoletoBusMaMonolitica.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BoletoBusMaMonolitica.Data.Models;

namespace BoletoBusMaMonolitica.Controllers
{
    public class AsientoController : Controller
    {
        private readonly IAsientoDb asientoDb;
        public AsientoController(IAsientoDb asientoDb)
        {
            this.asientoDb = asientoDb;
        }
        // GET: AsientoController
        public ActionResult Index()
        {
            var asiento = this.asientoDb.GetAsientos();
            return View(asiento);
        }

        // GET: AsientoController/Details/5
        public ActionResult Details(int id)
        {
            var asiento = this.asientoDb.GetAsiento(id);
            return View(asiento);
        }

        // GET: AsientoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AsientoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AsientoSaveModel asientoSave)
        {
            try
            {
                asientoSave.FechaCreacion = DateTime.Now;
                this.asientoDb.SaveAsiento(asientoSave);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AsientoController/Edit/5
        public ActionResult Edit(int id)
        {
            var asiento = asientoDb.GetAsiento(id);
            return View(asiento);
        }

        // POST: AsientoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AsientoUpdateModel asientoUpdate)
        {
            try
            {
                asientoUpdate.FechaCreacion = DateTime.Now;
                this.asientoDb.UpdateAsiento(asientoUpdate);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
