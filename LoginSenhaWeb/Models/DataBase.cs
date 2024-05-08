using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LoginSenhaWeb.Models
{
    public class DataBase : DbContext
    {
        private static string ConnStr = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=LSWeb;Data Source=DESKTOP-EE2NMJE";
        public static bool GetConnetion()
        {
            try
            {
                using (var cn = new SqlConnection(ConnStr))
                {
                    cn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao testar conexão: " + ex.Message);
                return false;
            }
        }

        public static bool UserExists(string username, string password)
        {
            try
            {
                using (var cn = new SqlConnection(ConnStr))
                {
                    cn.Open();

                    string query = $"SELECT COUNT(*) FROM [User] WHERE username = '{username}' AND password = '{password}'";
                    using (var cmd = new SqlCommand(query, cn))
                    {
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao verificar usuário: " + ex.Message);
                return false;
            }
        }
        public static bool UserExistsCadastro(string username)
        {
            try
            {
                using (var cn = new SqlConnection(ConnStr))
                {
                    cn.Open();
                    string query = $"select count(*) from [User] where username = '{username}'";
                    using (var cmd = new SqlCommand(query, cn))
                    {
                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0) return true;
                        else return false;                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao verificar usuario: " + ex.Message);
                return false;
            }
        }
        public static bool CriandoUsuario(string username, string password)
        {
            try
            {
                if (UserExistsCadastro(username))
                {
                    return false;
                }
                using (var cn = new SqlConnection(ConnStr))
                {
                    cn.Open();
                    string query = $"INSERT INTO[User] (username, password) VALUES('{username}', '{password}')";
                    using (var cmd = new SqlCommand(query, cn))
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro ao cadastrar usuário: " + ex.Message);
                return false;
            }
        }
    }
}
