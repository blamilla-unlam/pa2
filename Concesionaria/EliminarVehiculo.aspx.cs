using Servicio;
using System;

namespace Concesionaria
{
    public partial class EliminarVehiculo : System.Web.UI.Page
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
                    lblMensaje.Text = "¿Confirma eliminación del vehículo con número de chasis " + Vehiculo.NumeroChasis + 
                        " y número de carrocería " + Vehiculo.NumeroCarroceria + " ?";
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            getVehiculoID();
            ServiceVehiculo.Eliminar(VehiculoID);

            Response.Redirect("Vehiculos.aspx");
        }

        private bool getVehiculoID()
        {
            return int.TryParse(Request.QueryString["vehiculoid"], out VehiculoID);
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Vehiculos.aspx");
        }
    }
}