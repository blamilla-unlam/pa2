using Servicio;
using System;

namespace Concesionaria
{
    public partial class CrearColor : System.Web.UI.Page
    {
        ColorService ServicioColor = new ColorService();

        int ColorID = 0;

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
            Entidades.Color Color = new Entidades.Color();

            Color.Nombre = txtDescripcion.Text;

            ServicioColor.Insertar(Color);

            Response.Redirect("Colores.aspx");
        }

        private bool obtenerColorID()
        {
            return int.TryParse(Request.QueryString["colorid"], out ColorID);
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Colores.aspx");
        }
    }
}