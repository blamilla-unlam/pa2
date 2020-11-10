using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Concesionaria
{
    public partial class Marca : Page
    {
        Servicio.MarcaService ServicioMarca = new Servicio.MarcaService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var Marcas = ServicioMarca.ObtenerMarcas();
                GridMarcas.DataSource = Marcas;
                GridMarcas.DataBind();
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarMarca.aspx");
        }
    }
}