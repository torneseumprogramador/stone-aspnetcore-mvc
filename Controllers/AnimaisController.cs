using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;
using WebMVC.Servicos;

namespace WebMVC.Controllers
{
    public class AnimaisController : Controller
    {
        // [Route("/animais-domesticos")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(string nome)
        {
            AnimalServico.Instancia().Add(new Animal() { 
                Nome = nome
            });

            ViewBag.mensagem = "Cadastrado com sucesso";
            return View();
        }
    }
}