using Servicio;
using System;

namespace Concesionaria
{
    public partial class EliminarTapizado : System.Web.UI.Page
    {
        TapizadoService ServicioTapizado = new TapizadoService();

        int TapizadoID = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (obtenerTapizadoID())
                {
                    var Tapizado = ServicioTapizado.ObtenerPorID(TapizadoID);
                    lblMensaje.Text = "¿Está seguro que desea eliminar el tapizado " + Tapizado.Nombre + " ?";
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            obtenerTapizadoID();
            ServicioTapizado.Eliminar(TapizadoID);

            Response.Redirect("Tapizados.aspx");
        }

        private bool obtenerTapizadoID()
        {
            return int.TryParse(Request.QueryString["tapizadoid"], out TapizadoID);
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Tapizados.aspx");
        }
    }
}