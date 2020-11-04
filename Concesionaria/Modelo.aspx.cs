using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Concesionaria
{
    public partial class About : Page
    {
        Servicio.ModeloService ServiceModelo = new Servicio.ModeloService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var Modelos = ServiceModelo.ObtenerModelos();
                GridModelos.DataSource = Modelos;
                GridModelos.DataBind();
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModeloUpsert.aspx");
        }
    }
}