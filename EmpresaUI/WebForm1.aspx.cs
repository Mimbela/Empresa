using EmpresaClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmpresaUI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarComboClientes();
                CargarComboProductos();
            }
           
        }

        private void CargarComboProductos()
        {
            cmbProductos.DataValueField = "IdProducto";
            cmbProductos.DataTextField = "NombreProducto";
            cmbProductos.DataSource = Producto.ObtenerProductos();
            cmbProductos.DataBind();
        }

        private void CargarComboClientes()
        {
            cmbClientes.DataValueField = "IdCliente"; // por detrás
            cmbClientes.DataTextField = "NombreCompleto"; //por delante
            cmbClientes.DataSource = Cliente.ObtenerListaClientes();
            cmbClientes.DataBind();
        }

        protected void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal precio =Producto.ObtenerPrecioProducto(Convert.ToInt32(cmbProductos.SelectedValue));
            txtPrecio.Text = precio.ToString();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            bool iva = false;
            iva = rdbiva.SelectedItem.Value == "si";

            Pedido factura = new Pedido();
            factura = Pedido.CrearFactura(Convert.ToInt32(cmbClientes.SelectedValue),
                Convert.ToInt32(cmbProductos.SelectedValue),
                Convert.ToInt32(txtCantidad.Text),
                Convert.ToDecimal(txtPrecio.Text),
                iva);

            Response.Redirect("WebForm2.aspx?cliente=" + factura.Nombrecliente
                + "&producto=" + factura.NombreProducto
                + "&cantidad=" + factura.Cantidad
                + "&precio=" + factura.PrecioProducto
                + "&total=" + factura.ImporteFactura);


            //selecteditem en radiobuttom


        }
    }
}

//selected value
//Obtiene el valor del elemento seleccionado en el control de lista o
//    selecciona el elemento en el control de lista que contiene el valor especificado.