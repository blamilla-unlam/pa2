using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Concesionaria
{
    public partial class Tapizado : Page
    {
        Servicio.TapizadoService ServicioTapizado = new Servicio.TapizadoService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var Tapizados = ServicioTapizado.ObtenerTapizados();
                GridTapizados.DataSource = Tapizados;
                GridTapizados.DataBind();
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarTapizado.aspx");
        }
    }
}