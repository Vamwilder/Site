using Microsoft.AspNetCore.Mvc;

namespace LoginSenhaWeb.Controllers
{
    public class AccountController : Controller
    {
        

        public IActionResult Login(string username, string password)
        {
            // Lógica de autenticação
            // Verifique se o usuário e a senha são validas

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register(string username, string password)
        {
            // Lógica de registrar de novo usuário
            // Crie um novo usuário com o nome de usuário e senha fornecidos

            return RedirectToAction("Login");
        }
    }
}
