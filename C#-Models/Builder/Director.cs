using ISW712.UTN.EXAMEN1.GRUPONIMER.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISW712.UTN.EXAMEN1.GRUPONIMER.Builder
{
    internal class Director
    {
        IConstructor _constructor;

        public IConstructor Constructor
        {
            set { _constructor = value; }
        }

        public void ConstruirInsertMinViable()
        {
            this._constructor.InsertPrincipal();
            this._constructor.InsertValores();
        }

        public void ConstruirInstertMax()
        {
            this._constructor.InsertPrincipal();
            this._constructor.InsertCampos();
            this._constructor.InsertValores();
        }

        public void ConstruirDeleteMin()
        {
            this._constructor.DeletePrincipal();
            this._constructor.CreateCierre();

        }

        public void ConstruirDeleteMax()
        {
            this._constructor.DeletePrincipal();
            this._constructor.DeleteCondiciones();
            this._constructor.CreateCierre();

        }

        public void ConstruirSelectMin()
        {
            this._constructor.SelectPrincipal();
            this._constructor.SelectTablas();
            this._constructor.SelectCierre();
        }

        public void ConstruirSelectMax()
        {
            this._constructor.SelectPrincipal();
            this._constructor.SelectTablas();
            this._constructor.SelectCondiciones();
            this._constructor.SelectAgrupar();
            this._constructor.SelectOrdenar();
            this._constructor.SelectCierre();

        }

        public void ConstruirUpdateMin()
        {
            this._constructor.UpdatePrincipal();
            this._constructor.UpdateAsignacion();
            this._constructor.UpdateCierre();
        }

        public void ConstruirUpdateMax()
        {
            this._constructor.UpdatePrincipal();
            this._constructor.UpdateAsignacion();
            this._constructor.UpdateCondiciones();
            this._constructor.UpdateCierre();

        }

        public void ConstruirAlterMin()
        {
            this._constructor.AlterPrincipal();
            this._constructor.AlterCreateCierre();
        }

        public void ConstruirCreateMin()
        {
            this._constructor.CreatePrincipal();
            this._constructor.CreateCampo();
            this._constructor.CreateCampos();
            this._constructor.CreateCierre();
        }

    }
}
