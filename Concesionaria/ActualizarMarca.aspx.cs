using Servicio;
using System;

namespace Concesionaria
{
    public partial class ActualizarMarca : System.Web.UI.Page
    {
        MarcaService ServicioMarca = new MarcaService();

        int MarcaID = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //var Marcas = ServicioMarca.ObtenerMarcas();
                //ddlMarca.DataSource = Marcas;
                //ddlMarca.DataBind();
                //ddlMarca.DataTextField = "Nombre";
                //ddlMarca.DataValueField = "MarcaID";
                //ddlMarca.DataBind();

                if (obtenerMarcaID())
                {
                    var Marca = ServicioMarca.ObtenerPorID(MarcaID);
                    txtDescripcion.Text = Marca.Nombre;
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            obtenerMarcaID();

            Entidades.Marca Marca = new Entidades.Marca();

            if (MarcaID == 0)
            {
                Marca.Nombre = txtDescripcion.Text;

                ServicioMarca.Insertar(Marca);
            }
            else
            {
                Marca.MarcaID = MarcaID;
                Marca.Nombre = txtDescripcion.Text;

                ServicioMarca.Actualizar(Marca);
            }

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