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
    public partial class MenuEncomiendas : Form
    {
        public MenuEncomiendas()
        {
            InitializeComponent();
        }

        private void btnEnvio_Click(object sender, EventArgs e)
        {
            EnvioEcomienda frm = new EnvioEcomienda();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
