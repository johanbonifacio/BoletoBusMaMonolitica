using BoletoBusMaMonolitica.BL.Interfaces;
using BoletoBusMaMonolitica.Data.Interfaces;
using BoletoBusMaMonolitica.Data.Models.Rut;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BoletoBusMaMonolitica.Controllers
{
    public class RutaController : Controller
    {
        private readonly IRutaService rutaService;

        public object RutaUpdate { get; private set; }

        public RutaController(IRutaService rutaService)
        {
            this.rutaService = rutaService;
        }

        // GET: RutaController
        public ActionResult Index()
        {
            var result = this.rutaService.GetRutas();

            if (!result.Success)
            {
                ViewBag.Message = result.Message;
                return View();
            }

            var rutasGet = result.Data as List<RutaGetModel>;
            if (rutasGet != null)
            {
                var rutas = rutasGet.Select(r => new RutaGetModel
                {
                    IdRuta = r.IdRuta,
                    Origen = r.Origen,
                    Destino = r.Destino,
                    ChangeUser = r.ChangeUser,
                    ChangeDate = r.ChangeDate
                }).ToList();

                return View(rutas);
            }

            ViewBag.Message = "Error al obtener las rutas.";
            return View();
        }

        // GET: RutaController/Details/5
        public ActionResult Details(int id)
        {
            var result = this.rutaService.GetRutas(id);

            if (!result.Success)
            {
                ViewBag.Message = result.Message;
                return View();
            }

            var ruta = result.Data as RutaGetModel;
            if (ruta != null)
            {
                return View(ruta);
            }

            ViewBag.Message = "Ruta no encontrada.";
            return View();
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
                this.rutaService.SaveRutas(rutaSave);
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
            var result = this.rutaService.GetRutas(id);

            if (!result.Success)
            {
                ViewBag.Message = result.Message;
                return View();
            }

            var ruta = result.Data as RutaGetModel;
            if (ruta != null)
            {
                return View(ruta);
            }

            ViewBag.Message = "Ruta no encontrada.";
            return View();
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
                this.rutaService.UpdateRutas(rutaUpdate);
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