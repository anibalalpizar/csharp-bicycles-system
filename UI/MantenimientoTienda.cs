using ProyectoProgramadolll.BLL;
using ProyectoProgramadolll.Entities;
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
    public partial class MantenimientoTienda : Form
    {
        public MantenimientoTienda()
        {
            InitializeComponent();
        }

       

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            IBLLTienda bllTienda = new BLLTienda();
            try
            {
                Tienda oTienda = new Tienda();
                if (string.IsNullOrEmpty(txtCedulaJuridica.Text))
                {

                    txtCedulaJuridica.Focus();
                    return;
                }

                oTienda.CedulaJuridica = int.Parse(txtCedulaJuridica.Text);
                oTienda.Nombre = txtNombre.Text;
                oTienda.Telefono = int.Parse(txtNumeroTelefonico.Text);
                oTienda.Direccion = txtDireccion.Text;
                oTienda.ImpuestoVenta = decimal.Parse(txtImpuestoVenta.Text);

                oTienda = await bllTienda.GuardarTienda(oTienda);
                this.CargarDatos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cambiarEstado(EstadoMantenimiento estadoMantenimiento)
        {
            this.btnCancelar.Enabled = false;
            this.txtCedulaJuridica.Clear();
            this.txtNombre.Clear();
            this.txtNumeroTelefonico.Clear();
            this.txtDireccion.Clear();
            this.txtImpuestoVenta.Clear();
            switch (estadoMantenimiento)
            {
                case EstadoMantenimiento.Nuevo:
                    this.txtCedulaJuridica.Enabled = true;
                    this.txtNombre.Enabled = true;
                    this.txtNumeroTelefonico.Enabled = true;
                    this.txtDireccion.Enabled = true;
                    this.txtImpuestoVenta.Enabled = true;
                    this.btnCrear.Enabled = true;
                    this.btnEliminar.Enabled = false;
                    this.btnCancelar.Enabled = true;
                    break;
                case EstadoMantenimiento.Editar:
                    this.txtCedulaJuridica.Enabled = false;
                    this.txtCedulaJuridica.Focus();
                    this.txtNombre.Enabled = true;
                    this.txtNumeroTelefonico.Enabled = true;
                    this.txtDireccion.Enabled = true;
                    this.txtImpuestoVenta.Enabled = true;
                    this.btnCrear.Enabled = true;
                    this.btnEliminar.Enabled = false;
                    this.btnCancelar.Enabled = true;
                    break;
                case EstadoMantenimiento.Borrar:
                    break;
                case EstadoMantenimiento.Ninguno:
                    this.txtCedulaJuridica.Enabled = true;
                    this.btnEliminar.Enabled = true;
                    break;
            }
        }

        private async void CargarDatos()
        {
            IBLLTienda bllTienda = new BLLTienda();
            try
            {
                this.cambiarEstado(EstadoMantenimiento.Ninguno);
                dgvDatos.AutoGenerateColumns = false;
                dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                this.dgvDatos.DataSource = await bllTienda.ObtenerTodasLasTiendas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MantenimientoTienda_Load(object sender, EventArgs e)
        {
            try
            {
                this.CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Tienda oTienda = null;
            if(this.dgvDatos.SelectedRows.Count > 0)
            {
                this.cambiarEstado(EstadoMantenimiento.Editar);
                oTienda = this.dgvDatos.SelectedRows[0].DataBoundItem as Tienda;

                this.txtCedulaJuridica.Text = oTienda.CedulaJuridica.ToString();
                this.txtNombre.Text = oTienda.Nombre;
                this.txtNumeroTelefonico.Text = oTienda.Telefono.ToString();
                this.txtDireccion.Text = oTienda.Direccion;
                this.txtImpuestoVenta.Text = oTienda.ImpuestoVenta.ToString();

            } else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.cambiarEstado(EstadoMantenimiento.Ninguno);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            IBLLTienda tiendaBLL = new BLLTienda();
            try
            {

                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    this.cambiarEstado(EstadoMantenimiento.Borrar);
                    Tienda oTienda = this.dgvDatos.SelectedRows[0].DataBoundItem as Tienda;
                    if (MessageBox.Show($"Desea eliminar la tienda con la cedula juridica {oTienda.CedulaJuridica}?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        tiendaBLL.EliminarTienda(oTienda.CedulaJuridica.ToString());
                        this.CargarDatos();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
