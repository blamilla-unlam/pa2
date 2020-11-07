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
        int ModeloID = 0;

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
                    var Modelo = ServiceModelo.ObtenerPorID(ModeloID);
                    //txtNombre.Text = Modelo.Nombre;
                    ddlMarca.Items.FindByValue(Modelo.MarcaID.ToString()).Selected = true;
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            getVehiculoID();

            Entidades.Modelo Modelo = new Entidades.Modelo();

            if (ModeloID == 0)
            {
                Modelo.MarcaID = int.Parse(ddlMarca.SelectedValue);
                //Modelo.Nombre = txtNombre.Text;

                ServiceModelo.Insertar(Modelo);
            }
            else
            {
                Modelo.ModeloID = ModeloID;
                Modelo.MarcaID = int.Parse(ddlMarca.SelectedValue);
                //Modelo.Nombre = txtNombre.Text;

                ServiceModelo.Actualizar(Modelo);
            }

            Response.Redirect("Modelo.aspx");
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