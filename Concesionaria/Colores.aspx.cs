using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Concesionaria
{
    public partial class Color : Page
    {
        Servicio.ColorService ServicioColor = new Servicio.ColorService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var Colores = ServicioColor.ObtenerColores();
                GridColores.DataSource = Colores;
                GridColores.DataBind();
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarColor.aspx");
        }
    }
}