using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISW712.UTN.EXAMEN1.GRUPONIMER.Builder
{
    internal class ConstructorConcreto: IConstructor
    {
        private Producto _producto = new Producto();

        public ConstructorConcreto()
        {
            this.Riniciar();
        }

        public void Riniciar()
        {
            this._producto = new Producto();
        }

        public Producto GetProducto()
        {
            Producto resultado = this._producto;
            this.Riniciar();
            return resultado;
        }


        //DLL
        //Create
        public void CreatePrincipal()
        {
            this._producto.Add("CREATE TABLE <nombre tabla> (");
        }

        public void CreateCampo()
        {
            this._producto.Add("<nombre campo> <tipo dato> [);]");
        }

        public void CreateCampos()
        {
            this._producto.Add("{,<nombre campo> <tipo dato>} ");
        }

        public void CreateCierre()
        {
            this._producto.Add(");");
        }

        //Cierre
        public void AlterPrincipal()
        {
            this._producto.Add("ALTER TABLE <nombre tabla>");
        }

        public void AlterCreateCierre()
        {
            this._producto.Add("ADD <columna> <tipo dato>;");
        }


        //DML
        //Insert
        public void InsertPrincipal()
        {
            this._producto.Add("INSERT INTO <tabla>");
        }

        public void InsertCampos()
        {
            this._producto.Add("[(<campos>)]");
        }

        public void InsertValores()
        {
            this._producto.Add("VALUES(<valores>);");
        }

        //Delete
        public void DeletePrincipal()
        {
            this._producto.Add("DELETE FROM <tabla>");
        }

        public void DeleteCondiciones()
        {
            this._producto.Add("[WHERE <condiciones>]");
        }

        public void DeleteCierre()
        {
            this._producto.Add(";");
        }

        //Select
        public void SelectPrincipal()
        {
            this._producto.Add("SELECT <campos>");
        }

        public void SelectTablas()
        {
            this._producto.Add("FROM <tablas>");
        }

        public void SelectCondiciones()
        {
            this._producto.Add("[WHERE <condiciones>]");
        }

        public void SelectAgrupar()
        {
            this._producto.Add("[GROUP BY <campos>]");
        }

        public void SelectOrdenar()
        {
            this._producto.Add("[ORDER BY <campos>]");
        }

        public void SelectCierre()
        {
            this._producto.Add(";");
        }

        //Update
        public void UpdatePrincipal()
        {
            this._producto.Add("UPDATE FROM <tabla> ");
        }

        public void UpdateAsignacion()
        {
            this._producto.Add("SET <campo> = <valor> ");
        }

        public void UpdateCondiciones()
        {
            this._producto.Add("[WHERE <condiciones>]");
        }

        public void UpdateCierre()
        {
            this._producto.Add(";");
        }
    }
}
