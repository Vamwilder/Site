using Microsoft.AspNetCore.Mvc;

namespace LoginSenhaWeb.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
