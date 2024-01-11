using ISW712.UTN.EXAMEN1.GRUPONIMER.Implementacion;
using ISW712.UTN.EXAMEN1.GRUPONIMER.Implementacion.DDL;
using ISW712.UTN.EXAMEN1.GRUPONIMER.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISW712.UTN.EXAMEN1.GRUPONIMER.Abstraccion
{
    internal class InstruccionesDDLFabrica:Fabrica
    {
        public override IGetDDL GetDDLF(string instruccion ,string version)
        {
            if (instruccion == "create")
            {
                return new GetInstruccionCreate(version); 
            }
            if (instruccion == "alter")
            {
                return new GetInstruccionesAlter(version);
            }
            return null;
        }

        public override IGetDML GetDMLF(string instruccion, string version)
        {
            return null;
        }
    }
}
