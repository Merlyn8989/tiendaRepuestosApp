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

        public double PrecioTotal(int cantidadComprada)
        {
            if(this.CantidadEnInventario > 0 && this.CantidadEnInventario >= cantidadComprada)
            {
                double cantidadTotal = cantidadComprada * this.Precio;
                this.CantidadEnInventario -= cantidadComprada;

                return cantidadTotal;
            }
            else
            {
                return 0;
            }
            
        }

        public string Recibo(int cantidadComprada)
        {
            if (this.CantidadEnInventario > 0 && this.CantidadEnInventario >= cantidadComprada) {

                double total = PrecioTotal(cantidadComprada);

                return $"Su total a pagar es de: {total} {this.CantidadEnInventario}";
            }
            else{
                return $"No hay cantidad suficiente para realizar la compra {this.CantidadEnInventario}";
            }
                
        }
    }
}
