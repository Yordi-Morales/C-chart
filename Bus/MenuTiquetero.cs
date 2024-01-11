using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoII_Tiquete_bus
{
    public partial class MenuTiquetero : Form
    {
        public MenuTiquetero()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentaTiquetes frm = new VentaTiquetes();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CorteCajaTiquetes frm= new CorteCajaTiquetes();
            frm.Show();
        }
    }
}
