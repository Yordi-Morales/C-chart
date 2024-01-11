using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoII_Tiquete_bus.Modelo
{
    internal class AsientoTemp
    {
        private string asiento;

        public AsientoTemp()
        {
            this.asiento = "";
        }

        public AsientoTemp(String asiento)
        {
            this.asiento = asiento;
        }

        public string Asiento { get => asiento; set => asiento = value; }
    }
}

