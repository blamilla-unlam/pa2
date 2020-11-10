using Servicio;
using System;

namespace Concesionaria
{
    public partial class CrearTapizado : System.Web.UI.Page
    {
        TapizadoService ServicioTapizado = new TapizadoService();

        int TapizadoID = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    var Marcas = ServicioMarca.ObtenerMarcas();
            //    ddlMarca.DataSource = Marcas;
            //    ddlMarca.DataBind();
            //    ddlMarca.DataTextField = "Nombre";
            //    ddlMarca.DataValueField = "MarcaID";
            //    ddlMarca.DataBind();

            //    if (obtenerModeloID())
            //    {
            //        var Modelo = ServicioModelo.ObtenerPorID(ModeloID);
            //        txtNombre.Text = Modelo.Nombre;
            //        ddlMarca.Items.FindByValue(Modelo.MarcaID.ToString()).Selected = true;
            //    }
            //}
        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            Entidades.Tapizado Tapizado = new Entidades.Tapizado();

            Tapizado.Nombre = txtDescripcion.Text;

            ServicioTapizado.Insertar(Tapizado);

            Response.Redirect("Tapizados.aspx");
        }

        private bool obtenerTapizadoID()
        {
            return int.TryParse(Request.QueryString["tapizadoid"], out TapizadoID);
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Tapizados.aspx");
        }
    }
}