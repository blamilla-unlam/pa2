using Servicio;
using System;

namespace Concesionaria
{
    public partial class CrearVehiculo : System.Web.UI.Page
    {
        VehiculoService ServiceVehiculo = new VehiculoService();
        ModeloService ServiceModelo = new ModeloService();
        MarcaService ServiceMarca = new MarcaService();
        CajaService ServiceCaja = new CajaService();
        ColorService ServiceColor = new ColorService();
        TapizadoService ServiceTapizado = new TapizadoService();

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

                var Modelos = ServiceModelo.ObtenerModelos();
                ddlModelo.DataSource = Modelos;
                ddlModelo.DataBind();
                ddlModelo.DataTextField = "Nombre";
                ddlModelo.DataValueField = "ModeloID";
                ddlModelo.DataBind();

                var Cajas = ServiceCaja.ObtenerCajas();
                ddlCaja.DataSource = Cajas;
                ddlCaja.DataBind();
                ddlCaja.DataTextField = "Nombre";
                ddlCaja.DataValueField = "CajaID";
                ddlCaja.DataBind();

                var Colores = ServiceColor.ObtenerColores();
                ddlColor.DataSource = Colores;
                ddlColor.DataBind();
                ddlColor.DataTextField = "Nombre";
                ddlColor.DataValueField = "ColorID";
                ddlColor.DataBind();

                var Tapizados = ServiceTapizado.ObtenerTapizados();
                ddlTapizado.DataSource = Tapizados;
                ddlTapizado.DataBind();
                ddlTapizado.DataTextField = "Nombre";
                ddlTapizado.DataValueField = "TapizadoID";
                ddlTapizado.DataBind();

                if (getVehiculoID())
                {
                    var Vehiculo = ServiceVehiculo.ObtenerPorID(VehiculoID);

                    ddlMarca.Items.FindByValue(Vehiculo.MarcaID.ToString()).Selected = true;
                    ddlModelo.Items.FindByValue(Vehiculo.ModeloID.ToString()).Selected = true;
                    ddlCaja.Items.FindByValue(Vehiculo.CajaID.ToString()).Selected = true;
                    ddlColor.Items.FindByValue(Vehiculo.ColorID.ToString()).Selected = true;
                    ddlTapizado.Items.FindByValue(Vehiculo.TapizadoID.ToString()).Selected = true;
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            getVehiculoID();

            Entidades.Vehiculo Vehiculo = new Entidades.Vehiculo();

            Vehiculo.MarcaID = int.Parse(ddlMarca.SelectedValue);
            Vehiculo.ModeloID = int.Parse(ddlModelo.SelectedValue);
            Vehiculo.NumeroChasis = int.Parse(txtChasis.Text);
            Vehiculo.NumeroCarroceria = int.Parse(txtCarroceria.Text);
            Vehiculo.Patente = txtPatente.Text;
            Vehiculo.NumeroPuertas = short.Parse(txtPuertas.Text);
            Vehiculo.ColorID = int.Parse(ddlColor.SelectedValue);
            Vehiculo.CajaID = int.Parse(ddlCaja.SelectedValue);
            Vehiculo.Cilindrada = decimal.Parse(txtCilindrada.Text);
            Vehiculo.TapizadoID = int.Parse(ddlTapizado.SelectedValue);

            ServiceVehiculo.Insertar(Vehiculo);

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