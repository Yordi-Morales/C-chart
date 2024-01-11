using ISW712.UTN.EXAMEN1.GRUPONIMER.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISW712.UTN.EXAMEN1.GRUPONIMER.Abstraccion
{
    internal class FabricaInstrucciones
    {
        public   Fabrica GetFabrica(string tipoInstruccion, string instruccion , string version)
        {
            if (tipoInstruccion == "DML")
            {
                return new InstruccionDMLFabrica();
            }
            if (tipoInstruccion == "DDL")
            {
                return new InstruccionesDDLFabrica();
            }
            return null;
        }
    }
}
