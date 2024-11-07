using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgramadolll.UI
{
    public partial class MantenimientoVendedor : Form
    {
        public MantenimientoVendedor()
        {
            InitializeComponent();
        }

     
        private void btnCrear_Click(object sender, EventArgs e)
        {
            Vendedor Vendedor = new Vendedor();
            Vendedor.ShowDialog();
        }

        private void Apellido_Click(object sender, EventArgs e)
        {

        }

    }
}
