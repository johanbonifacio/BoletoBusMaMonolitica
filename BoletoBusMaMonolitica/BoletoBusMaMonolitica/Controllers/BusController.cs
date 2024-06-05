﻿using BoletoBusMaMonolitica.Data.Context;
using BoletoBusMaMonolitica.Data.Interfaces;
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
            return View();
        }

        // GET: BusController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BusController/Create
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

        // GET: BusController/Edit/5
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

        // GET: BusController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BusController/Delete/5
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
