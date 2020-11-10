using Servicio;
using System;

namespace Concesionaria
{
    public partial class ActualizarCaja : System.Web.UI.Page
    {
        CajaService ServicioCaja = new CajaService();

        int CajaID = 0;

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

                if (obtenerCajaID())
                {
                    var Caja = ServicioCaja.ObtenerPorID(CajaID);
                    txtDescripcion.Text = Caja.Nombre;
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            obtenerCajaID();

            Entidades.Caja Caja = new Entidades.Caja();

            if (CajaID == 0)
            {
                Caja.Nombre = txtDescripcion.Text;

                ServicioCaja.Insertar(Caja);
            }
            else
            {
                Caja.CajaID = CajaID;
                Caja.Nombre = txtDescripcion.Text;

                ServicioCaja.Actualizar(Caja);
            }

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