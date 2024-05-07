using Microsoft.AspNetCore.Mvc;
using LoginSenhaWeb.Models;

namespace LoginSenhaWeb.Controllers
{
    public class AccountController : Controller
    {       

        public IActionResult Logado()
        {
            if(DataBase.GetConnetion() == true)
            {
                return View();
            }else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult Register()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
