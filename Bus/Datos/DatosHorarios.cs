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
    internal class DatosHorarios
    {
        public static bool GuardarHorario(Horarios e)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "Insert into tb_Horario values('" + e.Idhorario + "', '" + e.Id_ruta + "', '" + e.Codigo + "', '" + e.Dia + "','" + e.Horasalida + "','" + e.Horallegada + "')";
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

        public static DataTable ListarHorario()
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "SELECT * FROM tb_Horario";
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

        public static Horarios ConsultarHorario(string idhorario)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "SELECT * FROM tb_Horario WHERE idhorario ='" + idhorario + "'";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();

                Horarios emp = new Horarios();
                if (dr.Read())
                {
                    emp.Idhorario = dr["idhorario"].ToString();
                    emp.Id_ruta = dr["id_ruta"].ToString();
                    emp.Codigo = dr["codigo"].ToString();
                    emp.Dia = dr["dia"].ToString();
                    emp.Horasalida = dr["horasalida"].ToString();
                    emp.Horallegada = dr["horallegada"].ToString();
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

        public static string ConsultarHorario1(string nombre)
        {
            string id = "";
            try
            {
                Conexion conex = new Conexion();
                string sql = "SELECT codigo FROM tb_Terminal WHERE nombre ='" + nombre + "'";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader();

                //Unidades emp = new Unidades();
                if (dr.Read())
                {
                    id = dr["codigo"].ToString();

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
        public static string ConsultarHorario2(string nombre)
        {
            string id = "";
            try
            {
                Conexion conex = new Conexion();
                string sql = "SELECT id_ruta FROM tb_Unidad WHERE nombre ='" + nombre + "'";
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
        public static bool ActualizarHorario(Horarios e)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "UPDATE tb_Horario SET id_ruta = '" + e.Id_ruta + "',codigo='" + e.Codigo + "',dia='" + e.Dia + "',horasalida='" + e.Horasalida + "',horallegada='" + e.Horallegada + "' WHERE idhorario ='" + e.Idhorario + "'";
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


        public static bool EliminarHorario(string idhorario)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "DELETE FROM  tb_Horario WHERE idhorario ='" + idhorario + "'";
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
