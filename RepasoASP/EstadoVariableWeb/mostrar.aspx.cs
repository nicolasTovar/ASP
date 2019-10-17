using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EstadoVariableWeb
{
    public partial class mostrar : System.Web.UI.Page
    {
        private int resultado;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtMostrar.Text = "0";
            }
           
        }

        protected void btnIncrementar_Click(object sender, EventArgs e)
        {
            if (ViewState["Conteo"]!=null)
            {
                resultado = (int)ViewState["Conteo"] + 1;

            }
            txtMostrar.Text = resultado.ToString();
            ViewState["Conteo"] = resultado;
        }
    }
}