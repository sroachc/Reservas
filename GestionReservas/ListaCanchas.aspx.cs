using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionReservas.Controller;

namespace GestionReservas
{
    public partial class ListaCanchas1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            var can = from cancha in CanchaController.FindAll()
                      select new
                      {
                          Codigo = cancha.codigo,
                          Nombre = cancha.nombre
                      };

            GrdCanchas.DataSource = can;
            GrdCanchas.DataBind();
        }
        protected void LnkHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}