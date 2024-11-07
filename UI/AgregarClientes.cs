using ProyectoProgramadolll.BLL;
using ProyectoProgramadolll.DAL;
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
using Newtonsoft.Json;
using System.Net.Http;
using ProyectoProgramadolll.Entities;


namespace ProyectoProgramadolll.UI
{
    public partial class AgregarClientes : Form
    {
        private readonly ProvinciaBLL _provinciaBLL;
        public AgregarClientes()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.AgregarClientes_Load);
            _provinciaBLL = new ProvinciaBLL(new ProvinciaDAL());

        }

        private async void AgregarClientes_Load(object sender, EventArgs e)
        {
            try
            {
                var provincias = await _provinciaBLL.ObtenerProvincias();

                if (provincias == null || provincias.Count == 0)
                {
                    MessageBox.Show("No se encontraron provincias.");
                    return;
                }

                cmbProvincia.DataSource = provincias;
                cmbProvincia.DisplayMember = "Descripcion";
                cmbProvincia.ValueMember = "IdProvincia";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar provincias: {ex.Message}");
            }
        }

        private async void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            var provinciaSeleccionada = (Provincia)cmbProvincia.SelectedItem;


            var cantones = await _provinciaBLL.ObtenerCantones();
            var cantonesFiltrados = cantones.Where(c => c.IdProvincia == provinciaSeleccionada.IdProvincia).ToList();

            cmbCanton.DataSource = cantonesFiltrados;
            cmbCanton.DisplayMember = "Descripcion";
            cmbCanton.ValueMember = "IdCanton";
        }

        private async void cmbCanton_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cantonSeleccionado = (Canton)cmbCanton.SelectedItem;

            var distritos = await _provinciaBLL.ObtenerDistritos();
            var distritosFiltrados = distritos.Where(d => d.IdCanton == cantonSeleccionado.IdCanton).ToList();

            cmbDistrito.DataSource = distritosFiltrados;
            cmbDistrito.DisplayMember = "Descripcion";
            cmbDistrito.ValueMember = "IdDistrito";
        }

        private void btnSegundoApellido_Click(object sender, EventArgs e)
        {
           // btnSegundoApellido.Visible = true;
            //lbl2ndApellido.Visible = true;
        }
    }
}
