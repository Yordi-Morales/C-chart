using ProyectoII_Tiquete_bus.Modelo;
using ProyectoII_Tiquete_bus.Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoII_Tiquete_bus.Datos
{
    internal class DatosTiquetes
    {
        AsientoTemp obj;
        Tiquete_Nacional obj2;
        Conexion conex = new Conexion();

        public static bool GuardarDatos(Tiquete_Nacional e)
        {
            try
            {
      
                Conexion conex = new Conexion();
                string sql = "Insert into tb_Tiquete_Nacional values('" + e.Fecha + "', '" + e.Asiento + "', '" + e.Hora + "', '" + e.Salida + "', '" + e.Destino + "', '" + e.Equipaje + "')";
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


        public static bool GuardarDatosInterSal(Tiquete_Internacional_Salida e)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "Insert into tb_Tiquete_Internacional_Salida values('" + e.Numpasaporte + "', '" + e.Fecha + "', '" + e.Numautobus + "', '" + e.Asiento + "', '" + e.Salida + "', '" + e.Destino + "', '" + e.Equipaje + "')";
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


        public static bool GuardarDatosInterReg(Tiquete_Internacional_Regreso e)
        {
            try
            {
                Conexion conex = new Conexion();
                string sql = "Insert into tb.tb_Tiquete_Internacional_Regreso values('" + e.Fecha + "', '" + e.Hora + "', '" + e.Asiento + "', '" + e.Salida + "', '" + e.Destino + "', '" + e.Equipaje + "')";
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

        public static List<AsientoTemp> Consultarfecha(string fecha, string hora)
        {
            Conexion conex = new Conexion();
            AsientoTemp obj;
            List<AsientoTemp> lista = new List<AsientoTemp>();
            string sql = "SELECT asiento FROM tb_Tiquete_Nacional WHERE fecha ='" + fecha + "'AND hora='" + hora + "'";
            SqlCommand comando = new SqlCommand(sql, conex.Conectar());
            SqlDataReader dr = comando.ExecuteReader();
            if (dr.HasRows)

            {
                while (dr.Read())
                {
                    obj = new AsientoTemp
                    {
                        Asiento = dr.GetString(0)
                    };

                    lista.Add(obj);
                }
                conex.Desconectar();

            }
           return lista;
        }

        public static List<AsientoTemp> Consultarfecha2(string fecha, string hora)
        {
            Conexion conex = new Conexion();
            AsientoTemp obj;
            List<AsientoTemp> lista = new List<AsientoTemp>();
            string sql = "SELECT asiento FROM tb_Tiquete_Internacional_Salida WHERE fecha ='" + fecha + "'AND hora='" + hora + "'";
            SqlCommand comando = new SqlCommand(sql, conex.Conectar());
            SqlDataReader dr = comando.ExecuteReader();
            if (dr.HasRows)

            {
                while (dr.Read())
                {
                    obj = new AsientoTemp
                    {
                        Asiento = dr.GetString(0)
                    };

                    lista.Add(obj);
                }
                conex.Desconectar();

            }
            return lista;
        }

        public static List<AsientoTemp> Consultarfecha3(string fecha, string hora)
        {
            Conexion conex = new Conexion();
            AsientoTemp obj;
            List<AsientoTemp> lista = new List<AsientoTemp>();
            string sql = "SELECT asiento FROM tb_Tiquete_Internacional_Regreso WHERE fecha ='" + fecha + "'AND hora='" + hora + "'";
            SqlCommand comando = new SqlCommand(sql, conex.Conectar());
            SqlDataReader dr = comando.ExecuteReader();
            if (dr.HasRows)

            {
                while (dr.Read())
                {
                    obj = new AsientoTemp
                    {
                        Asiento = dr.GetString(0)
                    };

                    lista.Add(obj);
                }
                conex.Desconectar();

            }
            return lista;
        }


        public static List<Tiquete_Nacional> todo()
        {
            Tiquete_Nacional obj2;
            Conexion conex = new Conexion();

            List<Tiquete_Nacional> lista = new List<Tiquete_Nacional>();
            string sql = "SELECT * FROM tb_Tiquete_Nacional";
            SqlCommand comando = new SqlCommand(sql, conex.Conectar());
            SqlDataReader dr = comando.ExecuteReader();
            if (dr.HasRows)

            {
                while (dr.Read())
                {
                    obj2 = new Tiquete_Nacional
                    {
                        Id = dr.GetInt32(0).ToString(),
                        Fecha = dr.GetString(1),
                        Asiento = dr.GetString(2),
                        Hora = dr.GetTimeSpan(3).ToString(),                       
                        Salida = dr.GetString(4),
                        Destino = dr.GetString(5)
                    };

                    lista.Add(obj2);
                }
                conex.Desconectar();

            }
            return lista;
        }


       

        public static List<Tiquete_Internacional_Salida> todosalida()
        {
            Tiquete_Internacional_Salida obj2;
            Conexion conex = new Conexion();

            List<Tiquete_Internacional_Salida> lista = new List<Tiquete_Internacional_Salida>();
            string sql = "SELECT * FROM tb_Tiquete_Internacional_Salida";
            SqlCommand comando = new SqlCommand(sql, conex.Conectar());
            SqlDataReader dr = comando.ExecuteReader();
            if (dr.HasRows)

            {
                while (dr.Read())
                {
                    obj2 = new Tiquete_Internacional_Salida
                    {
                        Id = dr.GetInt32(0).ToString(),
                        Numpasaporte = dr.GetString(1),
                        Fecha = dr.GetString(2),
                        Hora = dr.GetString(3),
                        Numautobus=dr.GetString(4),
                        Asiento = dr.GetString(5),
                        Salida = dr.GetString(6),
                        Destino = dr.GetString(7),
                        Equipaje=dr.GetString(8)
                    };

                    lista.Add(obj2);
                }
                conex.Desconectar();

            }
            return lista;
        }

        public static List<Tiquete_Internacional_Regreso> todoregreso()
        {
            Tiquete_Internacional_Regreso obj2;
            Conexion conex = new Conexion();

            List<Tiquete_Internacional_Regreso> lista = new List<Tiquete_Internacional_Regreso>();
            string sql = "SELECT * FROM tb_Tiquete_Internacional_Regreso";
            SqlCommand comando = new SqlCommand(sql, conex.Conectar());
            SqlDataReader dr = comando.ExecuteReader();
            if (dr.HasRows)

            {
                while (dr.Read())
                {
                    obj2 = new Tiquete_Internacional_Regreso
                    {
                        Id = dr.GetInt32(0).ToString(),
                        Numpasaporte = dr.GetString(1),
                        Fecha = dr.GetString(2),
                        Hora = dr.GetString(3),
                        Numautobus = dr.GetString(4),
                        Asiento = dr.GetString(5),
                        Salida = dr.GetString(6),
                        Destino = dr.GetString(7),
                        Equipaje = dr.GetString(8)
                    };

                    lista.Add(obj2);
                }
                conex.Desconectar();

            }
            return lista;
        }



    }
}
