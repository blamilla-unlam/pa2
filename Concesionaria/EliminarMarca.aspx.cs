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
            ServicioMarca.Eliminar(MarcaID);

            Response.Redirect("Marcas.aspx");
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