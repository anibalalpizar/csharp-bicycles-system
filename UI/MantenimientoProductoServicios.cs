using ProyectoProgramadolll.BLL;
using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Entities.DTO;
using ProyectoProgramadolll.Interfaces;
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
    public partial class MantenimientoProductoServicios : Form
    {
        private decimal tipoCambioventa;
        public MantenimientoProductoServicios()
        {
            InitializeComponent();
        }


        private void MantenimientoProductoServicios_Load(object sender, EventArgs e)
        {
            try
            {
                this.CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos", ex.Message);
            }
        }

        private async void CargarDatos()
        {
            IBLLProductoServicio bllProductoServicio = new BLLProductoServicio();
            IBLLTienda bllTienda;

            List<Tienda> listaTienda;
            try
            {

                bllTienda = new BLLTienda();
                listaTienda = (await bllTienda.ObtenerTodasLasTiendas()).ToList();

                cmbTiendas.DataSource = listaTienda;
                cmbTiendas.DisplayMember = "Nombre";
                cmbTiendas.ValueMember = "IdTienda";

                dgvDatos.AutoGenerateColumns = false;
                dgvDatos.RowTemplate.Height = 100;
                dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                this.dgvDatos.DataSource = bllProductoServicio.ObtenerProductoServicios();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos", ex.Message);
            }
        }

        private void cambiarEstado(EstadoMantenimiento estadoMantenimiento)
        {
            this.btnCancelar.Enabled = false;
            this.txtCodigoProductoServicio.Clear();
            this.cmbTiendas.SelectedIndex = 0;
            this.rdbActivo.Checked = true;
            this.rdbNoActivo.Checked = false;
            this.txtDescripcion.Clear();
            this.txtCantidadInventario.Clear();
            this.txtPrecioColones.Clear();
            this.txtPrecioDolares.Clear();


            switch (estadoMantenimiento)
            {
                case EstadoMantenimiento.Nuevo:
                    this.txtCodigoProductoServicio.Enabled = true;
                    this.rdbActivo.Enabled = true;
                    this.rdbNoActivo.Enabled = true;
                    this.cmbTiendas.Enabled = true;
                    this.btnCrear.Enabled = true;
                    this.btnEliminar.Enabled = false;
                    this.btnCancelar.Enabled = true;
                    break;
                case EstadoMantenimiento.Editar:
                    this.txtCodigoProductoServicio.Enabled = false;
                    this.txtCodigoProductoServicio.Focus();
                    this.rdbActivo.Enabled = true;
                    this.rdbNoActivo.Enabled = true;
                    this.cmbTiendas.Enabled = true;
                    this.btnCrear.Enabled = true;
                    this.btnEliminar.Enabled = false;
                    this.btnCancelar.Enabled = true;
                    break;
                case EstadoMantenimiento.Borrar:
                    break;
                case EstadoMantenimiento.Ninguno:
                    this.txtCodigoProductoServicio.Enabled = true;
                    this.btnEliminar.Enabled = true;
                    break;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            IBLLProductoServicio bllProductoServicio = new BLLProductoServicio();

            try
            {
                //validaciones
                if (string.IsNullOrEmpty(txtCodigoProductoServicio.Text))
                {
                    MessageBox.Show("El código del producto/servicio es requerido");
                    return;
                }

                ProductoServicio productoServicio = new ProductoServicio();

                productoServicio.CodigoProductoServicio = txtCodigoProductoServicio.Text;
                productoServicio.IdTienda = (int)cmbTiendas.SelectedValue;
                productoServicio.Descripcion = txtDescripcion.Text;
                productoServicio.CantidadInventario = int.Parse(txtCantidadInventario.Text);
                productoServicio.PrecioColones = decimal.Parse(txtPrecioColones.Text);
                productoServicio.Venta = decimal.Parse(txtPrecioDolares.Text);
                productoServicio.Estado = rdbActivo.Checked ? true : false;

                bllProductoServicio.GuardarProductoServicio(productoServicio);
                MessageBox.Show("Producto/servicio guardado correctamente", "Exito", MessageBoxButtons.OK);
                this.CargarDatos();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto/servicio", ex.Message);
            }
        }

        private async void btnCalcularPrecioDolar_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPrecioColones.Text, out decimal precioColones))
            {
                MessageBox.Show("El precio en colones no es valido");
                return;
            }

            tipoCambioventa = await Utils.ObtenerTipoCambioAsync();

            if (tipoCambioventa == 0)
            {
                MessageBox.Show("No se pudo obtener el tipo de cambio");
                return;
            }

            decimal precioDolares = precioColones / tipoCambioventa;
            //txtPrecioDolares.Text = $"${precioDolares:0.00}";
            txtPrecioDolares.Text = precioDolares.ToString("0.00");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.cambiarEstado(EstadoMantenimiento.Ninguno);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            IBLLProductoServicio bllProductoServicio = new BLLProductoServicio();
            try
            {

                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    ProductoServicioDTO oProductoServicio = (ProductoServicioDTO)this.dgvDatos.SelectedRows[0].DataBoundItem as ProductoServicioDTO;
                    if (MessageBox.Show($"¿Está seguro que desea eliminar el producto/servicio {oProductoServicio.CodigoProductoServicio}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bllProductoServicio.EliminarProductoServicio(oProductoServicio.CodigoProductoServicio);
                        MessageBox.Show("Producto/servicio eliminado correctamente", "Exito", MessageBoxButtons.OK);
                        this.CargarDatos();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un vendedor para eliminar", "Atención");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto/servicio", ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ProductoServicioDTO oProductoServicio = null;
            if (this.dgvDatos.SelectedRows.Count > 0)
            {
                this.cambiarEstado(EstadoMantenimiento.Editar);
                oProductoServicio = this.dgvDatos.SelectedRows[0].DataBoundItem as ProductoServicioDTO;

                this.txtCodigoProductoServicio.Text = oProductoServicio.CodigoProductoServicio;
                this.cmbTiendas.SelectedValue = oProductoServicio.IdTienda;
                this.txtDescripcion.Text = oProductoServicio.Descripcion;
                this.txtCantidadInventario.Text = oProductoServicio.CantidadInventario.ToString();
                this.txtPrecioColones.Text = oProductoServicio.PrecioColones.ToString();
                this.txtPrecioDolares.Text = oProductoServicio.Venta.ToString();
                this.rdbActivo.Checked = oProductoServicio.DescripcionEstado == "Activo";
                this.rdbNoActivo.Checked = oProductoServicio.DescripcionEstado != "Activo";

            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto/servicio para editar", "Atencion");
            }
        }
    }
}
