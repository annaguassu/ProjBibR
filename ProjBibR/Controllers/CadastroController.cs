using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjBibR.Entidades;
using System.Linq;

namespace ProjBibR.Controllers
{
    public class CadastroController : Controller
    {
        private readonly Contexto db;

        public CadastroController(Contexto contexto)
        {
            db = contexto;
        }

        // GET: CadastroController
        public ActionResult index()
        {
            return View();
        }

        // GET: CadastroController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CadastroController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CadastroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User collection)
        {
            try
            {
                db.Users.Add(collection);
                db.SaveChanges();
                return RedirectToAction("index","home");
            }
            catch
            {
                return View();
            }
        }

        // GET: CadastroController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CadastroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction("index", "home");
            }
            catch
            {
                return View();
            }
        }

        // GET: CadastroController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CadastroController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction("index", "home");
            }
            catch
            {
                return View();
            }
        }
    }
}
