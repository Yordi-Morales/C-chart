using ISW712.UTN.EXAMEN1.GRUPONIMER.Builder;
using ISW712.UTN.EXAMEN1.GRUPONIMER.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISW712.UTN.EXAMEN1.GRUPONIMER.Implementacion.DML
{
    internal class GetInstruccionesDelete:IGetDML
    {
        string version;
        public GetInstruccionesDelete(string version)
        {
            this.version = version;
        }
        public void GetDML()
        {
            var director = new Director();
            var constructor = new ConstructorConcreto();
            director.Constructor = constructor;


            if (version == "min")
            {
                director.ConstruirDeleteMin();
                Console.WriteLine(constructor.GetProducto().ListarPartes());
            }
            else
            {
                director.ConstruirDeleteMax();
                Console.WriteLine(constructor.GetProducto().ListarPartes());
            }
        }
    }
}
