using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionReservas.Controller;

namespace GestionReservas
{
    public partial class ListaReservas1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var res = from reserva in ReservaController.FindAll()
                      select new
                      {
                          Codigo = reserva.codigo,
                          Cancha = reserva.cancha,
                          Cliente = reserva.cliente,
                          Fecha = reserva.fecha.ToString(),
                          Hora_Inicio = reserva.hora_ini,
                          Hora_Fin = reserva.hora_fin
                      };

            GrdReservas.DataSource = res;
            GrdReservas.DataBind();
        }
        protected void LnkHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}