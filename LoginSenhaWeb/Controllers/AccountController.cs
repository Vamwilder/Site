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
            if(DataBase.CriandoUsuario(username, password) == false)
            {
                TempData["ErrorMessage"] = "Erro ao cadastrar Usuário, ou Usuário ja cadastrado";
                return RedirectToAction("NovoUsuario", "Account");
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
