using Servicio;
using System;

namespace Concesionaria
{
    public partial class EliminarModelo : System.Web.UI.Page
    {
        ModeloService ServicioModelo = new ModeloService();

        int ModeloID = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (obtenerModeloID())
                {
                    var Modelo = ServicioModelo.ObtenerPorID(ModeloID);
                    lblMensaje.Text = "¿Está seguro que desea eliminar el modelo " + Modelo.Nombre + " ?";
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            obtenerModeloID();
            ServicioModelo.Eliminar(ModeloID);

            Response.Redirect("Modelos.aspx");
        }

        private bool obtenerModeloID()
        {
            return int.TryParse(Request.QueryString["modeloid"], out ModeloID);
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Modelos.aspx");
        }
    }
}