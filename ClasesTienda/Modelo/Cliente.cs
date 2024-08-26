using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTienda.Modelo
{
    public class Cliente
    {
        public string Nombre { set; get; }
        public string Apellido {  set; get; }

        public int FechaNacimiento { set; get; }

        public Cliente(string nombre, string apellido, int fechaNacimiento) { 
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
        }

        public string Saludo()
        {
            return $"Bienvenido {this.Nombre}";
        }
    }
}
