using BoletoBusMaMonolitica.BL.Interfaces;
using BoletoBusMaMonolitica.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace BoletoBusMaMonolitica.Controllers
{
    public class AsientoController : Controller
    {
        private readonly IAsientoService asientoService;

        public AsientoController(IAsientoService asientoService)
        {
            this.asientoService = asientoService;
        }

        // GET: AsientoController
        public ActionResult Index()
        {
            var result = this.asientoService.GetAsientos();

            if (!result.Success)
                ViewBag.Message = result.Message;

            var asientos = (List<AsientoGetModel>)result.Data;
            return View(asientos);
        }

        // GET: AsientoController/Details/5
        public ActionResult Details(int id)
        {
            var result = this.asientoService.GetAsiento(id);

            if (!result.Success)
                return NotFound(result.Message);

            var asiento = (AsientoGetModel?)result.Data;
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
                var result = this.asientoService.SaveAsiento(asientoSave);
                if (result.Success)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.Message = result.Message;
                    return View(asientoSave);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: AsientoController/Edit/5
        public ActionResult Edit(int id)
        {
            var result = this.asientoService.GetAsiento(id);

            if (!result.Success)
                return NotFound(result.Message);

            var asiento = (AsientoGetModel)result.Data;
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
                this.asientoService.UpdateAsiento(asientoUpdate);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

