using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmpresaUI
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtCliente.Text = Request.QueryString["cliente"];
            txtProducto.Text = Request.QueryString["producto"];
            txtCantidad.Text = Request.QueryString["cantidad"];
            txtPrecio.Text = Convert.ToString( decimal.Parse( Request.QueryString["precio"]));
            txtTotal.Text= Convert.ToString(decimal.Parse(Request.QueryString["total"]));

            txtFecha.Text = DateTime.Now.ToShortDateString();
        }
    }
}