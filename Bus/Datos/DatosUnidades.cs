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
    internal class DatosUnidades
    {
        public static bool GuardarUnidad(Unidades e)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "Insert into tb_Unidad values('" + e.Codigo + "', '" + e.Placa + "', '" + e.Motor + "', '" + e.Modelo + "','" + e.Capacidad + "','" + e.Color + "','" + e.Id_ruta + "','" + e.Numeropermiso + "','" + e.Fecha + "')";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                int cantidad = comando.ExecuteNonQuery();//no es una consulta de seleccion, permite saber cuántas filas son afectas
                if (cantidad >= 1)
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

        public static DataTable ListarUnidad()
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "SELECT * FROM tb_Unidad";
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

        public static Unidades ConsultarUnidad(string codigo)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "SELECT * FROM tb_Unidad WHERE codigo ='" + codigo + "'";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();

                Unidades emp = new Unidades();
                if (dr.Read())
                {
                    emp.Codigo = dr["codigo"].ToString();
                    emp.Placa = dr["placa"].ToString();
                    emp.Motor = dr["motor"].ToString();
                    emp.Modelo = dr["modelo"].ToString();
                    emp.Capacidad = dr["capacidad"].ToString();
                    emp.Color = dr["color"].ToString();
                    emp.Id_ruta = dr["id_ruta"].ToString();
                    emp.Numeropermiso = dr["numeropermiso"].ToString();
                    emp.Fecha = dr["fecha"].ToString();
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

        public static string ConsultarUnidad2(string nombre)
        {
            string id = "";
            try
            {
                Conexion conex = new Conexion();
                string sql = "SELECT id_ruta FROM tb_Rutas WHERE nombre ='" + nombre + "'";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();

                //Unidades emp = new Unidades();
                if (dr.Read())
                {
                    id = dr["id_ruta"].ToString();

                    conex.Desconectar();//se desconecta
                    return id;
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

        public static bool ActualizarUnidad(Unidades e)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "UPDATE tb_Unidad SET placa = '" + e.Placa + "',motor='" + e.Motor + "',modelo='" + e.Modelo + "',capacidad='" + e.Capacidad + "',color='" + e.Color + "',id_ruta='" + e.Id_ruta + "',numeropermiso='" + e.Numeropermiso + "',fecha='" + e.Fecha + "' WHERE codigo ='" + e.Codigo + "'";
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


        public static bool EliminarUnidad(string codigo)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "DELETE FROM  tb_Unidad WHERE codigo ='" + codigo + "'";
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
