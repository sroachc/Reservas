using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionReservas.Controller;

namespace GestionReservas.Controller
{
    public class LoginController
    {
        static db_gestionreservasEntities entidades = new db_gestionreservasEntities();
        public static usuario Login(string username, string password)
        {
            usuario lgu = UsuarioController.FindUser(username);
            if (lgu != null)
            {
                if (lgu.password.Equals(password))
                {
                    return lgu;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
    }
}