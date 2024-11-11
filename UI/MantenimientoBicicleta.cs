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
        public MantenimientoBicicleta()
        {
            InitializeComponent();
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

                bicicleta.NumeroSerie = txtNumeroSerie.Text;
                bicicleta.Marca = txtMarca.Text;
                //bicicleta

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MantenimientoBicicleta_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private async void CargarDatos()
        {
            IBLLClientes bLLClientes = new BLLClientes();
            List<ClienteDTO> lista = null;

            try
            {
                this.cmbClientes.Items.Clear();
                lista = bLLClientes.ObtenerClientes();
                foreach (ClienteDTO cliente in lista)
                {
                    this.cmbClientes.Items.Add(cliente);
                }

                this.cmbClientes.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
