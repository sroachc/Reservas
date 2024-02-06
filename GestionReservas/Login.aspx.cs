using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionReservas.Controller;

namespace GestionReservas

{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            usuario u = LoginController.Login(TxtUser.Text, TxtPass.Text);
            if (u != null)
            {
                Session["ActiveUser"] = u;
                LbMensaje.Text = "Bienvenido " + u.username;
            }
            else
            {
                LbMensaje.Text = "Credenciales incorrectas";
                Session["ActiveUser"] = null;
            }
        }

        protected void LnkAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}