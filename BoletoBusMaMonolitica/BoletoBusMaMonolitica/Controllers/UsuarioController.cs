using BoletoBusMaMonolitica.Data.Context;
using BoletoBusMaMonolitica.Data.Interfaces;
using BoletoBusMaMonolitica.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.IdentityModel.Tokens;

namespace BoletoBusMaMonolitica.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioDb usuarioDb;

        public UsuarioController(IUsuarioDb usuarioDb)
        {
            this.usuarioDb = usuarioDb;
        }


        // GET: UsuarioController
        public ActionResult Index()
        {
            var usuario = this.usuarioDb.GetUsuarios();
            return View(usuario);
        }

        // GET: suarioController/Details/5
        public ActionResult Details(int id)
        {
            var usuario = this.usuarioDb.GetUsuarios(id);
            return View(usuario);
        }

        // GET: UsuarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioSaveModel usuarioSave)
        {
            try
            {
                usuarioSave.FechaCreacion = DateTime.Now;
                this.usuarioDb.SaveUsuario(usuarioSave);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            var usuario = this.usuarioDb.GetUsuarios(id);
            return View(usuario);
        }

        // POST: UsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, UsuarioUpdateModel usuarioUpdate)
        {
            try
            {
                usuarioUpdate.FechaCreacion = DateTime.Now;
                this.usuarioDb.UpdateUsuario(usuarioUpdate);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
        
    }
}