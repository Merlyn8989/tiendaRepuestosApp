using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesTienda.Modelo;
using ClasesTienda.EventosPersonalizados;

namespace tiendaRepuestos
{
    public partial class comprarForm : Form
    {
        private Producto producto1;
        private Producto producto2;
        private Producto producto3;

        public comprarForm(Producto producto1, Producto producto2, Producto producto3)
        {
            InitializeComponent();
            notificador = new NotificadorProductoAgotado();
            notificador.ProductoAgotado += Notificador_ProductoAgotado;

            this.producto1 = producto1;
            this.producto2 = producto2;
            this.producto3 = producto3;

            eleccionProductoComboBox.Text = "Elige una opción";

            eleccionProductoComboBox.Items.Add(producto1.Nombre);
            eleccionProductoComboBox.Items.Add(producto2.Nombre);
            eleccionProductoComboBox.Items.Add(producto3.Nombre);

        }
        private void Notificador_ProductoAgotado(object sender, Producto producto)
        {
            MessageBox.Show($"El producto {producto.Nombre} está agotado.");
        }

        private void pagarButton_Click(object sender, EventArgs e)
        {
       
    }
}
}
