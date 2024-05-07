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
                return View();
            }else
            {
                return RedirectToAction("Login", "Home");
            }
        }
        public IActionResult Register()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
