using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISW712.UTN.EXAMEN1.GRUPONIMER.Builder
{
    internal interface IConstructor
    {
        void CreatePrincipal();
        void CreateCampo();
        void CreateCampos();
        void CreateCierre();
        void AlterPrincipal();
        void AlterCreateCierre();
        void InsertPrincipal();
        void InsertCampos();
        void InsertValores();
        void DeletePrincipal();
        void DeleteCondiciones();
        void DeleteCierre();
        void SelectPrincipal();
        void SelectTablas();
        void SelectCondiciones();
        void SelectAgrupar();
        void SelectOrdenar();
        void SelectCierre();
        void UpdatePrincipal();
        void UpdateAsignacion();
        void UpdateCondiciones();
        void UpdateCierre();
    }
}
