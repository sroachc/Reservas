using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionReservas.Controller
{
    public class CanchaController
    {
        static db_gestionreservasEntities entidades = new db_gestionreservasEntities();

        public static string AddCancha(string codigo, string nombre)
        {
            cancha cancha = new cancha()
            {
                codigo = int.Parse(codigo),
                nombre = nombre
            };

            entidades.cancha.Add(cancha);
            entidades.SaveChanges();
            return "Cancha Agregada";
        }

        public static List<cancha> FindAll()
        {

            var cancha = from r in entidades.cancha
                         select r;

            return cancha.ToList();
        }

        public static cancha FindCancha(string codigo)
        {

            return entidades.cancha.SingleOrDefault(i => i.codigo == int.Parse(codigo));
        }

        public static string RemoveCancha(string codigo)
        {
            cancha cancha = FindCancha(codigo);
            entidades.cancha.Remove(cancha);
            entidades.SaveChanges();
            return "Cancha Eliminada";
        }

        public static string editarCancha(string codigo, string nombre)
        {
            cancha cancha = entidades.cancha.SingleOrDefault(i => i.codigo == int.Parse(codigo));
            if (cancha != null)
            {
                cancha.codigo = int.Parse(codigo);
                entidades.SaveChanges();
                return "Cancha Eliminada";
            }
            else
            {
                return "No se puede eliminar la cancha";
            }
        }
    }
}