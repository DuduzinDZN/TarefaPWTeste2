using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TarefaPWTeste2.Models;

namespace TarefaPWTeste2.Controllers
{
    public class FilmeController : Controller
    {
        // GET: FilmeController
        public ActionResult Index()
        {
            return View(FilmeModel.CriarLista());
        }

        // GET: FilmeController/Details/5
        public ActionResult Details(int id)
        {
            return View(FilmeModel.CriarLista()[id]);
        }

        // GET: FilmeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FilmeController/Create
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

        // GET: FilmeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(FilmeModel.CriarLista()[id]);
        }

        // POST: FilmeController/Edit/5
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

        // GET: FilmeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(FilmeModel.CriarLista()[id]);
        }

        // POST: FilmeController/Delete/5
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
