using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionReservas.Controller;

namespace GestionReservas.Controller
{
    public class ReservaController
    {
        static db_gestionreservasEntities entidades = new db_gestionreservasEntities();

        public static string AddReserva(string codigo, string codCancha, string codCliente, string codProfesor, DateTime fecha, string hora_ini, string hora_fin)
        {
            reserva reserva = new reserva()
            {
                codigo = int.Parse(codigo),
                cancha = int.Parse(codCancha),
                cliente = int.Parse(codCliente),
                profesor = int.Parse(codProfesor),
                fecha = fecha.ToString(),
                hora_ini = (hora_ini).ToString(),
                hora_fin = (hora_fin).ToString()
            };
            entidades.reserva.Add(reserva);
            entidades.SaveChanges();
            return "Reserva agregada";
        }

        public static List<reserva> FindAll()
        {
            var reserva = from r in entidades.reserva
                          select r;

            return reserva.ToList();
        }

        public static reserva FindReserva(int codigo)
        {
            return entidades.reserva.SingleOrDefault(i => i.codigo == codigo);
        }

        public static string RemoveReserva(int codigo)
        {
            reserva reserva = FindReserva(codigo);
            entidades.reserva.Remove(reserva);
            entidades.SaveChanges();
            return "Reserva Eliminada";
        }

        public static string editarReserva(int codigo, string codCancha, string codCliente, string codProfesor, DateTime fecha, string hora_ini, string hora_fin)
        {
            reserva reserva = entidades.reserva.Find(codigo);
            if (reserva != null)
            {
                cancha cancha = CanchaController.FindCancha(codCancha);
                cliente cliente = ClienteController.FindCliente(codCliente);
                profesor profesor = ProfesorController.FindProfesor(codProfesor);

                reserva reserva1 = FindReserva(codigo);

                reserva.fecha = fecha.ToString();
                reserva.hora_ini = int.Parse(hora_ini).ToString();
                reserva.hora_fin = int.Parse(hora_fin).ToString();

                return "Reserva editada";
            }
            else
            {
                return "No se puede editar la reserva";
            }
        }
    }
}