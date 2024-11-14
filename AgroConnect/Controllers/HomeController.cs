using System;
using System.Linq;
using System.Web.Mvc;
using AgroConnect.Models;

namespace AgroConnect.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NovoPedido()
        {
            if (!User.Identity.IsAuthenticated)
            {
                TempData["ErrorMessage"] = "Você precisa estar logado para acessar esta página.";

                return RedirectToAction("Index", "Login");
            }

            return View();
        }

        public ActionResult AcompanharPedido()
        {
            if (!User.Identity.IsAuthenticated)
            {
                TempData["ErrorMessage"] = "Você precisa estar logado para acessar esta página.";

                return RedirectToAction("Index", "Login");
            }

            return View();
        }
    }
}
