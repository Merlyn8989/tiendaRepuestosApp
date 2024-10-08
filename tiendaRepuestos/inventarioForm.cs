﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesTienda.Modelo;

namespace tiendaRepuestos
{
    public partial class inventarioForm : Form
    {
        private Producto producto1;
        private Producto producto2;
        private Producto producto3;

        public inventarioForm()
        {
            InitializeComponent();

            try
            {
                producto1 = new Producto("Bujillas", 50, 19.99);
                producto2 = new Producto("Frenos", 30, 29.99);
                producto3 = new Producto("Aceite", 20, 9.99);

                // Mostrar detalles de los productos
                producto1Label.Text = producto1.MostrarDetalles();
                producto2Label.Text = producto2.MostrarDetalles();
                producto3Label.Text = producto3.MostrarDetalles();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Error en la creación de producto: {ex.Message}", "Error de Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado en el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comprarButton_Click(object sender, EventArgs e)
        {

            try
            {
                var formularioCompra = new comprarForm(producto1, producto2, producto3);
                formularioCompra.Show();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Error al abrir el formulario de compra: {ex.Message}", "Error de Compra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al abrir el formulario de compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
