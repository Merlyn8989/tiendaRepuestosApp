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
    public partial class inventarioForm : Form
    {
        public inventarioForm()
        {
            InitializeComponent();
            producto1 = new Producto("Bujillas", 50, 19.99);
            producto2 = new Producto("Frenos", 30, 29.99);
            producto3 = new Producto("Aceite", 20, 9.99);

            producto1Label.Text = producto1.MostrarDetalles();
            producto2Label.Text = producto2.MostrarDetalles();
            producto3Label.Text = producto3.MostrarDetalles();

        }
    }
