using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTienda
{
    public class Producto
    {
        public string Tipo { get; set; }

        public int Cantidad { get; set; }

        public double Precio { get; set; }

        public Producto(
            string tipo, 
            int cantidad,
            double precio)
        {
            Tipo = tipo;
            Cantidad = cantidad;
            Precio = precio;
        }

        public double PrecioTotal(int cantidadComprada)
        {
            double cantidadFinal = cantidadComprada * this.Precio; 

            return cantidadFinal;
        }

        public double DescuentoAplicado(int cantidadComprada)
        {
            if (cantidadComprada > 10)
            {
                //si es más de 10 producto aplicar descuento del 10 porciento
                double precio = this.PrecioTotal(cantidadComprada);

                double descuento = precio * 0.10;

                return precio - descuento;

            }
            else if(cantidadComprada > 20)
            {
                double precio = this.PrecioTotal(cantidadComprada);

                double descuento = precio * 0.15;

                return precio - descuento;
            }
            else
            {
                return this.PrecioTotal(cantidadComprada);
            }
        }
    }
}
