using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionReservas.Controller
{
    public class ProfesorController
    {
        static db_gestionreservasEntities entidades = new db_gestionreservasEntities();

        public static string AddProfesor(string codigo, string rut, string nombre, string apellido, string telefono, string direccion, string correo, string contraseña)
        {
            profesor profesor = new profesor()
            {
                codigo = int.Parse(codigo),
                rut = rut,
                nombre = nombre,
                apellido = apellido,
                telefono = int.Parse(telefono),
                direccion = direccion,
                correo = correo,
                contrasena = contraseña
            };

            entidades.profesor.Add(profesor);
            entidades.SaveChanges();
            return "Profesor Agregado";
        }

        public static List<profesor> FindAll()
        {
            var profesor = from r in entidades.profesor
                           select r;

            return profesor.ToList();
        }
        public static profesor FindProfesor(string codigo)
        {
            return entidades.profesor.SingleOrDefault(i => i.codigo == int.Parse(codigo));
        }

        public static string RemoveProfesor(string codigo)
        {
            profesor profesor = FindProfesor(codigo);
            entidades.profesor.Remove(profesor);
            entidades.SaveChanges();
            return "Profesor Eliminado";
        }

        public static string editarProfesor(int codigo, string rut, string nombre, string apellido, string telefono, string direccion, string correo, string contraseña)
        {
            profesor profesor = entidades.profesor.SingleOrDefault(i => i.codigo == codigo);
            if (profesor != null)
            {
                profesor.codigo = codigo;
                profesor.rut = rut;
                profesor.nombre = nombre;
                profesor.apellido = apellido;
                profesor.telefono = int.Parse(telefono);
                profesor.direccion = direccion;
                profesor.correo = correo;
                profesor.contrasena = contraseña;
                entidades.SaveChanges();
                return "Profesor editado";
            }
            else
            {
                return "No se puede editar";
            }
        }
    }
}