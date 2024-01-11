using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoII_Tiquete_bus.Modelo
{
    internal class Rutas
    {
        private string id_ruta;
        private string nombre;
        private string descripcion;


        public Rutas()
        {
            this.Id_ruta = "";
            this.Nombre = "";
            this.Descripcion = "";

        }
       
        public Rutas(string id_ruta, string nombre, string descripcion)
        {
            this.Id_ruta= id_ruta;
            this.Nombre= nombre;
            this.Descripcion= descripcion;
        }

        public string Id_ruta { get => id_ruta; set => id_ruta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
