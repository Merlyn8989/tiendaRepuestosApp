using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTienda.Modelo
{
    public class Producto
    {
        public string Nombre { get; set; }
        public int CantidadEnInventario { get; set; }

        public double Precio { get; set; }

        public Producto(string nombre, int cantidadEnInventario, double precio)
        {
            Nombre = nombre;
            CantidadEnInventario = cantidadEnInventario;
            Precio = precio;
        }

        public string MostrarDetalles()
        {
            return $"     {this.Nombre}                       |      {this.CantidadEnInventario}                 |        {this.Precio:C}";
        }
    }
}
