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
    internal class DatosEncomienda
    {
        public static bool GuardarEncomienda(Encomiendas e)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "Insert into tb_Encomienda values('" + e.Idencomienda + "', '" + e.Codigopersona + "', '" + e.Fecha + "','"+ e.Nombre +"','" + e.Codigoterminal+ "','" + e.Codigounidad +"',"+ e.Totalpagar +")";
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

        public static DataTable ListarEncomiendas()
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "SELECT * FROM tb_Encomienda";
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

        public static string ConsultarEncomienda1(string nombre)
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
        public static string ConsultarEncomienda2(string motor)
        {
            string id = "";
            try
            {
                Conexion conex = new Conexion();
                string sql = "SELECT codigo FROM tb_Unidad WHERE motor ='" + motor + "'";
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
    }
}
