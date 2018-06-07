using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaClases
{
    public class Pedido
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public int IdCliente { get; set; }
        public string Nombrecliente { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioProducto { get; set; }
        public bool Iva { get; set; }
        public decimal ImporteFactura { get; set; }

        public static Pedido CrearFactura(int idCliente, int idProducto, int cantidad, decimal precio
            , bool iva)
        {
            Pedido pedido = new Pedido();
            pedido.IdCliente = idCliente;
            pedido.Nombrecliente = Cliente.ObtenerNombreCliente(idCliente);
            pedido.IdProducto = idProducto;
            pedido.NombreProducto = Producto.ObtenerNombreProducto(idProducto);
            pedido.Cantidad = cantidad;
            pedido.PrecioProducto = precio;
            pedido.Iva = iva;

            pedido.ImporteFactura =
                iva ? (cantidad * precio * 1.15m) : (cantidad * precio);

            return pedido;
        }



    }
}
