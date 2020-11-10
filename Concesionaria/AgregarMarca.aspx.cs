using Servicio;
using System;

namespace Concesionaria
{
    public partial class CrearMarca : System.Web.UI.Page
    {
        MarcaService ServicioMarca = new MarcaService();

        int MarcaID = 0;

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
            Entidades.Marca Marca = new Entidades.Marca();
                        
            Marca.Nombre = txtDescripcion.Text;
            
            ServicioMarca.Insertar(Marca);

            Response.Redirect("Marcas.aspx");
        }

        private bool obtenerMarcaID()
        {
            return int.TryParse(Request.QueryString["marcaid"], out MarcaID);
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Marcas.aspx");
        }
    }
}