using DominioClases.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioClases.StaticHelpers
{
    public static class StaticUserLogin
    {
        public static int Id { get; set; }
        public static string Nombre { get; set; }
        public static string Password { get; set; }

        public static void SetUserLogin(Usuario user)
        {
            Id = user.Id;
            Nombre = user.Nombre;
            Password = user.Password;
        }
    }
}
