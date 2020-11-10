using Servicio;
using System;

namespace Concesionaria
{
    public partial class ActualizarTapizado : System.Web.UI.Page
    {
        TapizadoService ServicioTapizado = new TapizadoService();

        int TapizadoID = 0;

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

                if (obtenerTapizadoID())
                {
                    var Tapizado = ServicioTapizado.ObtenerPorID(TapizadoID);
                    txtDescripcion.Text = Tapizado.Nombre;
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            obtenerTapizadoID();

            Entidades.Tapizado Tapizado = new Entidades.Tapizado();

            if (TapizadoID == 0)
            {
                Tapizado.Nombre = txtDescripcion.Text;

                ServicioTapizado.Insertar(Tapizado);
            }
            else
            {
                Tapizado.TapizadoID = TapizadoID;
                Tapizado.Nombre = txtDescripcion.Text;

                ServicioTapizado.Actualizar(Tapizado);
            }

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