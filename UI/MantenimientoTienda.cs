using ProyectoProgramadolll.BLL;
using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Interfaces;
using System;
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
                cambiarEstado(EstadoMantenimiento.Nuevo);
                Tienda oTienda = new Tienda();
                if (string.IsNullOrEmpty(txtCedulaJuridica.Text))
                {

                    MessageBox.Show("El código la tienda es requerido", "Atencion!");
                    return;
                }

                if (string.IsNullOrEmpty(txtNombre.Text))
                {

                    MessageBox.Show("El nombre de la tienda es requerido", "Atencion!");
                    return;
                }

                if (string.IsNullOrEmpty(txtNumeroTelefonico.Text))
                {

                    MessageBox.Show("El número telefónico de la tienda es requerido", "Atencion!");
                    return;
                }

                if (string.IsNullOrEmpty(txtDireccion.Text))
                {

                    MessageBox.Show("La dirección de la tienda es requerida", "Atencion!");
                    return;
                }

                if (string.IsNullOrEmpty(txtImpuestoVenta.Text))
                {

                    MessageBox.Show("El impuesto de venta de la tienda es requerido", "Atencion!");
                    return;
                }

                if (txtNumeroTelefonico.Text.Length != 8 || txtNumeroTelefonico.Text.Contains("-"))
                {
                    MessageBox.Show("El número telefónico de la tienda debe tener 8 digitos y no contener guiones (-)", "Atencion!");
                    return;
                }

                if (!decimal.TryParse(txtImpuestoVenta.Text, out decimal impuesto) || impuesto <= 0)
                {
                    MessageBox.Show("El impuesto de venta de la tienda debe ser un número positivo", "Atención!");
                    return;
                }

                if (txtCedulaJuridica.Text.Length > 50 ||
                   txtNombre.Text.Length > 50 ||
                   txtNumeroTelefonico.Text.Length > 50 ||
                   txtDireccion.Text.Length > 50 ||
                   txtImpuestoVenta.Text.Length > 50)
                {
                    MessageBox.Show("Ningún campo debe exceder los 50 caracteres", "Atención!");
                    return;
                }

                oTienda.CedulaJuridica = txtCedulaJuridica.Text;
                oTienda.Nombre = txtNombre.Text;
                oTienda.Telefono = int.Parse(txtNumeroTelefonico.Text);
                oTienda.Direccion = txtDireccion.Text;
                oTienda.ImpuestoVenta = decimal.Parse(txtImpuestoVenta.Text);

                oTienda = await bllTienda.GuardarTienda(oTienda);
                MessageBox.Show("Datos de la tienda guardados correctamente!", "Exito", MessageBoxButtons.OK);
                this.cambiarEstado(EstadoMantenimiento.Ninguno);
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
                    this.txtNombre.Clear();
                    this.txtCedulaJuridica.Clear();
                    this.txtNumeroTelefonico.Clear();
                    this.txtDireccion.Clear();
                    this.txtImpuestoVenta.Clear();
                    this.btnEliminar.Enabled = true;
                    break;
            }
        }

        private async void CargarDatos()
        {
            IBLLTienda bllTienda = new BLLTienda();
            try
            {
                
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
                MessageBox.Show("Error al cargar los datos",ex.Message);
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
                    this.cambiarEstado(EstadoMantenimiento.Borrar);

                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    Tienda oTienda = this.dgvDatos.SelectedRows[0].DataBoundItem as Tienda;
                    if (MessageBox.Show($"Desea eliminar la tienda con la cedula juridica {oTienda.CedulaJuridica}?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if(tiendaBLL.ValidarTienda(oTienda.IdTienda.ToString()))
                        {
                            MessageBox.Show("No se pudo eliminar la tienda, debido a que tiene otras relaciones asociadas.", "Advertencia", MessageBoxButtons.OK);
                            return;
                        } else
                        {

                        tiendaBLL.EliminarTienda(oTienda.CedulaJuridica.ToString());
                            MessageBox.Show("Tienda eliminada correctamente!", "Exito", MessageBoxButtons.OK);
                        }
                        this.CargarDatos();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una tienda para eliminar", "Atención");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
