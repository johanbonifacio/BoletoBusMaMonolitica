using BoletoBusMaMonolitica.BL.Interfaces;
using BoletoBusMaMonolitica.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace BoletoBusMaMonolitica.Controllers
{
    public class BusController : Controller
    {
        private readonly IBusService busService;

        public BusController(IBusService busService)
        {
            this.busService = busService;
        }

        // GET: BusController
        public ActionResult Index()
        {
            var result = this.busService.GetBuses();

            if (!result.Success)
                ViewBag.Message = result.Message;

            var bus = (List<BusGetModel>)result.Data;
            return View(bus);
        }

        // GET: BusController/Details/5
        public ActionResult Details(int id)
        {
            var result = this.busService.GetBus(id);

            if (!result.Success)
                return NotFound(result.Message);

            var bus = (BusGetModel?)result.Data;
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
               var result = this.busService.SaveBus(busSave); 
               if (result.Success) 
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.Message = result.Message; 
                    return View(busSave);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: BusController/Edit/5
        public ActionResult Edit(int id)
        {
            var result = this.busService.GetBus(id);

            if (!result.Success)
                return NotFound(result.Message);

            var bus = (BusGetModel)result.Data; 
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
                this.busService.UpdateBuses(busUpdate);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}


