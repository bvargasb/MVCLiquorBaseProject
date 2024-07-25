using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Licorera.Models;

namespace Licorera.Controllers
{
    public class PedidosController : Controller
    {
        public static List<Pedidos> PedidosList = new List<Pedidos>();

        // GET: PedidosController1
        public ActionResult Index(int? id)
        {

            var Pedidos = from x in PedidosList select x;

            if (id != null)
            {
                Pedidos = PedidosList.Where(x => x.IDpedido == id);
            }

            return View(Pedidos);

        }

        // GET: Pedidos/Details/5
        public ActionResult Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var detalles = PedidosList.FirstOrDefault(x => x.IDpedido == id);

            if (detalles == null)
            {
                return NotFound(detalles);
            }

            return View(detalles);
        }

        // GET: Pedidos/Create
        public ActionResult Create(int? id)
        {

            return View();
        }

        // POST: Pedidos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pedidos CrearPedido)
        {
            try
            {
                if (CrearPedido != null)
                {
                    PedidosList.Add(CrearPedido);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Pedidos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Editar = PedidosList.FirstOrDefault(x => x.IDpedido == id);

            if (Editar == null)
            {
                return NotFound(id);
            }

            return View(Editar);
        }

        // POST: Pedidos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id, Pedidos EditarArticulo)
        {
            try
            {
                if (id == null)
                {
                    return NotFound();
                }

                var editar = PedidosList.FirstOrDefault(x => x.IDpedido == id);

                if (editar != null)
                {
                    PedidosList.Remove(editar);
                    PedidosList.Add(EditarArticulo);
                }


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Pedidos/Delete/5
        public ActionResult Delete(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }


            var pedidos = PedidosList.FirstOrDefault(x => x.IDpedido == id);


            if (pedidos == null)
            {
                return NotFound(id);
            }



            return View(pedidos);
        }

        // POST: Pedidos/Delete/5
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

                var pedidoEliminar = PedidosList.FirstOrDefault(x => x.IDpedido == id);

                if (pedidoEliminar != null)
                {
                    PedidosList.Remove(pedidoEliminar);
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
