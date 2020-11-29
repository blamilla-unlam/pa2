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
            errorContenedor.Visible = false;

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

            try
            {
                ServicioCaja.Eliminar(CajaID);
                Response.Redirect("Cajas.aspx");
            }
            catch (Exception)
            {
                errorContenedor.Visible = true;
                lblMensajeError.Text = "La caja seleccionada no puede ser eliminada debido a que se encuentra relacionada a un elemento existente.";
            }
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