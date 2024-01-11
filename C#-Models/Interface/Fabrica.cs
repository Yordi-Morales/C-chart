using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISW712.UTN.EXAMEN1.GRUPONIMER.Interface
{
    internal abstract class Fabrica
    {
        public abstract IGetDDL GetDDLF(string instruccion, string version);

        public abstract IGetDML GetDMLF(string instruccion, string version);
    }
}
