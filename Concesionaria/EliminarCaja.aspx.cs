using Servicio;
using System;

namespace Concesionaria
{
    public partial class EliminarCaja : System.Web.UI.Page
    {
        CajaService ServicioCaja = new CajaService();

        int CajaID = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (obtenerCajaID())
                {
                    var Caja = ServicioCaja.ObtenerPorID(CajaID);
                    lblMensaje.Text = "¿Está seguro que desea eliminar la caja " + Caja.Nombre + " ?";
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            obtenerCajaID();
            ServicioCaja.Eliminar(CajaID);

            Response.Redirect("Cajas.aspx");
        }

        private bool obtenerCajaID()
        {
            return int.TryParse(Request.QueryString["cajaid"], out CajaID);
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cajas.aspx");
        }
    }
}