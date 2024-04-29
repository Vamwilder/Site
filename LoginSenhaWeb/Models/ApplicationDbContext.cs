using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace LoginSenhaWeb.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
    public class ConnectionManager
    {
        private static string ConnStr = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=LSWeb;Data Source=DESKTOP-EE2NMJE";
        public static SqlConnection GetConnetion()
        {
            var cn = new SqlConnection(ConnStr);
            return cn;
        }


    }
}
