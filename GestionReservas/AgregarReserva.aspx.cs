using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionReservas.Controller;

namespace GestionReservas
{
    public partial class AgregarReserva1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {           

            if (!Page.IsPostBack)
            {
                cargarDropCancha();
                cargarDropCliente();
                cargarDropProfesor();
            }
        }

        public void cargarDropCancha()
        {
            DropCancha.DataSource = from cancha in CanchaController.FindAll()
                                    select new
                                    {
                                        codigo = cancha.codigo,
                                        texto = cancha.nombre
                                    };
            DropCancha.DataValueField = "codigo";
            DropCancha.DataTextField = "texto";
            DropCancha.DataBind();
        }

        public void cargarDropCliente()
        {
            DropCliente.DataSource = from cliente in ClienteController.FindAll()
                                     select new
                                     {
                                         codigo = cliente.codigo,                                        
                                         texto = cliente.rut  + cliente.nombre + cliente.apellido                                  
                                     };
            DropCliente.DataValueField = "codigo";
            DropCliente.DataTextField = "texto";
            DropCliente.DataBind();
        }

        public void cargarDropProfesor()
        {
            DropProfesor.DataSource = from profesor in ProfesorController.FindAll()
                                      select new
                                      {
                                          codigo = profesor.codigo,
                                          texto = profesor.rut + profesor.nombre + profesor.apellido
                                      };
            DropProfesor.DataValueField = "codigo";
            DropProfesor.DataTextField = "texto";
            DropProfesor.DataBind();
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            DateTime fecha = Calendar1.SelectedDate;

            LbMensaje.Text = ReservaController.AddReserva(TxtCodigo.Text, DropCancha.SelectedValue,
                DropCliente.SelectedValue, DropProfesor.SelectedValue, fecha, TxtHora_ini.Text, TxtHora_fin.Text);
        }

        protected void LnkLista_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListaReservas.aspx");
        }

        protected void LnkBuscar_Click(object sender, EventArgs e)
        {
            Response.Redirect("BuscarReserva.aspx");
        }
        protected void LnkHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DateTime fecha = Calendar1.SelectedDate;
            LbFecha.Text = fecha.ToLongDateString();
        }
    }
}