using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieria_en_Software
{
    internal class Estudiante:Persona
    {

        private string matricula;
        private string grado;
        private string grupo;

        public string Matricula { get => matricula; set => matricula = value; }
        public string Grado { get => grado; set => grado = value; }
        public string Grupo { get => grupo; set => grupo = value; }

        public void CrearEstudiante(string matricula, string grado, string grupo)
        {
            this.matricula = matricula;
            this.grado= grado;
            this.grupo= grupo;
        }
     
    }
}
