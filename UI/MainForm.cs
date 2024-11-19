using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Entities.DTO;
using ProyectoProgramadolll.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgramadolll.UI
{
    public partial class MainForm : Form
    {
        private VendedorClienteDTO vendedor;

        public MainForm(VendedorClienteDTO oVendedor)
        {
            InitializeComponent();
            this.vendedor = oVendedor;
        }

        private void mantenimientoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vendedor.IdRol == 1)
            {
                MantenimientoClientes MantenimientoCliente = new MantenimientoClientes();
                MantenimientoCliente.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permisos para acceder a Mantenimiento de Clientes", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void orderDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vendedor.IdRol == 1 || vendedor.IdRol == 2 || vendedor.IdRol == 3)
            {
                ProcesoOrdenTrabajo ProcesoOrdenTrabajo = new ProcesoOrdenTrabajo(vendedor);
                ProcesoOrdenTrabajo.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permisos para acceder a Proceso de Orden de Trabajo", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vendedor.IdRol == 1 || vendedor.IdRol == 2)
            {
                ProcesoFacturacion ProcesoFacturacion = new ProcesoFacturacion();
                ProcesoFacturacion.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permisos para acceder a Proceso de Facturación", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mantenimientoProductoServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vendedor.IdRol == 1 || vendedor.IdRol == 2)
            {
                MantenimientoProductoServicios MantenimientoProductoServicios = new MantenimientoProductoServicios();
                MantenimientoProductoServicios.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permisos para acceder a Mantenimiento de Producto y Servicios", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mantenimientoVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vendedor.IdRol == 1 || vendedor.IdRol == 2)
            {
                MantenimientoVendedor MantenimientoVendedor = new MantenimientoVendedor();
                MantenimientoVendedor.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permisos para acceder a Mantenimiento de Vendedor", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void mantenimientoBicicletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vendedor.IdRol == 1 || vendedor.IdRol == 2 || vendedor.IdRol == 3)
            {
                MantenimientoBicicleta MantenimientoBicicleta = new MantenimientoBicicleta(vendedor);
                MantenimientoBicicleta.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permisos para acceder a Mantenimiento de Bicicleta", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void mantenimientoTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vendedor.IdRol == 1 || vendedor.IdRol == 1)
            {
                MantenimientoTienda MantenimientoTienda = new MantenimientoTienda();
                MantenimientoTienda.ShowDialog();
            }
            else
            {
               
                MessageBox.Show("No tiene permisos para acceder a Mantenimiento de Tienda", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (vendedor.IdRol == 2)
            {
                this.mantenimientoClienteToolStripMenuItem.Visible = false;
            }

            if (vendedor.IdRol == 3)
            {
                this.mantenimientoBicicletaToolStripMenuItem.Text = "Mis Bicicletas";
                this.mantenimientoClienteToolStripMenuItem.Visible = false;
                this.mantenimientoProductoServicioToolStripMenuItem.Visible = false;
                this.mantenimientoTiendaToolStripMenuItem.Visible = false;
                this.mantenimientoVendedorToolStripMenuItem.Visible = false;
                this.facturacionToolStripMenuItem.Visible = false;


                
            }
        }
    }
}
