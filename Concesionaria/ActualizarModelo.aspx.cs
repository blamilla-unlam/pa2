using Servicio;
using System;

namespace Concesionaria
{
    public partial class ActualizarModelo : System.Web.UI.Page
    {
        ModeloService ServicioModelo = new ModeloService();
        MarcaService ServicioMarca = new MarcaService();

        int ModeloID = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var Marcas = ServicioMarca.ObtenerMarcas();
                ddlMarca.DataSource = Marcas;
                ddlMarca.DataBind();
                ddlMarca.DataTextField = "Nombre";
                ddlMarca.DataValueField = "MarcaID";
                ddlMarca.DataBind();

                if (obtenerModeloID())
                {
                    var Modelo = ServicioModelo.ObtenerPorID(ModeloID);
                    txtNombre.Text = Modelo.Nombre;
                    ddlMarca.Items.FindByValue(Modelo.MarcaID.ToString()).Selected = true;
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            obtenerModeloID();

            Entidades.Modelo Modelo = new Entidades.Modelo();

            if (ModeloID == 0)
            {
                Modelo.MarcaID = int.Parse(ddlMarca.SelectedValue);
                Modelo.Nombre = txtNombre.Text;

                ServicioModelo.Insertar(Modelo);
            }
            else
            {
                Modelo.ModeloID = ModeloID;
                Modelo.MarcaID = int.Parse(ddlMarca.SelectedValue);
                Modelo.Nombre = txtNombre.Text;

                ServicioModelo.Actualizar(Modelo);
            }

            Response.Redirect("Modelos.aspx");
        }

        private bool obtenerModeloID()
        {
            return int.TryParse(Request.QueryString["modeloid"], out ModeloID);
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Modelos.aspx");
        }
    }
}