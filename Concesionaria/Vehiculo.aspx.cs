using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Concesionaria
{
    public partial class Vehiculos : Page
    {
        Servicio.VehiculoService ServiceVehiculo = new Servicio.VehiculoService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var Vehiculos = ServiceVehiculo.ObtenerVehiculos();
                GridVehiculos.DataSource = Vehiculos;
                GridVehiculos.DataBind();
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("VehiculoUpsert.aspx");
        }
    }
}