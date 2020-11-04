using Servicio;
using System;

namespace Concesionaria
{
    public partial class ModeloDelete : System.Web.UI.Page
    {
        ModeloService ServiceModelo = new ModeloService();

        int ModeloID = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (getModeloID())
                {
                    var Modelo = ServiceModelo.ObtenerPorID(ModeloID);
                    lblMensaje.Text = "¿Confirma eliminación del modelo " + Modelo.Nombre + " ?";
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            getModeloID();
            ServiceModelo.Eliminar(ModeloID);

            Response.Redirect("Modelo.aspx");
        }

        private bool getModeloID()
        {
            return int.TryParse(Request.QueryString["modeloid"], out ModeloID);
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Modelo.aspx");
        }
    }
}