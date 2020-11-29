using Servicio;
using System;

namespace Concesionaria
{
    public partial class EliminarColor : System.Web.UI.Page
    {
        ColorService ServicioColor = new ColorService();

        int ColorID = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            errorContenedor.Visible = false;

            if (!IsPostBack)
            {
                if (obtenerColorID())
                {
                    var Color = ServicioColor.ObtenerPorID(ColorID);
                    lblMensaje.Text = "¿Está seguro que desea eliminar el color " + Color.Nombre + " ?";
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            obtenerColorID();

            try
            {
                ServicioColor.Eliminar(ColorID);
                Response.Redirect("Colores.aspx");
            }
            catch (Exception)
            {
                errorContenedor.Visible = true;
                lblMensajeError.Text = "El color seleccionado no puede ser eliminado debido a que se encuentra relacionado a un elemento existente.";
            }           
        }

        private bool obtenerColorID()
        {
            return int.TryParse(Request.QueryString["colorid"], out ColorID);
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Colores.aspx");
        }
    }
}