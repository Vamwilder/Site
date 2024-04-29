using LoginSenhaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LoginSenhaWeb.Controllers
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
        public IActionResult Contatos()
        {
            return View();
        }


        public IActionResult Login()        
        {
            TestarConexao();
            return View();
        }

        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        static void TestarConexao()
        {
            Console.WriteLine("Entrou em Login");
            try
            {
                var connection = ConnectionManager.GetConnetion();
                connection.Open();
                connection.Close();
                Console.WriteLine("Conexão com banco de dados realizada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
    }
}