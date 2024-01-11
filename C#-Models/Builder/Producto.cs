using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISW712.UTN.EXAMEN1.GRUPONIMER.Builder
{
    internal class Producto
    {
        private List<Object> _partes = new List<object>();

        public void Add(string parte)
        {
            this._partes.Add(parte);
        }
        public string ListarPartes()
        {
            string txtPartes = string.Empty;

            for (int i = 0; i < this._partes.Count; i++)
            {
                txtPartes += this._partes[i] + " , ";
            }

            return "Instruccion: " + txtPartes.Substring(0, txtPartes.Length - 2) + "\n";
        }
    }
}
