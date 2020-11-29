using Servicio;
using System;

namespace Concesionaria
{
    public partial class EliminarMarca : System.Web.UI.Page
    {
        MarcaService ServicioMarca = new MarcaService();

        int MarcaID = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            errorContenedor.Visible = false;

            if (!IsPostBack)
            {
                if (obtenerMarcaID())
                {
                    var Marca = ServicioMarca.ObtenerPorID(MarcaID);
                    lblMensaje.Text = "¿Está seguro que desea eliminar la marca " + Marca.Nombre + " ?";
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            obtenerMarcaID();

            try
            {
                ServicioMarca.Eliminar(MarcaID);
                Response.Redirect("Marcas.aspx");
            }
            catch (Exception)
            {
                errorContenedor.Visible = true;
                lblMensajeError.Text = "La marca seleccionada no puede ser eliminada debido a que se encuentra relacionada a un elemento existente.";
            }            
        }

        private bool obtenerMarcaID()
        {
            return int.TryParse(Request.QueryString["marcaid"], out MarcaID);
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Marcas.aspx");
        }
    }
}