using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionReservas.Controller;
using System.Drawing;

namespace GestionReservas
{
    public partial class BuscarReserva1 : System.Web.UI.Page
    {
        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            reserva res = ReservaController.FindReserva(int.Parse(TxtBuscar.Text));

            if (res != null)
            {
                LbMensaje1.ForeColor = Color.Green;
                LbMensaje1.Text = "Reserva Encontrada";
                PanelReserva.Visible = true;

                LbCodigo.Text = res.codigo.ToString();
                LbCancha.Text = res.cancha.ToString();
                LbCliente.Text = res.cliente.ToString();
                LbProfesor.Text = res.profesor.ToString();
                LbFecha.Text = res.fecha.ToString();
                LbHora_ini.Text = res.hora_ini.ToString();
                LbHora_fin.Text = res.hora_fin.ToString();

                Session["res"] = res;

            }
            else
            {
                PanelReserva.Visible = false;
                LbMensaje1.ForeColor = Color.Red;
                LbMensaje1.Text = "Reserva no Encontrada";
                Session["res"] = null;
            }
        }

        protected void LnkEditar_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditarReserva.aspx");
        }
    }
}