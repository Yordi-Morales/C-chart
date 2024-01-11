using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoII_Tiquete_bus.Datos;
using ProyectoII_Tiquete_bus.Modelo;
using System.Data.SqlClient;

namespace ProyectoII_Tiquete_bus
{
    public partial class RegistrarUsuario : Form
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor..");
            }
            else
            {
                if (txtUsuario.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar un valor..");
                }
                else
                {
                    if (txtContrasena.Text.Trim() == "")
                    {
                        MessageBox.Show("Debe ingresar un valor..");
                    }
                    else
                    {
                        if (cmbTipo.Text.Trim() == "")
                        {
                            MessageBox.Show("Debe ingresar un valor...");
                        }
                        else
                        {

                            try
                            {
                                Usuarios emp = new Usuarios();
                                emp.Nombre = txtNombre.Text.Trim().ToUpper();
                                emp.Usuario = txtUsuario.Text.Trim().ToUpper();
                                emp.Contrasena = txtContrasena.Text.Trim().ToUpper();
                                string valor = cmbTipo.SelectedItem.ToString();
                                emp.Tipousuario = valor;

                                if (DatosUsuarios.GuardarUsuario(emp))
                                {
                                    MessageBox.Show("Los datos han sido guardados");

                                    txtNombre.Text = "";
                                    txtUsuario.Text = "";
                                    txtContrasena.Text = "";
                                    cmbTipo.Text = "";

                                }
                                else
                                {
                                    MessageBox.Show("El usuario existe, consulte su información");
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
    }
}
