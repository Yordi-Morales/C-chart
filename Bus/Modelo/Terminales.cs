using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoII_Tiquete_bus.Modelo
{
    internal class Terminales
    {
        private string codigo;
        private string nombre;
        private string ubicacion;



        public Terminales()
        {
            this.Codigo = "";
            this.Nombre = "";
            this.Ubicacion = "";
        }

        public Terminales(string codigo, string nombre, string ubicacion)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Ubicacion= ubicacion;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
    }
}
