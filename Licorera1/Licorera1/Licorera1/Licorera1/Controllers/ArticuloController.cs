using Licorera.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Licorera.Controllers
{
    public class ArticuloController : Controller
    {

        public static List<Articulo> ArticuloList = new List<Articulo>();

        // GET: ArticuloController
        public ActionResult Index(int? id)
        {

            var ArticuloBuscado = from x in ArticuloList select x;

            if (id != null)
            {
                ArticuloBuscado = ArticuloList.Where(x => x.ArticuloID == id);
            }

            return View(ArticuloBuscado);
        }

        // GET: ArticuloController/Details/5
        public ActionResult Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var detalles = ArticuloList.FirstOrDefault(x => x.ArticuloID == id);

            if (detalles == null)
            {
                return NotFound(id);
            }

            return View(detalles);
        }

        // GET: ArticuloController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArticuloController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Articulo agregarArticulo)
        {
            try
            {

                if (agregarArticulo != null)
                {
                    ArticuloList.Add(agregarArticulo);
                }


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ArticuloController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buscar = ArticuloList.FirstOrDefault(x => x.ArticuloID == id);

            if (buscar == null)
            {
                return NotFound(id);
            }

            return View(buscar);
        }

        // POST: ArticuloController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id, Articulo editarArticulo)
        {
            try
            {

                if (id == null)
                {
                    return NotFound();
                }

                var editar = ArticuloList.FirstOrDefault(x => x.ArticuloID == id);

                if (editar == null)
                {
                    return NotFound(id);
                }

                ArticuloList.Remove(editar);

                ArticuloList.Add(editarArticulo);


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ArticuloController/Delete/5
        public ActionResult Delete(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var eliminar = ArticuloList.FirstOrDefault(x => x.ArticuloID == id);

            if (eliminar == null)
            {
                return NotFound(id);
            }

            return View(eliminar);
        }

        // POST: ArticuloController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int? id, IFormCollection collection)
        {
            try
            {

                if (id == null)
                {
                    return NotFound();
                }

                var eliminar = ArticuloList.FirstOrDefault(x => x.ArticuloID == id);

                if (eliminar != null)
                {
                    ArticuloList.Remove(eliminar);

                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
