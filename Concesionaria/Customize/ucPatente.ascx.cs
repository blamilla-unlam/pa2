using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Concesionaria.Customize
{
    [ValidationProperty("Text")]
    public partial class ucPatente : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string Valor
        {
            set
            {
                txtPatente.Text = value;
            }

            get
            {
                return txtPatente.Text;
            }
        }
    }
}