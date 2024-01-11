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

namespace ProyectoII_Tiquete_bus
{
    public partial class CrudTerminal : Form
    {
        public CrudTerminal()
        {
            InitializeComponent();
        }

        private void CrudTerminal_Load(object sender, EventArgs e)
        {
            llenarGrid2();
        }
        private void llenarGrid2()
        {
            DataTable informacion = DatosTerminales.ListarTerminal();
            if (informacion == null)
            {
                MessageBox.Show("No se puede acceder a la información");
            }
            else
            {
                dgLista.DataSource = informacion.DefaultView;//Toma la lista como está en la BD
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
                if (txtNombre.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar un valor..");
                }
                else
                {
                    if (txtUbicacion.Text.Trim() ==  "")
                    {
                        MessageBox.Show("Debe ingresar un valor..");
                    }
                    else
                    {
                        try
                        {
                            Terminales emp = new Terminales();
                            emp.Codigo = txtCodigo.Text.Trim().ToUpper();
                            emp.Nombre = txtNombre.Text.Trim().ToUpper();
                            emp.Ubicacion = txtUbicacion.Text.Trim().ToUpper();
                            if (DatosTerminales.GuardarTerminal(emp))
                            {
                                llenarGrid2();//gregarlo cuando haga ese método Actualiza la información** Agregarla al form1
                                MessageBox.Show("Los datos han sido guardados");
                                txtCodigo.Text = "";
                                txtNombre.Text = "";
                                txtUbicacion.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Codigo, consulte su información");
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor..");
            }
            else
            {
                Terminales emp = DatosTerminales.ConsultarTerminal(txtCodigo.Text.Trim());
                if (emp == null)
                {
                    MessageBox.Show("La cédula no existe en el sistema.");
                    consultado = false;
                }
                else
                {
                    txtCodigo.Text = emp.Codigo;
                    txtNombre.Text = emp.Nombre;
                    txtUbicacion.Text = emp.Ubicacion;
                    consultado = true;
                }
            }
        }

        bool consultado = false;
        private void btnActualizar_Click(object sender, EventArgs e)
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
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Ingrese un valor");
                }
                else
                {
                    try
                    {
                        Terminales emp = new Terminales();
                        emp.Codigo = txtCodigo.Text.Trim().ToUpper();
                        emp.Nombre = txtNombre.Text.Trim().ToUpper();
                        emp.Ubicacion = txtUbicacion.Text.Trim().ToUpper();
                        if (DatosTerminales.ActualizarTerminal(emp))
                        {
                            llenarGrid2();
                            MessageBox.Show("Los datos ha sido Actualizados");
                            consultado = false;
                            txtCodigo.Text = "";
                            txtNombre.Text = "";
                            txtUbicacion.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("Los datos NO se actualizaron");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
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
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Ingrese un valor");
                }
                else
                {
                    try
                    {
                        if (DatosTerminales.EliminarTerminal(txtCodigo.Text.Trim()))
                        {
                            llenarGrid2();
                            MessageBox.Show("Los datos ha sido Eliminados");
                            consultado = false;
                            txtCodigo.Text = "";
                            txtNombre.Text = "";
                            txtUbicacion.Text = "";

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

