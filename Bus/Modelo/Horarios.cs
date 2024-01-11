using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoII_Tiquete_bus.Modelo
{
    internal class Horarios
    {
        private string idhorario;
        private string id_ruta;
        private string codigo;
        private string dia;
        private string horasalida;
        private string horallegada;


        public Horarios()
        {
            this.Idhorario = "";
            this.Id_ruta = "";
            this.Codigo = "";
            this.Dia = "";
            this.Horasalida = "";
            this.Horallegada = "";
        }

        public Horarios(string idhorario,string id_ruta, string codigo, string dia, string horasalida, string horallegada)
        {
            this.Idhorario= idhorario;
            this.Id_ruta= id_ruta;
            this.Codigo= codigo;
            this.Dia= dia;
            this.Horasalida= horasalida;
            this.Horallegada= horallegada;
        }

        public string Idhorario { get => idhorario; set => idhorario = value; }
        public string Id_ruta { get => id_ruta; set => id_ruta = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Dia { get => dia; set => dia = value; }
        public string Horasalida { get => horasalida; set => horasalida = value; }
        public string Horallegada { get => horallegada; set => horallegada = value; }
    }
}
