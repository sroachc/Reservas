using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionReservas.Controller{
    public class ClienteController
    {        
        static db_gestionreservasEntities entidades = new db_gestionreservasEntities();
        
        public static string AddCliente(string codigo, string rut, string nombre, string apellido, string telefono, string direccion, string correo, string contraseña)
        {
            cliente cliente= new cliente()
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

            entidades.cliente.Add(cliente);
            entidades.SaveChanges();
            return "Cliente Agregado";
        }

        public static List<cliente> FindAll()
        {
            var cliente = from r in entidades.cliente
                          select r;

            return cliente.ToList();
        }
        
        public static cliente FindCliente(string codigo)
        {
            return entidades.cliente.SingleOrDefault(i => i.codigo == int.Parse(codigo));
        }
        
        public static string RemoveClientes(string codigo)
        {
            cliente clientes = FindCliente(codigo);
            entidades.cliente.Remove(clientes);
            entidades.SaveChanges();
            return "Cliente Eliminado";
        }
        
        public static string editarClientes(string codigo, string rut, string nombre, string apellido, string telefono, string direccion, string correo, string contraseña)
        {
            cliente cliente = entidades.cliente.SingleOrDefault(i => i.codigo == int.Parse(codigo));
            if (cliente != null)
            {
                cliente.codigo = int.Parse(codigo);
                entidades.SaveChanges();
                return "Cliente Editado";
            }
            else
            {
                return "No se puede eliminar el cliente";
            }
            
        }
    }
}