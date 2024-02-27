using Microsoft.AspNetCore.Mvc;
using RM99585.Models;
using System.Diagnostics;

namespace RM99585.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Aluno()
        {
            string nomeAluno = "Gustavo";

            Aluno aluno = new Aluno();
            aluno.SetNome(nomeAluno);
            aluno.RM = 1914;
            aluno.Email = "1914@fiap.com.br";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
