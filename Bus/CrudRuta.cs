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
    public partial class CrudRuta : Form
    {
        public CrudRuta()
        {
            InitializeComponent();
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
                    if (txtDescripcion.Text.Trim() == "")
                    {
                        MessageBox.Show("Debe ingresar un valor..");
                    }
                    else
                    {
                        try
                        {
                            Rutas emp = new Rutas();
                            emp.Id_ruta = txtCodigo.Text.Trim().ToUpper();
                            emp.Nombre = txtNombre.Text.Trim().ToUpper();
                            emp.Descripcion = txtDescripcion.Text.Trim().ToUpper();
                            if (DatosRutas.GuardarRuta(emp))
                            {
                                llenarGrid2();//gregarlo cuando haga ese método Actualiza la información** Agregarla al form1
                                MessageBox.Show("Los datos han sido guardados");
                                txtCodigo.Text = "";
                                txtNombre.Text = "";
                                txtDescripcion.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Codigo existe, consulte su información");
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

        private void llenarGrid2()
        {
            DataTable informacion = DatosRutas.ListarRuta();
            if (informacion == null)
            {
                MessageBox.Show("No se puede acceder a la información");
            }
            else
            {
                dgLista.DataSource = informacion.DefaultView;//Toma la lista como está en la BD
            }
        }

        private void CrudRuta_Load(object sender, EventArgs e)
        {
            llenarGrid2();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor..");
            }
            else
            {
                Rutas emp = DatosRutas.ConsultarRuta(txtCodigo.Text.Trim());
                if (emp == null)
                {
                    MessageBox.Show("La cédula no existe en el sistema.");
                    consultado = false;
                }
                else
                {
                    txtCodigo.Text = emp.Id_ruta;
                    txtNombre.Text = emp.Nombre;
                    txtDescripcion.Text = emp.Descripcion;
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
                        Rutas emp = new Rutas();
                        emp.Id_ruta = txtCodigo.Text.Trim().ToUpper();
                        emp.Nombre = txtNombre.Text.Trim().ToUpper();
                        emp.Descripcion = txtDescripcion.Text.Trim().ToUpper();
                        if (DatosRutas.ActualizarRuta(emp))
                        {
                            llenarGrid2();
                            MessageBox.Show("Los datos ha sido Actualizados");
                            consultado = false;
                            txtCodigo.Text = "";
                            txtNombre.Text = "";
                            txtDescripcion.Text = "";

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
                        if (DatosRutas.EliminarRuta(txtCodigo.Text.Trim()))
                        {
                            llenarGrid2();
                            MessageBox.Show("Los datos ha sido Eliminados");
                            consultado = false;
                            txtCodigo.Text = "";
                            txtNombre.Text = "";
                            txtDescripcion.Text = "";

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
