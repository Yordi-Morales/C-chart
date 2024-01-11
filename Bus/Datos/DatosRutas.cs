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
    internal class DatosRutas
    {
        public static bool GuardarRuta(Rutas e)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "Insert into tb_Rutas values('" + e.Id_ruta + "', '" + e.Nombre + "', '" + e.Descripcion + "')";
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

        public static DataTable ListarRuta()
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "SELECT * FROM tb_Rutas";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable tabla = new DataTable();
                tabla.Load(dr);//Permite cargar la información que lea de la bd
                conex.Desconectar();//se desconecta
                return tabla;//retorna la tabla
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static Rutas ConsultarRuta(string id_ruta)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "SELECT * FROM tb_Rutas WHERE id_ruta ='" + id_ruta + "'";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();

                Rutas emp = new Rutas();
                if (dr.Read())
                {
                    emp.Id_ruta = dr["id_ruta"].ToString();
                    emp.Nombre = dr["nombre"].ToString();
                    emp.Descripcion = dr["descripcion"].ToString();
                    conex.Desconectar();//se desconecta
                    return emp;
                }
                else
                {
                    conex.Desconectar();//se desconecta
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static bool ActualizarRuta(Rutas e)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "UPDATE tb_Rutas SET nombre = '" + e.Nombre + "',descripcion='" + e.Descripcion + "' WHERE id_ruta ='" + e.Id_ruta + "'";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    conex.Desconectar();
                    return true;
                }
                else
                {
                    conex.Desconectar();
                    return false;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }


        public static bool EliminarRuta(string id_ruta)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "DELETE FROM  tb_Rutas WHERE id_ruta ='" + id_ruta + "'";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    conex.Desconectar();
                    return true;
                }
                else
                {
                    conex.Desconectar();
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }


    }
}
