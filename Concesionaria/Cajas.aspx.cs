using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Concesionaria
{
    public partial class Caja : Page
    {
        Servicio.CajaService ServicioCaja = new Servicio.CajaService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var Marcas = ServicioCaja.ObtenerCajas();
                GridCajas.DataSource = Marcas;
                GridCajas.DataBind();
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarCaja.aspx");
        }
    }
}