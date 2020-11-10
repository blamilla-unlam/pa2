using Servicio;
using System;

namespace Concesionaria
{
    public partial class ActualizarColor : System.Web.UI.Page
    {
        ColorService ServicioColor = new ColorService();

        int ColorID = 0;

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

                if (obtenerColorID())
                {
                    var Color = ServicioColor.ObtenerPorID(ColorID);
                    txtDescripcion.Text = Color.Nombre;
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            obtenerColorID();

            Entidades.Color Color = new Entidades.Color();

            if (ColorID == 0)
            {
                Color.Nombre = txtDescripcion.Text;

                ServicioColor.Insertar(Color);
            }
            else
            {
                Color.ColorID = ColorID;
                Color.Nombre = txtDescripcion.Text;

                ServicioColor.Actualizar(Color);
            }

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