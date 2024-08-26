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

namespace tiendaRepuestos
{
    public partial class registroForm : Form
    {
        public registroForm()
        {
            InitializeComponent();

        }

        private void registrarseButton_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = nombreTextBox.Text;
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    throw new ArgumentException("El nombre no puede estar vacío.");
                }

                string apellido = apellidoTextBox.Text;
                if (string.IsNullOrWhiteSpace(apellido))
                {
                    throw new ArgumentException("El apellido no puede estar vacío.");
                }

                DateTime fechaSeleccionada = nacimientoDateTimePicker.Value;
                if (fechaSeleccionada > DateTime.Now)
                {
                    throw new ArgumentException("La fecha de nacimiento no puede ser una fecha futura.");
                }

                int fechaNacimiento = int.Parse(fechaSeleccionada.ToString("yyyyMMdd"));

                Cliente cliente = new Cliente(nombre, apellido, fechaNacimiento);

                MessageBox.Show(cliente.Saludo());

                inventarioForm inventario = new inventarioForm();
                inventario.Show();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Error al procesar la fecha: {ex.Message}", "Formato de Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
