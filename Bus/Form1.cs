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
using System.Data.SqlClient;

namespace ProyectoII_Tiquete_bus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string area;
      

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-PS8157G;Initial Catalog=Venta_Tiquete;Integrated Security=True");



        public void loguear(string usuario, string contrasena)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select nombre,tipousuario from tb_Usuarios where usuario = @usuario and contrasena = @pas", conn);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pas", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable(); 
                sda.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    area = dt.Rows[0][1].ToString();

                    MenuPrincipal frm = new MenuPrincipal();
                    frm.ShowDialog();
                    txtUsuario.Text = "";
                    txtContrasena.Text = "";
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrecta");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            loguear(this.txtUsuario.Text, this.txtContrasena.Text);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
