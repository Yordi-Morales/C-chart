using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieria_en_Software
{
    internal class Persona
    {

        private string nombre;
        private int edad;
        private string fechaNacimiento;
        private string sexo;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Sexo { get => sexo; set => sexo = value; }

        public void CrearPersona(string nombre, int edad, string fecha_nacimiento)
        {
            this.nombre = nombre;
            this.fechaNacimiento= fecha_nacimiento;
            this.edad= edad;
        }
     
    }
}
