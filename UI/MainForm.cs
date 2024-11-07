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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void mantenimientoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MantenimientoClientes MantenimientoCliente = new MantenimientoClientes();
            MantenimientoCliente.ShowDialog();

        }

        private void orderDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ProcesoOrdenTrabajo ProcesoOrdenTrabajo = new ProcesoOrdenTrabajo();
            ProcesoOrdenTrabajo.ShowDialog();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcesoFacturacion ProcesoFacturacion = new ProcesoFacturacion();
            ProcesoFacturacion.ShowDialog();
        }

        private void mantenimientoProductoServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoProductoServicios MantenimientoProductoServicios = new MantenimientoProductoServicios();
            MantenimientoProductoServicios.ShowDialog();
        }

        private void mantenimientoVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoVendedor MantenimientoVendedor = new MantenimientoVendedor();
            MantenimientoVendedor.ShowDialog();
        }

        private void mantenimientoBicicletaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MantenimientoBicicleta MantenimientoBicicleta = new MantenimientoBicicleta();
            MantenimientoBicicleta.ShowDialog();
        }

        private void mantenimientoTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoTienda MantenimientoTienda = new MantenimientoTienda();
            MantenimientoTienda.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
