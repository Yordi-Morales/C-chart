using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoII_Tiquete_bus.Modelo;
using ProyectoII_Tiquete_bus.Datos;
using System.Data.SqlClient;


namespace ProyectoII_Tiquete_bus
{
    public partial class CrudHorario : Form
    {
        public CrudHorario()
        {
            InitializeComponent();
            cargarIdRuta();
            cargarTerminal();

        }

        private void CrudHorario_Load(object sender, EventArgs e)
        {
            llenarGrid2();
        }
        private void llenarGrid2()
        {
            DataTable informacion = DatosHorarios.ListarHorario();
            if (informacion == null)
            {
                MessageBox.Show("No se puede acceder a la información");
            }
            else
            {
                dgLista.DataSource = informacion.DefaultView;//Toma la lista como está en la BD
            }
        }

        private void cargarIdRuta()
        {
            cmbRuta1.DataSource = null;
            cmbRuta1.Items.Clear();
            try
            {
                Conexion conex = new Conexion();
                string sql = "SELECT id_ruta,nombre FROM tb_Rutas";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable tabla = new DataTable();
                tabla.Load(dr);//Permite cargar la información que lea de la bd
                cmbRuta1.ValueMember = "nombre";
                cmbRuta1.DisplayMember = "nombre";
                cmbRuta1.DataSource = tabla;
                conex.Desconectar();//se desconecta

            }
            catch (Exception ex)
            {

            }
        }

        private void cargarTerminal()
        {
            cmbTerminal.DataSource = null;
            cmbTerminal.Items.Clear();
            try
            {
                Conexion conex = new Conexion();
                string sql = "SELECT codigo,nombre FROM tb_Terminal";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable tabla = new DataTable();
                tabla.Load(dr);//Permite cargar la información que lea de la bd
                cmbTerminal.ValueMember = "nombre";
                cmbTerminal.DisplayMember = "nombre";
                cmbTerminal.DataSource = tabla;
                conex.Desconectar();//se desconecta

            }
            catch (Exception ex)
            {

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtIdruta.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor..");
            }
            else
            {
                if (cmbRuta1.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar un valor..");
                }
                else
                {
                    if (cmbTerminal.Text.Trim() == "")
                    {
                        MessageBox.Show("Debe ingresar un valor..");
                    }
                    else
                    {
                        if (txtDia.Text.Trim() == "")
                        {
                            MessageBox.Show("Debe ingresar un valor...");
                        }
                        else
                        {

                            try
                            {
                                Horarios emp = new Horarios();
                                emp.Idhorario = txtIdruta.Text.Trim().ToUpper();
                                string valor = cmbRuta1.SelectedValue.ToString();
                                emp.Id_ruta = DatosUnidades.ConsultarUnidad2(valor);
                                string valor2 = cmbTerminal.SelectedValue.ToString();
                                emp.Codigo = DatosHorarios.ConsultarHorario1(valor2);
                                emp.Dia = txtDia.Text.Trim().ToUpper();
                                emp.Horasalida= txtHorasalida.Text.Trim().ToUpper();
                                emp.Horallegada = txtHorallegada.Text.Trim().ToUpper();
                                
                                if (DatosHorarios.GuardarHorario(emp))
                                {
                                    MessageBox.Show("Los datos han sido guardados");
                                    llenarGrid2();//Agregarlo cuando haga ese método Actualiza la información** Agregarla al form1

                                    txtIdruta.Text = "";
                                    cmbRuta1.Text = "";
                                    cmbTerminal.Text = "";
                                    txtDia.Text = "";
                                    txtHorasalida.Text = "";
                                    txtHorallegada.Text = "";
                                   


                                }
                                else
                                {
                                    MessageBox.Show("El Codigo existe, consulte su información");
                                }
                            }


                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }


                    }
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtIdruta.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor..");
            }
            else
            {
                Horarios emp = DatosHorarios.ConsultarHorario(txtIdruta.Text.Trim());
                if (emp == null)
                {
                    MessageBox.Show("El Codigo no existe en el sistema.");
                    consultado = false;
                }
                else
                {
                    txtIdruta.Text = emp.Codigo;
                    cmbRuta1.Text = emp.Id_ruta;
                    cmbTerminal.Text = emp.Codigo;
                    txtDia.Text = emp.Dia;
                    txtHorasalida.Text = emp.Horasalida;
                    txtHorallegada.Text = emp.Horallegada;
                    consultado = true;
                }
            }
        }
        bool consultado = false;
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtIdruta.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor..");
            }
            else
            {
                if (cmbRuta1.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar un valor..");
                }
                else
                {
                    if (cmbTerminal.Text.Trim() == "")
                    {
                        MessageBox.Show("Debe ingresar un valor..");
                    }
                    else
                    {
                        if (txtDia.Text.Trim() == "")
                        {
                            MessageBox.Show("Debe ingresar un valor...");
                        }
                        else
                        {

                            try
                            {
                                Horarios emp = new Horarios();
                                emp.Idhorario = txtIdruta.Text.Trim().ToUpper();
                                string valor = cmbRuta1.SelectedValue.ToString();
                                emp.Id_ruta = DatosUnidades.ConsultarUnidad2(valor);
                                string valor2 = cmbTerminal.SelectedValue.ToString();
                                emp.Codigo = DatosHorarios.ConsultarHorario1(valor2);
                                emp.Dia = txtDia.Text.Trim().ToUpper();
                                emp.Horasalida = txtHorasalida.Text.Trim().ToUpper();
                                emp.Horallegada = txtHorallegada.Text.Trim().ToUpper();

                                if (DatosHorarios.ActualizarHorario(emp))
                                {
                                    MessageBox.Show("Los datos han sido guardados");
                                    llenarGrid2();//Agregarlo cuando haga ese método Actualiza la información** Agregarla al form1

                                    txtIdruta.Text = "";
                                    cmbRuta1.Text = "";
                                    cmbTerminal.Text = "";
                                    txtDia.Text = "";
                                    txtHorasalida.Text = "";
                                    txtHorallegada.Text = "";



                                }
                                else
                                {
                                    MessageBox.Show("El Codigo existe, consulte su información");
                                }
                            }


                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }


                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (consultado == false)
            {
                MessageBox.Show("Debe consultar primero...");
            }
            else if (txtIdruta.Text == "")
            {
                MessageBox.Show("Ingrese un valor");
            }
            else
            {
                if (cmbRuta1.Text == "")
                {
                    MessageBox.Show("Ingrese un valor");
                }
                else
                {
                    try
                    {
                        if (DatosHorarios.EliminarHorario(txtIdruta.Text.Trim()))
                        {
                            llenarGrid2();
                            MessageBox.Show("Los datos han sido Eliminados");
                            consultado = false;
                            txtIdruta.Text = "";
                            cmbRuta1.Text = "";
                            cmbTerminal.Text = "";
                            txtDia.Text = "";
                            txtHorasalida.Text = "";
                            txtHorallegada.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("Los datos NO se eliminaron");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
