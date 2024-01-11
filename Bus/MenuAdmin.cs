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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void btnTerminal_Click(object sender, EventArgs e)
        {
            CrudTerminal frm = new CrudTerminal();
            frm.Show();
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            CrudHorario frm = new CrudHorario();
            frm.Show();
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            CrudRuta frm = new CrudRuta();
            frm.Show();
        }

        private void btnUnidades_Click(object sender, EventArgs e)
        {
            CrudUnidad frm = new CrudUnidad();
            frm.Show();
        }
    }
}
