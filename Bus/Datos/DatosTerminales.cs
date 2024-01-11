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
    internal class DatosTerminales
    {
        public static bool GuardarTerminal(Terminales e)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "Insert into tb_Terminal values('" + e.Codigo + "', '" + e.Nombre + "', '" + e.Ubicacion + "')";
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

        public static DataTable ListarTerminal()
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "SELECT * FROM tb_Terminal";
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

        public static Terminales ConsultarTerminal(string codigo)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "SELECT * FROM tb_Terminal WHERE codigo ='" + codigo + "'";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();

                Terminales emp = new Terminales();
                if (dr.Read())
                {
                    emp.Codigo = dr["codigo"].ToString();
                    emp.Nombre = dr["nombre"].ToString();
                    emp.Ubicacion = dr["ubicacion"].ToString();
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

        public static bool ActualizarTerminal(Terminales e)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "UPDATE tb_Terminal SET nombre = '" + e.Nombre + "',ubicacion='" + e.Ubicacion + "' WHERE codigo ='" + e.Codigo + "'";
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


        public static bool EliminarTerminal(string codigo)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "DELETE FROM  tb_Terminal WHERE codigo ='" + codigo + "'";
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
