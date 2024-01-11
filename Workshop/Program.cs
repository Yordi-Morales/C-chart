using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieria_en_Software
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona objPersona= new Persona();
            objPersona.CrearPersona("Yordi",21,"15/5/2001");

            Console.WriteLine("Clase Persona");

            Console.WriteLine("Nombre:" +objPersona.Nombre);
            Console.WriteLine("Edad:" + objPersona.Edad);
            Console.WriteLine("Fecha Nacimiento:" + objPersona.FechaNacimiento);

            Console.WriteLine("----------------------------------");

            Estudiante objEstudiante = new Estudiante();
            objEstudiante.CrearEstudiante("421", "3", "21");

            Console.WriteLine("Clase Estudiante");

            Console.WriteLine("Matricula:" + objEstudiante.Matricula);
            Console.WriteLine("Edad:" + objEstudiante.Grado);
            Console.WriteLine("Fecha Nacimiento:" + objEstudiante.Grupo);

            Console.WriteLine("----------------------------------");

            Profesor objProfesor = new Profesor();
            objProfesor.CrearProfesor("23", "3041");

            Console.WriteLine("Clase Profesor");

            Console.WriteLine("Numero Empleado:" + objProfesor.Numero);
            Console.WriteLine("Salario:" + objProfesor.Salario);

            Console.WriteLine("----------------------------------");

            Console.ReadLine();
        }
    }
}
