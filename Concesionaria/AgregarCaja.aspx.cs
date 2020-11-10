using Servicio;
using System;

namespace Concesionaria
{
    public partial class CrearCaja : System.Web.UI.Page
    {
        CajaService ServicioCaja = new CajaService();

        int CajaID = 0;

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
            Entidades.Caja Caja = new Entidades.Caja();

            Caja.Nombre = txtDescripcion.Text;

            ServicioCaja.Insertar(Caja);

            Response.Redirect("Cajas.aspx");
        }

        private bool obtenerCajaID()
        {
            return int.TryParse(Request.QueryString["cajaid"], out CajaID);
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cajas.aspx");
        }
    }
}