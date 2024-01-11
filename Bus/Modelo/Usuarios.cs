using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoII_Tiquete_bus.Modelo
{
    internal class Usuarios
    {
        private string  nombre;
        private string  usuario;
        private string  contrasena;
        private string  tipousuario;



        public Usuarios()
        {
            this.Nombre = "";
            this.Usuario = "";
            this.Contrasena = "";
            this.Tipousuario = "";
        }


        public Usuarios(string nombre,string usuario, string contrasena, string tipousuario)
        {
            this.Nombre= nombre;
            this.Usuario= usuario;
            this.Contrasena= contrasena;
            this.Tipousuario= tipousuario;
        }


        public string Nombre { get => nombre; set => nombre = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string Tipousuario { get => tipousuario; set => tipousuario = value; }
    }



}
