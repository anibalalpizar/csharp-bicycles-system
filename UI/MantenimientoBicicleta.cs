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
    public partial class MantenimientoBicicleta : Form
    {
        private Vendedor vendedor;

        public MantenimientoBicicleta(Vendedor oVendedor)
        {
            InitializeComponent();
            this.vendedor = oVendedor;
        }


        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            IBLLBicicleta bllBicicleta = new BLLBicicleta();

            try
            {
                Bicicleta bicicleta = new Bicicleta();


                if (string.IsNullOrEmpty(txtNumeroSerie.Text))
                {
                    MessageBox.Show("El número de serie es requerido");
                    return;
                }

                if (string.IsNullOrEmpty(txtMarca.Text))
                {
                    MessageBox.Show("La marca es requerida");
                    return;
                }

                if (string.IsNullOrEmpty(txtModelo.Text))
                {
                    MessageBox.Show("El modelo es requerido");
                    return;
                }

                if (string.IsNullOrEmpty(txtColor.Text))
                {
                    MessageBox.Show("El color es requerido");
                    return;
                }

                //if (this.dgvDatos.Rows.Count > 0)
                //{
                //    foreach (DataGridViewRow row in this.dgvDatos.Rows)
                //    {
                //        if (row.Cells[0].Value.ToString() == txtNumeroSerie.Text)
                //        {
                //            MessageBox.Show("El número de serie ya existe");
                //            return;
                //        }
                //    }
                //}

                bicicleta.NumeroSerie = txtNumeroSerie.Text;
                bicicleta.IdCliente = ((ClienteDTO)cmbClientes.SelectedItem).IdCliente;
                bicicleta.Marca = txtMarca.Text;
                bicicleta.Modelo = txtModelo.Text;
                bicicleta.Color = txtColor.Text;

                bicicleta = await bllBicicleta.GuardarBicicleta(bicicleta);

                if (bicicleta != null)
                    CargarDatos(vendedor);

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

        private async void CargarDatos(Vendedor vendedor)
        {
            IBLLBicicleta bLLBicicleta = new BLLBicicleta();
            CargarClientes();
            dgvDatos.AutoGenerateColumns = false;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            if (vendedor.IdRol == "1")
            {
                try
                {

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
                   this.dgvDatos.DataSource = await bLLBicicleta.ObtenerBicicletasPorVendedor(vendedor.IdVendedor);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            IBLLBicicleta bllBicicleta = new BLLBicicleta();

            try
            {
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    // cambiar estado a borrar

                    BicicletaDTO oBicicleta = this.dgvDatos.SelectedRows[0].DataBoundItem as BicicletaDTO;
                    if (MessageBox.Show($"¿Está seguro de eliminar la bicicleta con número de serie {oBicicleta.NumeroSerie}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bllBicicleta.EliminarBicicleta(oBicicleta.IdBicicleta.ToString());
                        this.CargarDatos(vendedor);
                    }
                    else
                    {
                        MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
