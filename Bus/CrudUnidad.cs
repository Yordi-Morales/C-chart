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
    public partial class CrudUnidad : Form
    {
        public CrudUnidad()
        {
            InitializeComponent();
            cargarIdRuta();
        }

        private void CrudUnidad_Load(object sender, EventArgs e)
        {
            llenarGrid2();
        }

        private void llenarGrid2()
        {
            DataTable informacion = DatosUnidades.ListarUnidad();
            if (informacion == null)
            {
                MessageBox.Show("No se puede acceder a la información");
            }
            else
            {
                dgLista2.DataSource = informacion.DefaultView;//Toma la lista como está en la BD
            }
        }

        private void cargarIdRuta()
        {
            cmbRuta.DataSource = null;
            cmbRuta.Items.Clear();
            try
            {
                Conexion conex = new Conexion();
                string sql = "SELECT id_ruta,nombre FROM tb_Rutas";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable tabla = new DataTable();
                tabla.Load(dr);//Permite cargar la información que lea de la bd
                cmbRuta.ValueMember = "nombre";
                cmbRuta.DisplayMember = "nombre";
                cmbRuta.DataSource = tabla;
                conex.Desconectar();//se desconecta

            }
            catch (Exception ex)
            {

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor..");
            }
            else
            {
                if (txtPlaca.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar un valor..");
                }
                else
                {
                    if (txtMotor.Text.Trim() == "")
                    {
                        MessageBox.Show("Debe ingresar un valor..");
                    }
                    else
                    {
                        if (txtModelo.Text.Trim() == "")
                        {
                            MessageBox.Show("Debe ingresar un valor...");
                        }
                        else
                        {

                            try
                            {
                                Unidades emp = new Unidades();
                                emp.Codigo = txtCodigo.Text.Trim().ToUpper();
                                emp.Placa = txtPlaca.Text.Trim().ToUpper();
                                emp.Motor = txtMotor.Text.Trim().ToUpper();
                                emp.Modelo = txtModelo.Text.Trim().ToUpper();
                                emp.Capacidad = txtCapacidad.Text.Trim().ToUpper();
                                emp.Color = txtColor.Text.Trim().ToUpper();
                                string valor = cmbRuta.SelectedValue.ToString();
                                emp.Id_ruta = DatosUnidades.ConsultarUnidad2(valor);
                                emp.Numeropermiso = txtNumeropermiso.Text.Trim().ToUpper();
                                emp.Fecha = dtpFecha.Value.ToString();

                                if (DatosUnidades.GuardarUnidad(emp))
                                {
                                    MessageBox.Show("Los datos han sido guardados");
                                    llenarGrid2();//Agregarlo cuando haga ese método Actualiza la información** Agregarla al form1

                                    txtCodigo.Text = "";
                                    txtPlaca.Text = "";
                                    txtMotor.Text = "";
                                    txtModelo.Text = "";
                                    txtCapacidad.Text = "";
                                    txtColor.Text = "";
                                    cmbRuta.Text = "";
                                    txtNumeropermiso.Text = "";
                                    dtpFecha.Text = "";


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
            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor..");
            }
            else
            {
                Unidades emp = DatosUnidades.ConsultarUnidad(txtCodigo.Text.Trim());
                if (emp == null)
                {
                    MessageBox.Show("El Codigo no existe en el sistema.");
                    consultado = false;
                }
                else
                {
                    txtCodigo.Text = emp.Codigo;
                    txtPlaca.Text = emp.Placa;
                    txtMotor.Text = emp.Motor;
                    txtModelo.Text = emp.Modelo;
                    txtCapacidad.Text = emp.Capacidad;
                    txtColor.Text = emp.Color;
                    cmbRuta.Text = emp.Id_ruta;
                    txtNumeropermiso.Text = emp.Numeropermiso;
                    dtpFecha.Text = emp.Fecha;


                    consultado = true;
                }
            }
        }

        bool consultado = false;
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor..");
            }
            else
            {
                if (txtPlaca.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar un valor..");
                }
                else
                {
                    if (txtMotor.Text.Trim() == "")
                    {
                        MessageBox.Show("Debe ingresar un valor..");
                    }
                    else
                    {
                        if (txtModelo.Text.Trim() == "")
                        {
                            MessageBox.Show("Debe ingresar un valor...");
                        }
                        else
                        {

                            try
                            {
                                Unidades emp = new Unidades();
                                emp.Codigo = txtCodigo.Text.Trim().ToUpper();
                                emp.Placa = txtPlaca.Text.Trim().ToUpper();
                                emp.Motor = txtMotor.Text.Trim().ToUpper();
                                emp.Modelo = txtModelo.Text.Trim().ToUpper();
                                emp.Capacidad = txtCapacidad.Text.Trim().ToUpper();
                                emp.Color = txtColor.Text.Trim().ToUpper();
                                string valor = cmbRuta.SelectedValue.ToString();
                                emp.Id_ruta = DatosUnidades.ConsultarUnidad2(valor);
                                emp.Numeropermiso = txtNumeropermiso.Text.Trim().ToUpper();
                                emp.Fecha = dtpFecha.Value.ToString();

                                if (DatosUnidades.ActualizarUnidad(emp))
                                {
                                    MessageBox.Show("Los datos han sido guardados");
                                    llenarGrid2();//Agregarlo cuando haga ese método Actualiza la información** Agregarla al form1

                                    txtCodigo.Text = "";
                                    txtPlaca.Text = "";
                                    txtMotor.Text = "";
                                    txtModelo.Text = "";
                                    txtCapacidad.Text = "";
                                    txtColor.Text = "";
                                    cmbRuta.Text = "";
                                    txtNumeropermiso.Text = "";
                                    dtpFecha.Text = "";


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
            else if (txtCodigo.Text == "")
            {
                MessageBox.Show("Ingrese un valor");
            }
            else
            {
                if (txtPlaca.Text == "")
                {
                    MessageBox.Show("Ingrese un valor");
                }
                else
                {
                    try
                    {
                        if (DatosUnidades.EliminarUnidad(txtCodigo.Text.Trim()))
                        {
                            llenarGrid2();
                            MessageBox.Show("Los datos han sido Eliminados");
                            consultado = false;
                            txtCodigo.Text = "";
                            txtPlaca.Text = "";
                            txtMotor.Text = "";
                            txtModelo.Text = "";
                            txtCapacidad.Text = "";
                            txtColor.Text = "";
                            cmbRuta.Text = "";
                            txtNumeropermiso.Text = "";
                            dtpFecha.Text = "";

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

