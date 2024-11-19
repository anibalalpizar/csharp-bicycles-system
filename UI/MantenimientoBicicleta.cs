using ProyectoProgramadolll.BLL;
using ProyectoProgramadolll.DAL;
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
    public partial class MantenimientoBicicleta : Form
    {
        private VendedorClienteDTO vendedor;

        public MantenimientoBicicleta(VendedorClienteDTO oVendedor)
        {
            InitializeComponent();
            this.vendedor = oVendedor;
        }


        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            IBLLBicicleta bllBicicleta = new BLLBicicleta();

            try
            {
                this.cambiarEstado(EstadoMantenimiento.Nuevo);
                Bicicleta bicicleta = new Bicicleta();


                if (string.IsNullOrEmpty(txtNumeroSerie.Text) )
                {
                    MessageBox.Show("El número de serie es requerido", "Atención!");
                    return;
                }

                if (string.IsNullOrEmpty(txtMarca.Text))
                {
                    MessageBox.Show("La marca es requerida", "Atención!");
                    return;
                }

                if (string.IsNullOrEmpty(txtModelo.Text))
                {
                    MessageBox.Show("El modelo es requerido", "Atención!");
                    return;
                }

                if (string.IsNullOrEmpty(txtColor.Text))
                {
                    MessageBox.Show("El color es requerido", "Atención!");
                    return;
                }

                if (!txtColor.Text.All(char.IsLetter))
                {
                    MessageBox.Show("El campo color solo acepta letras", "Atención!");
                    return;
                }

                if (!txtColor.Text.All(c => Char.IsLetter(c)))
                {
                    MessageBox.Show("El color solamente pueden contener letras y espacios", "Atención");
                    return;
                }


                if (txtNumeroSerie.Text.Length > 50 || txtMarca.Text.Length > 50 || txtModelo.Text.Length > 50 || txtColor.Text.Length > 50)
                {
                    MessageBox.Show("Los campos no pueden superar los 50 caracteres", "Atención!");
                    return;
                }

                bicicleta.NumeroSerie = txtNumeroSerie.Text;
                bicicleta.IdCliente = ((ClienteDTO)cmbClientes.SelectedItem).IdCliente;
                bicicleta.Marca = txtMarca.Text;
                bicicleta.Modelo = txtModelo.Text;
                bicicleta.Color = txtColor.Text;

                bicicleta = await bllBicicleta.GuardarBicicleta(bicicleta);

                if (bicicleta != null)
                {
                    CargarDatos(vendedor);
                    MessageBox.Show("Datos de la bicicleta guardados correctamente!", "Exito", MessageBoxButtons.OK);
                    this.cambiarEstado(EstadoMantenimiento.Ninguno);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MantenimientoBicicleta_Load(object sender, EventArgs e)
        {
            CargarDatos(vendedor);
        }

        private void CargarClientes()
        {
            IBLLClientes bLLClientes = new BLLClientes();
            List<ClienteDTO> lista = null;

            this.cmbClientes.Items.Clear();

            lista = bLLClientes.ObtenerClientes();

            foreach (ClienteDTO cliente in lista)
            {
                this.cmbClientes.Items.Add(cliente);
            }

            this.cmbClientes.SelectedIndex = 0;
        }

        private async void CargarDatos(VendedorClienteDTO vendedor)
        {
            IBLLBicicleta bLLBicicleta = new BLLBicicleta();
            CargarClientes();
            dgvDatos.AutoGenerateColumns = false;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            if (vendedor.IdRol == 1 || vendedor.IdRol == 2)
            {
                try
                {
                    
                    this.lblTitulo.Visible = false;
                    this.dgvDatos.DataSource = await bLLBicicleta.ObtenerBicicletas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    this.btnEliminar.Visible = false;
                    this.btnModificar.Visible = false;
                    this.btnGuardar.Visible = false;
                    this.cmbClientes.Visible = false;
                    this.btnCancelar.Visible = false;
                    this.txtNumeroSerie.Visible = false;
                    this.lblNumeroSerie.Visible = false;
                    this.lblMarca.Visible = false;
                    this.txtMarca.Visible = false;
                    this.lblModelo.Visible = false;
                    this.txtModelo.Visible = false;
                    this.lblColor.Visible = false;
                    this.txtColor.Visible = false;
                    this.lblColor.Visible = false;
                    this.txtColor.Visible = false;
                    this.lblColor.Visible = false;
                    this.txtColor.Visible = false;
                    this.lblClienteBicicleta.Visible = false;
                    this.cmbClientes.Visible = false;
                    this.lblTitulo.Visible = true;

                    this.dgvDatos.DataSource = await bLLBicicleta.ObtenerBicicletasPorVendedor(vendedor.IdCliente);
                  
               
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cambiarEstado(EstadoMantenimiento estadoMantenimiento)
        {
            this.btnCancelar.Enabled = false;
            
            switch (estadoMantenimiento)
            {
                case EstadoMantenimiento.Nuevo:
                    this.btnGuardar.Enabled = true;
                    this.txtNumeroSerie.Enabled = true;
                    this.btnEliminar.Enabled = false;
                    this.btnCancelar.Enabled = true;
                    break;
                case EstadoMantenimiento.Editar:
                    this.txtNumeroSerie.Enabled = false;
                    this.cmbClientes.Enabled = true;
                    this.btnGuardar.Enabled = true;
                    this.btnEliminar.Enabled = false;
                    this.btnCancelar.Enabled = true;
                    break;
                case EstadoMantenimiento.Borrar:
                    break;
                case EstadoMantenimiento.Ninguno:
                    this.txtNumeroSerie.Enabled = true;
                    this.txtNumeroSerie.Clear();
                    this.btnEliminar.Enabled = true;
                    this.txtMarca.Clear();
                    this.txtColor.Clear();
                    this.txtModelo.Clear();
                    break;
            }
        }


        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            IBLLBicicleta bllBicicleta = new BLLBicicleta();

            try
            {
                if (this.dgvDatos.SelectedRows.Count > 0)
                {

                    this.cambiarEstado(EstadoMantenimiento.Borrar);

                    BicicletaDTO oBicicleta = this.dgvDatos.SelectedRows[0].DataBoundItem as BicicletaDTO;
                    if (MessageBox.Show($"¿Está seguro de eliminar la bicicleta con número de serie {oBicicleta.NumeroSerie}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        bool eliminado = await bllBicicleta.EliminarBicicleta(oBicicleta.IdBicicleta.ToString());
                        if (eliminado)
                        {
                            MessageBox.Show("Bicicleta eliminada correctamente!", "Exito", MessageBoxButtons.OK);
                            this.CargarDatos(vendedor);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar la bicicleta, debido a que tiene otras relaciones asociadas.", "Advertencia", MessageBoxButtons.OK);
                            return;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            BicicletaDTO bicicleta = new BicicletaDTO();
            try
            {
                this.cambiarEstado(EstadoMantenimiento.Editar);
                if (this.dgvDatos.SelectedRows.Count > 0)
                {

                    bicicleta = this.dgvDatos.SelectedRows[0].DataBoundItem as BicicletaDTO;
                    txtNumeroSerie.Text = bicicleta.NumeroSerie;
                    txtMarca.Text = bicicleta.Marca;
                    txtModelo.Text = bicicleta.Modelo;
                    txtColor.Text = bicicleta.Color;
                    cmbClientes.SelectedIndex = cmbClientes.FindString(bicicleta.NombreCliente);
                }
                else
                {
                    MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pnlForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.cambiarEstado(EstadoMantenimiento.Ninguno);
        }
    }
}
