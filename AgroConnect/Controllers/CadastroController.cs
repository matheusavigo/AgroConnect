using AgroConnect.Models;
using AgroConnect.Data;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Security;

namespace AgroConnect.Controllers
{
    public class CadastroController : Controller
    {

        private readonly ApplicationDbContext _context = new ApplicationDbContext();


        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Cadastro cadastro)
        {

            if (ModelState.IsValid)
            {

                var novoCadastro = new Cadastro
                {
                    Id = cadastro.Id,
                    Nome = cadastro.Nome,
                    Email = cadastro.Email,
                    Telefone = cadastro.Telefone,
                    Endereco = cadastro.Endereco,
                    Numero = cadastro.Numero,
                    Cep = cadastro.Cep,
                    Senha = cadastro.Senha,
                    DataCadastro = DateTime.Now

                };

                _context.Cadastroes.Add(novoCadastro);
                _context.SaveChanges();

                TempData["SuccessMessage"] = "Cadastro realizado com sucesso!";
                return RedirectToAction("Index", "Login");

            }

            TempData["ErrorMessage"] = "Não foi possivel realizar o cadastro!";
            return View(cadastro);

   
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
