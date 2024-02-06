using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionReservas.Controller;

namespace GestionReservas
{
    public partial class ListaProfesores1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {            
            var pro = from profesor in ProfesorController.FindAll()
                      select new
                      {
                          Codigo = profesor.codigo,
                          Nombre = profesor.nombre + " " + profesor.apellido,
                          Correo = profesor.correo
                      };

            GrdProfesores.DataSource = pro;
            GrdProfesores.DataBind();
        }
        protected void LnkHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}