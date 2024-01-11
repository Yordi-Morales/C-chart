using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoII_Tiquete_bus.Modelo;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoII_Tiquete_bus.Datos
{
    internal class DatosUsuarios
    {
        public static bool GuardarUsuario(Usuarios e)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "Insert into tb_Usuarios values('" + e.Nombre + "', '" + e.Usuario + "', '" + e.Contrasena + "','" + e.Tipousuario + "')";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                int cantidad = comando.ExecuteNonQuery();//no es una consulta de seleccion, permite saber cuántas filas son afectas
                if (cantidad == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                conex.Desconectar();

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
