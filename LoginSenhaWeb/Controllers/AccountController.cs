using Microsoft.AspNetCore.Mvc;
using LoginSenhaWeb.Models;

namespace LoginSenhaWeb.Controllers
{
    public class AccountController : Controller
    {       

        public IActionResult Login()
        {
            // Lógica de autenticação
            // Verifique se o usuário e a senha são validas

            return RedirectToAction("Index", "Home");
        }
        public IActionResult Register()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
