using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercicio1MatLeo.Controllers
{
    public class AulaController : Controller
    {
        // GET: Aula
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AlunoResult()
        {
            TempData["Exibe"] = "O MVC é um padrão de desenvolvimento muito utilizado no mundo web é conhecido por 'forçar' o programador a separar as responsabilidades.";
            return RedirectToAction("Aluno");
        }
        public ActionResult Aluno()
        {
            ViewBag.Message1 = "Os melhores alunos são aqules que estudam mais!";
            return View();
        }

        public ActionResult Redirecionamento()
        {
            return Redirect("https://google.com");
        }
    }
}