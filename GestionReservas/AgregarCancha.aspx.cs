using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionReservas.Controller;

namespace GestionReservas
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void BtnAgregar_Click(object sender, EventArgs e)
        {

            LbMensaje.Text = CanchaController.AddCancha(TxtCodigo.Text, TxtNombre.Text);
        }
        protected void LnkLista_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListaCanchas.aspx");
        }
        protected void LnkHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}