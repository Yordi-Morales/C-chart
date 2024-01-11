using ISW712.UTN.EXAMEN1.GRUPONIMER.Implementacion;
using ISW712.UTN.EXAMEN1.GRUPONIMER.Implementacion.DML;
using ISW712.UTN.EXAMEN1.GRUPONIMER.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISW712.UTN.EXAMEN1.GRUPONIMER.Abstraccion
{
    internal class InstruccionDMLFabrica:Fabrica
    {
        public override IGetDDL GetDDLF(string instruccion,string version)
        {
            return null;
        }

        public override IGetDML GetDMLF(string instruccion ,string version)
        {
            if (instruccion == "delete")
            {
                return new GetInstruccionesDelete(version);
            }
            if (instruccion == "select")
            {
                return new GetInstruccionesSelect(version);
            }
            if (instruccion == "update")
            {
                return new GetInstruccionesUpdate(version);
            }
            if (instruccion == "insert")
            {
                return new GetInstruccionInsert(version);
            }



            return null;
        }
    }
}
