using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoII_Tiquete_bus.Modelo
{
    internal class Tiquete_Nacional
    {
        private string id;
        private string fecha;
        private string asiento;
        private string hora;       
        private string salida;
        private string destino;
        private string equipaje;
        

        public Tiquete_Nacional()
        {
            this.id = "";
            this.fecha = "";
            this.hora = "";
            this.asiento = "";
            this.salida = "";
            this.destino = "";
            this.equipaje = "";

        }

        public Tiquete_Nacional(string id, string fecha, string hora, string asiento, string salida, string destino,string equipaje)
        {
            this.id = id;
            this.fecha = fecha;
            this.hora = hora;
            this.asiento = asiento;
            this.salida = salida;
            this.destino = destino;
            this.equipaje= equipaje;
        }

        public string Id { get => id; set => id = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Asiento { get => asiento; set => asiento = value; }
        public string Salida { get => salida; set => salida = value; }
        public string Destino { get => destino; set => destino = value; }
        public string Equipaje { get => equipaje; set => equipaje = value; }

    }
}
