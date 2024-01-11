using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoII_Tiquete_bus.Datos
{
    internal class Conexion
    {
        SqlConnection con;


        //Constructor
        public Conexion()
        {
            con = new SqlConnection("Data Source=DESKTOP-PS8157G;Initial Catalog=Venta_Tiquete;Integrated Security=True");
        }
        //Método para abrir la conexion
        public SqlConnection Conectar()
        {
            try
            {
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //Metodo para cerrar la conexion
        public bool Desconectar()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }


    }
}
