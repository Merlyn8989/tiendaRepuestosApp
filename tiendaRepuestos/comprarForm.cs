using ClasesTienda.EventosPersonalizados;
using ClasesTienda.Modelo;

namespace tiendaRepuestos
{
    public partial class comprarForm : Form
    {
        private Producto producto1;
        private Producto producto2;
        private Producto producto3;
        private NotificadorProductoAgotado notificador;

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
            try
            {
                string seleccion = eleccionProductoComboBox.Text;
                int cantidad = int.Parse(cantidadCompraTextBox.Text);

                if (string.IsNullOrWhiteSpace(seleccion))
                {
                    MessageBox.Show("Por favor, seleccione un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (seleccion == producto1.Nombre)
                {
                    MessageBox.Show(producto1.Recibo(cantidad));
                    
                }
                else if (seleccion == producto2.Nombre)
                {
                    MessageBox.Show(producto2.Recibo(cantidad));
                }
                else if(seleccion == producto3.Nombre)
                {
                    MessageBox.Show(producto3.Recibo(cantidad));
                }
                else
                {
                    MessageBox.Show("Producto no disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
