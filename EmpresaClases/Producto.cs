using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaClases
{
    public class Producto
    {
        public int IdPRoducto { get; set; }
        public string NombreProducto { get; set; }
        public decimal PrecioProducto { get; set; }
        
        private static List<Producto> CrearListaProductos()
        {
            List<Producto> productos = new List<Producto>();

            Producto c1 = new Producto();
            c1.IdPRoducto = 1;
            c1.NombreProducto = "Frigorífico";
            c1.PrecioProducto = 1200.2m;
            productos.Add(c1);

            Producto c2 = new Producto();
            c2.IdPRoducto = 2;
            c2.NombreProducto = "Lavadora";
            c2.PrecioProducto = 2500.4m;
            productos.Add(c2);

            Producto c3 = new Producto();
            c3.IdPRoducto = 3;
            c3.NombreProducto = "Microondas";
            c3.PrecioProducto = 4654.6m;
            productos.Add(c3);

            return productos;

        }

        public static List<Producto> ObtenerProductos()
        {
            List<Producto> productos = CrearListaProductos();
            var pro = productos
                .OrderBy(c => c.NombreProducto)
                .Select(c => c).ToList();

            Producto vacio = new Producto();
            vacio.IdPRoducto = 0;
            vacio.NombreProducto = "--Elige Producto-";
            pro.Insert(0, vacio);

            return pro;
        }

        public static decimal ObtenerPrecioProducto(int idProducto)
        {
            List<Producto> productos = CrearListaProductos();
            var precio = productos
                .Where(p => p.IdPRoducto.Equals(idProducto))
                .Select(p => p.PrecioProducto)
                .SingleOrDefault();

            return decimal.Parse(precio.ToString());
        }

        public static string ObtenerNombreProducto (int idProducto)
        {
            List<Producto> productos = CrearListaProductos();
            var producto = productos
                .Where(p => p.IdPRoducto.Equals(idProducto))
                .Select(p => p.NombreProducto)
                .SingleOrDefault()
                .ToString();

            return producto;
        }
    }
}
