using Microsoft.AspNetCore.Mvc;
using LoginSenhaWeb.Models;

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
        private readonly ApplicationDbContext _context;
        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Register(string username, string password)
        {
            var newUser = new User
            {
                Username = username,
                Password = password
            };

            _context.Users.Add(newUser);
            _context.SaveChanges();

            return RedirectToAction("Login");
        }
    }
}
