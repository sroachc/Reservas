using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionReservas.Controller;

namespace GestionReservas.Controller
{
    public class UsuarioController
    {
        static db_gestionreservasEntities entidades = new db_gestionreservasEntities();

        public static string AddUser(string codigo, string user, string pass, int rol)
        {
            usuario usuario = new usuario()
            {
                username = user,
                codigo = int.Parse(codigo),
                password = pass,
                rol = rol
            };
            entidades.usuario.Add(usuario);
            entidades.SaveChanges();
            return "Cancha Agregada";
        }

        public static List<usuario> FindAll()
        {
            var usuario = from r in entidades.usuario
                          select r;

            return usuario.ToList();
        }

        public static usuario FindUser(string username)
        {
            return entidades.usuario.SingleOrDefault(i => i.username == username);
        }

        public static string RemoveUser(string codigo)
        {
            usuario usuario = FindUser(codigo);
            entidades.usuario.Remove(usuario);
            entidades.SaveChanges();
            return "Usuario Eliminado";
        }

        public static string editarUser(int codigo, string nombre)
        {
            usuario usuario = entidades.usuario.Find(codigo);
            if (usuario != null)
            {
                usuario.codigo = codigo;
                entidades.SaveChanges();
                return "Usuario Editado";
            }
            else
            {
                return "No se puede editar el usuario";
            }
        }
    }
}