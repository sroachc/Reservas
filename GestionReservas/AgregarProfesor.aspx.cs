using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionReservas.Controller;


namespace GestionReservas
{
    public partial class AgregarProfesor1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {

            LbMensaje.Text = ProfesorController.AddProfesor(TxtCodigo.Text, TxtRut.Text, TxtNombre.Text, TxtApellido.Text, TxtTelefono.Text, TxtDireccion.Text, TxtCorreo.Text, TxtContraseña.Text);
        }
        protected void LnkLista_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListaProfesores.aspx");
        }
        protected void LnkHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}