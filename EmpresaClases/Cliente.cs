using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaClases
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public  string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreCompleto { get; set; }

        public override string ToString()
        {
            return String.Format("{0}{1}", Nombre,Apellido);
        }

        private static List<Cliente> CrearListaClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            Cliente c1 = new Cliente();
            c1.IdCliente = 1;
            c1.Nombre = "Juan";
            c1.Apellido = "Rodriguez";
            c1.NombreCompleto = c1.ToString();
            clientes.Add(c1);

            Cliente c2 = new Cliente();
            c2.IdCliente = 2;
            c2.Nombre = "José";
            c2.Apellido = "Escríbano";
            c2.NombreCompleto = c2.ToString();
            clientes.Add(c2);

            Cliente c3 = new Cliente();
            c3.IdCliente = 3;
            c3.Nombre = "María";
            c3.Apellido = "Guzmán";
            c3.NombreCompleto = c3.ToString();
            clientes.Add(c3);

            return clientes;
        }

        public static List<Cliente> ObtenerListaClientes()
        {
            List<Cliente> cliente = CrearListaClientes();
            var cli = cliente
                .OrderBy(c => c.Apellido)
                .Select(c => c).ToList();

            Cliente vacio = new Cliente();
            vacio.IdCliente = 0;
            vacio.NombreCompleto = "-Elegir Cliente-";
            cli.Insert(0, vacio);

            return cli;
        }

        public static string ObtenerNombreCliente (int idCliente)
        {
            List<Cliente> clientes = CrearListaClientes();
            var cliente = clientes
            .Where(c => c.IdCliente.Equals(idCliente))
            .Select(c => c.NombreCompleto).SingleOrDefault().ToString();

            return cliente;
        }
       
    }
}
