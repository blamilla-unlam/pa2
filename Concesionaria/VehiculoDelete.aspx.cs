using Servicio;
using System;

namespace Concesionaria
{
    public partial class VehiculoDelete : System.Web.UI.Page
    {
        VehiculoService ServiceVehiculo = new VehiculoService();

        int VehiculoID = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (getVehiculoID())
                {
                    var Vehiculo = ServiceVehiculo.ObtenerPorID(VehiculoID);
                    lblMensaje.Text = "¿Confirma eliminación del vehículo con número de chasis " + Vehiculo.NumeroChasis + " ?";
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            getVehiculoID();
            ServiceVehiculo.Eliminar(VehiculoID);

            Response.Redirect("Vehiculo.aspx");
        }

        private bool getVehiculoID()
        {
            return int.TryParse(Request.QueryString["vehiculoid"], out VehiculoID);
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Vehiculo.aspx");
        }
    }
}