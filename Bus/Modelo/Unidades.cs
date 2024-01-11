using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoII_Tiquete_bus.Modelo
{
    internal class Unidades
    {
        private string codigo;
        private string placa;
        private string motor;
        private string modelo;
        private string capacidad;
        private string color;
        private string id_ruta;
        private string numeropermiso;
        private string fecha;



        public Unidades()
        {
            this.Codigo = "";
            this.Placa = "";
            this.Motor = "";
            this.Modelo = "";
            this.Capacidad = "";
            this.Color = "";
            this.Id_ruta = "";
            this.Numeropermiso = "";
            this.Fecha = "";
         }


        public Unidades(string codigo, string placa, string motor, string modelo, string capacidad, string color ,string id_ruta,string numeropermiso,string fecha)
        {
            this.Codigo = codigo;
            this.Placa = placa;
            this.Motor = motor;
            this.Modelo = modelo;
            this.Capacidad= capacidad;
            this.Color = color;
            this.Id_ruta= id_ruta;
            this.Numeropermiso= numeropermiso;
            this.Fecha = fecha;
        }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Motor { get => motor; set => motor = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Capacidad { get => capacidad; set => capacidad = value; }
        public string Color { get => color; set => color = value; }
        public string Id_ruta { get => id_ruta; set => id_ruta = value; }
        public string Numeropermiso { get => numeropermiso; set => numeropermiso = value; }
        public string Fecha { get => fecha; set => fecha = value; }
    }
}
