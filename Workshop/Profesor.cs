using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieria_en_Software
{
    internal class Profesor:Persona
    {

        private string numero;
        private string salario;

        public string Numero { get => numero; set => numero = value; }
        public string Salario { get => salario; set => salario = value; }

        public void CrearProfesor(string numero, string salario)
        {
            this.numero = numero;
            this.salario= salario;
        }
     
    }
}
