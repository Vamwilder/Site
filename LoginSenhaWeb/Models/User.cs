using Microsoft.AspNetCore.Mvc;

namespace LoginSenhaWeb.Models
{
    public class User
    {
        public int id_user { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
