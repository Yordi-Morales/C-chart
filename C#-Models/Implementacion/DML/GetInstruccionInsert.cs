using ISW712.UTN.EXAMEN1.GRUPONIMER.Builder;
using ISW712.UTN.EXAMEN1.GRUPONIMER.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISW712.UTN.EXAMEN1.GRUPONIMER.Implementacion.DML
{
    internal class GetInstruccionInsert:IGetDML
    {
        string version;
        public GetInstruccionInsert(string version)
        {
            this.version = version;
        }
        public void GetDML()
        {
            var director = new Director();
            var constructor = new ConstructorConcreto();
            director.Constructor = constructor;


            if (version=="min")
            {
                director.ConstruirInsertMinViable();
                Console.WriteLine(constructor.GetProducto().ListarPartes());
            }
            else
            {
                director.ConstruirInstertMax();
                Console.WriteLine(constructor.GetProducto().ListarPartes());
            }
        }
    }
}
