using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoII_Tiquete_bus.Modelo
{
    internal class Encomiendas
    {
        private string idencomienda;
        private string codigopersona;
        private string fecha;
        private string nombre;
        private string codigoterminal;
        private string codigounidad;
        private int totalpagar;


        public Encomiendas()
        {
            this.Idencomienda = "";
            this.Codigopersona = "";
            this.Fecha = "";
            this.Nombre = "";
            this.Codigoterminal = "";
            this.Codigounidad = "";
            this.Totalpagar = 0;
        }

        public Encomiendas(string idencomienda, string codigopersona, string fecha, string nombre, string codigoterminal, string codigounidad, int totalpagar)
        {
            this.Idencomienda= idencomienda;
            this.Codigopersona= codigopersona;
            this.Fecha= fecha;
            this.Nombre= nombre;
            this.Codigoterminal= codigoterminal;
            this.Codigounidad= codigounidad;
            this.Totalpagar= totalpagar;
        }

        public string Idencomienda { get => idencomienda; set => idencomienda = value; }
        public string Codigopersona { get => codigopersona; set => codigopersona = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Codigoterminal { get => codigoterminal; set => codigoterminal = value; }
        public string Codigounidad { get => codigounidad; set => codigounidad = value; }
        public int Totalpagar { get => totalpagar; set => totalpagar = value; }
    }
}
