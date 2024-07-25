using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Licorera.Models;

using System.Security.Policy;
using System.Diagnostics.Eventing.Reader;

namespace Licorera.Controllers
{
    public class HomeController : Controller
    {


        /*public static List<Login> LogginList =  new List<Login>();

        [HttpPost]
        public ActionResult Loggin(Login? login, string usuario)
        {
            bool loginInicio = false;
            bool loginContrasenha = false;

            if(login == null && usuario != null)
            {
             LogginList.Add(new Login() { Usuario = usuario, Contrasena = " "}); // solo se registra el loggin del usuario sin contrseña. 

                loginInicio = true;
            }

            if (login != null)
            {
                LogginList.Add(login);
                loginContrasenha = true;
            }

            if (loginInicio)
            {
                 return RedirectToAction(nameof(Registro));
            }

            if (loginContrasenha)
            {
                return RedirectToAction(nameof(Menu));

            }
            return View();
        }

        public ActionResult Menu() 
        {
        
            return View();
        
        }

        public ActionResult Registro() 
        {
            return View();
        } */



        // GET: HomeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController/Create
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

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController/Edit/5
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

        // GET: HomeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController/Delete/5
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
