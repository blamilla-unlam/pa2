using Servicio;
using System;

namespace Concesionaria
{
    public partial class VehiculoUpdate : System.Web.UI.Page
    {
        VehiculoService ServiceVehiculo = new VehiculoService();
        ModeloService ServiceModelo = new ModeloService();
        MarcaService ServiceMarca = new MarcaService();

        int VehiculoID = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var Marcas = ServiceMarca.ObtenerMarcas();
                ddlMarca.DataSource = Marcas;
                ddlMarca.DataBind();
                ddlMarca.DataTextField = "Nombre";
                ddlMarca.DataValueField = "MarcaID";
                ddlMarca.DataBind();

                if (getVehiculoID())
                {
                    var Vehiculo = ServiceVehiculo.ObtenerPorID(VehiculoID);
                    //txtNombre.Text = Modelo.Nombre;
                    ddlMarca.Items.FindByValue(Vehiculo.MarcaID.ToString()).Selected = true;
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            getVehiculoID();

            Entidades.Vehiculo Vehiculo = new Entidades.Vehiculo();

            if (VehiculoID == 0)
            {
                Vehiculo.MarcaID = int.Parse(ddlMarca.SelectedValue);
                //Modelo.Nombre = txtNombre.Text;

                ServiceVehiculo.Insertar(Vehiculo);
            }
            else
            {
                Vehiculo.VehiculoID = VehiculoID;
                Vehiculo.MarcaID = int.Parse(ddlMarca.SelectedValue);
                //Modelo.Nombre = txtNombre.Text;

                ServiceVehiculo.Actualizar(Vehiculo);
            }

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