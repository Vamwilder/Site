using Microsoft.AspNetCore.Mvc;
using LoginSenhaWeb.Models;

namespace LoginSenhaWeb.Controllers
{
    public class AccountController : Controller
    {               

        public IActionResult Logado(string username, string password)
        {
            if(DataBase.UserExists(username, password) == true)
            {
                TempData["ErrorMessage"] = null;
                return View();
            }else
            {
                TempData["ErrorMessage"] = "Usuário ou senha incorretos.";
                return RedirectToAction("Login", "Home");
            }
        }
        public IActionResult Register(string username, string password)
        {
            TempData["ErrorMessage"] = null;
            TempData["SucessMessage"] = null;
            if (username == null || password == null)
            {
                TempData["ErrorMessage"] = "Por favor digite usuário e senha";
                return RedirectToAction("Login", "Home");
            }
            else
            {
                TempData["SucessMessage"] = "Usuário cadastrado com sucesso!";
                return RedirectToAction("Login", "Home");
            }            
        }
        public IActionResult NovoUsuario()
        {
            return View();
        }
    }
}
