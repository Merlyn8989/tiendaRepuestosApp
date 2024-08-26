using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesTienda.Modelo;

namespace ClasesTienda.EventosPersonalizados
{
    public class NotificadorProductoAgotado
    {
        public event EventHandler<Producto> ProductoAgotado;
        protected virtual void OnProductoAgotado(Producto producto)
        {
            ProductoAgotado?.Invoke(this, producto);
        }

        public void VerificarInventario(Producto producto)
        {
            if (producto.CantidadEnInventario <= 0)
            {
                OnProductoAgotado(producto);
            }
        }
    }
}
