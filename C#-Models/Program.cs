using ISW712.UTN.EXAMEN1.GRUPONIMER.Abstraccion;
using ISW712.UTN.EXAMEN1.GRUPONIMER.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISW712.UTN.EXAMEN1.GRUPONIMER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al generador de sentencias SQL");

            while (true)
            {
                Console.WriteLine("\n¿Qué tipo de sentencia SQL quieres generar?");
                Console.WriteLine("1. DDL");
                Console.WriteLine("2. DML");
                Console.WriteLine("3. Salir");
                Console.Write("Selecciona una opción (1-3): ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("\n¿Qué tipo de sentencia DDL quieres generar?");
                        Console.WriteLine("1. CREATE TABLE");
                        Console.WriteLine("2. ALTER TABLE");
                        Console.Write("Selecciona una opción (1-2): ");
                        string ddlOption = Console.ReadLine();

                        Console.WriteLine("\n¿Qué versión de la sentencia quieres generar?");
                        Console.WriteLine("1. Mínima");
                        Console.WriteLine("2. Completa");
                        Console.Write("Selecciona una opción (1-2): ");
                        string ddlVersion = Console.ReadLine();

                        //string ddlStatement = BuildDdlStatement(ddlOption, ddlVersion);
                        //Console.WriteLine("\nLa sentencia DDL generada es:\n" + ddlStatement);
                        //Fabrica mos = new FabricaInstrucciones().GetFabrica("DML", "", "DD");
                        //IGetDML valor = mos.GetDMLF("update", "DD");
                        //valor.GetDML();
                        string instruccion;
                        if (ddlOption == "1")
                        {
                            instruccion = "create";
                        }
                        else
                        {
                            instruccion = "alter";
                        }
                        string version;
                        if (ddlVersion == "1") 
                        {
                            version = "min";
                        }
                        else
                        {
                            version = "max";
                        }
                        Fabrica mosx = new FabricaInstrucciones().GetFabrica("DDL", instruccion, version);
                        IGetDDL val = mosx.GetDDLF(instruccion, version);
                        val.GetDDL();
                        Console.ReadLine();
                        Console.Clear();

                        break;
                    case "2":
                        Console.WriteLine("\n¿Qué tipo de sentencia DML quieres generar?");
                        Console.WriteLine("1. INSERT");
                        Console.WriteLine("2. DELETE");
                        Console.WriteLine("3. UPDATE");
                        Console.WriteLine("4. SELECT");
                        Console.Write("Selecciona una opción (1-4): ");
                        string dmlOption = Console.ReadLine();

                        Console.WriteLine("\n¿Qué versión de la sentencia quieres generar?");
                        Console.WriteLine("1. Mínima");
                        Console.WriteLine("2. Completa");
                        Console.Write("Selecciona una opción (1-2): ");
                        string dmlVersion = Console.ReadLine();

                        string instrucciondml;
                        if (dmlOption == "1")
                        {
                            instrucciondml = "insert";
                        }
                        else if(dmlOption == "2")
                        {
                            instrucciondml = "delete";
                        }
                        else if(dmlOption == "3")
                        {
                            instrucciondml = "update";
                        }
                        else
                        {
                            instrucciondml = "select";
                        }
                        string versiondml;
                        if (dmlVersion == "1")
                        {
                            versiondml = "min";
                        }
                        else
                        {
                            versiondml = "max";
                        }


                        Fabrica mos = new FabricaInstrucciones().GetFabrica("DML", instrucciondml, versiondml);
                        IGetDML valor = mos.GetDMLF(instrucciondml, versiondml);
                        valor.GetDML();
                        Console.ReadLine();
                        Console.Clear();

                        //string dmlStatement = BuildDmlStatement(dmlOption, dmlVersion);
                        //Console.WriteLine("\nLa sentencia DML generada es:\n" + dmlStatement);
                        break;
                    case "3":
                        Console.WriteLine("\nGracias por usar el generador de sentencias SQL. ¡Hasta la próxima!");
                        return;
                    default:
                        Console.WriteLine("\nOpción inválida. Por favor, selecciona una opción válida.");
                        break;
                }
            }          
            //Console.ReadLine();

        }
    }
}
