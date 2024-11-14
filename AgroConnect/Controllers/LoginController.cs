using AgroConnect.Models;
using AgroConnect.Data;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Security;

namespace AgroConnect.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home"); 
            }

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Logar(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var isValidUser = await model.ValidateUserAsync(_context);

                    if (isValidUser)
                    {
                        FormsAuthentication.SetAuthCookie(model.Username, true); 

                        TempData["SuccessMessage"] = "Login realizado com sucesso!";
                        return RedirectToAction("Index", "Home");
                    }

                    TempData["ErrorMessage"] = "Usuário ou senha inválidos.";
                }
                catch (Exception)
                {
                    TempData["ErrorMessage"] = "Ocorreu um erro ao processar sua solicitação. Tente novamente.";
                }
            }

            return View("Index", model);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            TempData["SuccessMessage"] = "Você foi desconectado com sucesso!";
            return RedirectToAction("Index", "Login");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
