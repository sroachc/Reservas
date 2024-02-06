using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionReservas.Controller;

namespace GestionReservas
{
    public partial class ListaClientes1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            var cli = from cliente in ClienteController.FindAll()
                      select new
                      {
                          Codigo = cliente.codigo,
                          Rut = cliente.rut,
                          Nombre = cliente.nombre + " " + cliente.apellido,
                          Correo = cliente.correo
                      };

            GrdClientes.DataSource = cli;
            GrdClientes.DataBind();
        }
        protected void LnkHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}