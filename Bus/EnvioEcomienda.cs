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
    public partial class EnvioEcomienda : Form
    {
        public EnvioEcomienda()
        {
            InitializeComponent();
            cargarterminal();
            cargarUnidad();
        }

        private void cargarterminal()
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
                cmbTerminal.DisplayMember = "codigo";
                cmbTerminal.DataSource = tabla;
                conex.Desconectar();//se desconecta

            }
            catch (Exception ex)
            {

            }
        }
        private void cargarUnidad()
        {
            cmbUnidad.DataSource = null;
            cmbUnidad.Items.Clear();
            try
            {
                Conexion conex = new Conexion();
                string sql = "SELECT codigo,motor FROM tb_Unidad";
                SqlCommand comando = new SqlCommand(sql, conex.Conectar());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable tabla = new DataTable();
                tabla.Load(dr);//Permite cargar la información que lea de la bd
                cmbUnidad.ValueMember = "motor";
                cmbUnidad.DisplayMember = "codigo";
                cmbUnidad.DataSource = tabla;
                conex.Desconectar();//se desconecta

            }
            catch (Exception ex)
            {

            }
        }

        private void llenarGrid2()
        {
            DataTable informacion = DatosEncomienda.ListarEncomiendas();
            if (informacion == null)
            {
                MessageBox.Show("No se puede acceder a la información");
            }
            else
            {
                dgLista.DataSource = informacion.DefaultView;//Toma la lista como está en la BD
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor..");
            }
            else
            {
                if (txtCodigo.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar un valor..");
                }
                else
                {
                    if (txtNombre.Text.Trim() == "")
                    {
                        MessageBox.Show("Debe ingresar un valor..");
                    }
                    else
                    {
                        if (txtTotal.Text.Trim() == "")
                        {
                            MessageBox.Show("Debe ingresar un valor...");
                        }
                        else
                        {

                            try
                            {
                                Encomiendas emp = new Encomiendas();
                                emp.Idencomienda = txtId.Text.Trim().ToUpper();
                                emp.Codigopersona = txtCodigo.Text.Trim().ToUpper();
                                emp.Fecha = dtpFecha.Text.Trim().ToUpper();
                                emp.Nombre = txtNombre.Text.Trim().ToUpper();
                                string valor = cmbTerminal.SelectedValue.ToString();
                                emp.Codigoterminal = DatosEncomienda.ConsultarEncomienda1(valor);
                                string valor2 = cmbUnidad.SelectedValue.ToString();
                                emp.Codigounidad = DatosEncomienda.ConsultarEncomienda2(valor2);
                                emp.Totalpagar = Convert.ToInt32(txtTotal.Text.Trim());

                                if (DatosEncomienda.GuardarEncomienda(emp))
                                {
                                    MessageBox.Show("Los datos han sido guardados");
                                    llenarGrid2();//Agregarlo cuando haga ese método Actualiza la información** Agregarla al form1

                                    txtId.Text = "";
                                    txtCodigo.Text = "";
                                    dtpFecha.Text = "";
                                    txtNombre.Text = "";
                                    cmbTerminal.Text = "";
                                    cmbUnidad.Text = "";
                                    txtTotal.Text = "";
                                    


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

        private void EnvioEcomienda_Load(object sender, EventArgs e)
        {
            llenarGrid2();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
