using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Licorera.Data;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Licorera.Models;

namespace Licorera.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        // public Licorera1Context Datos;

        public static List<Cliente> ClienteList = new List<Cliente>();

        public ActionResult Index(int? id)
        {


            var Clientes = from x in ClienteList select x; //linq para consultar toda la base de la lista

            if (id != null)
            {
                Clientes = ClienteList.Where(x => x.ClienteID == id); //si el ID no viene nulo es una consulta y le asignamos el valor de ID a la vista que va a mostrar. 
            }

            return View(Clientes);
        }


        // GET: Clientes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Detalles = ClienteList.FirstOrDefault(m => m.ClienteID == id);

            if (Detalles == null)
            {
                return NotFound(id);
            }

            return View(Detalles);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cliente cliente)
        {
            try
            {
                if (cliente != null)
                {

                    ClienteList.Add(cliente);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound(id);
            }

            var Cliente = ClienteList.FirstOrDefault(x => x.ClienteID == id);

            if (Cliente == null)
            {
                NotFound(id);

            }

            return View(Cliente);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id, Cliente clienteEditar)
        {
            try
            {

                if (id == null)
                {
                    return NotFound(id);
                }

                var Cliente = ClienteList.FirstOrDefault(x => x.ClienteID == id);

                if (Cliente == null)
                {
                    return NotFound(id);
                }
                //borramos los datos del cliente y luego creamos un nuevo cliente. 
                ClienteList.Remove(Cliente);

                ClienteList.Add(clienteEditar);


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int? id)
        {
            try
            {

                if (id == null)
                {
                    return NotFound();
                }

                var clienteRemover = ClienteList.FirstOrDefault(m => m.ClienteID == id);

                if (clienteRemover == null)
                {

                    return NotFound();
                }

                return View(clienteRemover);


            }
            catch
            {
                return View();
            }
        }

        // POST: Clientes/Delete/5
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

                var clienteRemover = ClienteList.FirstOrDefault(m => m.ClienteID == id);

                if (clienteRemover != null)
                {
                    ClienteList.Remove(clienteRemover);

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
