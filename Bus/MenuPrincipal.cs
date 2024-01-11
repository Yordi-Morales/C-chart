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
using System.Data.SqlClient;
using ProyectoII_Tiquete_bus.Resources;

namespace ProyectoII_Tiquete_bus
{
    public partial class MenuPrincipal : Form
    {
        

        Usuarios usu = new Usuarios();

        public MenuPrincipal()
        {
            InitializeComponent();

        }

        private void registrarUsuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistrarUsuario frm = new RegistrarUsuario();
            frm.Show();
        }

        private void crudsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAdmin menu = new MenuAdmin();
            menu.Show();
        }

        private void btnEncomienda_Click(object sender, EventArgs e)
        {
            MenuEncomiendas menu = new MenuEncomiendas();
            menu.Show();    
        }

        private void btnTiquete_Click(object sender, EventArgs e)
        {
            MenuTiquetero menu = new MenuTiquetero();   
            menu.Show();
        }

      
        

        
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
          if(Form1.area == "Admin")
            {
             opcionesstp.Enabled = true;
             crudsstp.Enabled = true;
             tiquetesstp.Enabled = true;
             encomiendasstp.Enabled = true;
             reportesstp.Enabled = true;
               
            }
            else if(Form1.area == "Tiquetero")
            {
                registrarUsuariosTS1.Enabled = false;
                crudsstp.Enabled = false;
                encomiendasstp.Enabled = false;
                reportesstp.Enabled = false;
     
            }
          else if(Form1.area == "Encomiendas")
            {
                registrarUsuariosTS1.Enabled = false;
                crudsstp.Enabled = false;
                tiquetesstp.Enabled = false;
                reportesstp.Enabled = false;

            }
          else if (Form1.area == "Asistente Administrativo")
            {
                registrarUsuariosTS1.Enabled = false;
                tiquetesstp.Enabled = false;
                encomiendasstp.Enabled = false;
                reportesstp.Enabled = false;


            }
          else if(Form1.area == "Asistente Terminal")
            {
                registrarUsuariosTS1.Enabled = false;
                horariosstp.Enabled = false;
                unidadesstp.Enabled = false;
                rutasstp.Enabled = false;
                tiquetesstp.Enabled = false;
                encomiendasstp.Enabled = false;
                reportesstp.Enabled = false;
            }
               
        }

        private void terminalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrudTerminal frm = new CrudTerminal();
            frm.Show();
        }

        private void horariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrudHorario frm = new CrudHorario();
            frm.Show();
        }

        private void rutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrudRuta frm = new CrudRuta();
            frm.Show();
        }

        private void unidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrudUnidad frm = new CrudUnidad();
            frm.Show();
        }

        private void tiquetesToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void encomiendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEncomiendas frm = new MenuEncomiendas();
            frm.Show();
        }

        private void cualEsLaRutaEnLaQueSeEnvíaMásEncomiendasPorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crudsstp_Click(object sender, EventArgs e)
        {

        }

        private void cerrarCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ventaNacionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentaTiquetes frm = new VentaTiquetes();
            frm.Show();
        }

        private void opcionesstp_Click(object sender, EventArgs e)
        {

        }

        private void ventaInternacionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentaTiqueteInternacional frm = new VentaTiqueteInternacional();
            frm.Show();
        }
    }
 }

