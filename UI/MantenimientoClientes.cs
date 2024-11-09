using log4net;
using ProyectoProgramadolll.BLL;
using ProyectoProgramadolll.DTO;
using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Electronics.Extensions;

namespace ProyectoProgramadolll.UI
{
    public partial class MantenimientoClientes : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        private List<Canton> listaCantones;
        private List<Distrito> listaDistritos;

        public MantenimientoClientes()
        {
            InitializeComponent();
        }


        private void MantenimientoClientes_Load(object sender, EventArgs e)
        {
            try
            {
                this.CargarCombosApi();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los combos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CargarCombosApi()
        {
            this.listaCantones = await Utils.ObtenerCantonesAsync();
            this.listaDistritos = await Utils.ObtenerDistritosAsync();
            List<Provincia> provincias = await Utils.ObtenerProvinciasAsync();
            if (provincias != null && provincias.Count > 0)
            {
                cmbProvincia.DataSource = provincias;
                cmbProvincia.DisplayMember = "Descripcion";
                cmbProvincia.ValueMember = "IdProvincia";
            }
            else
            {
                MessageBox.Show("No se pudo cargar las provincias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            AgregarClientes AgregarClientes = new AgregarClientes();
            AgregarClientes.ShowDialog();
        }

        ErrorProvider erp = new ErrorProvider();
        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            BLLPadron bLLPadron = new BLLPadron();
            IBLLPadron _BLLPadron = (IBLLPadron)bLLPadron;

            try
            {
                erp.Clear();

                if (string.IsNullOrEmpty(txtIdentificacion.Text))
                {
                    erp.SetError(txtIdentificacion, "Id Requerido");
                    txtIdentificacion.Focus();
                    return;
                }

                if (txtIdentificacion.Text.Trim().Length != 9)
                {
                    erp.SetError(txtIdentificacion, "Largo de la Cédula 9 digitos");
                    txtIdentificacion.Focus();
                    return;
                }
                string nombreCliente = await Utils.ObtenerNombreClienteHaciendaAsync(txtIdentificacion.Text);
                if(nombreCliente == null)
                {
                    MessageBox.Show("No se encontró el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    txtNombre.Text = nombreCliente;
                }




            }
            catch (Exception er)
            {
                string msg = "";
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.cmbProvincia.SelectedValue is int idProvincia)
            {

                var cantonesFiltrados = listaCantones.Where(c => c.IdProvincia == idProvincia).ToList();
                cmbCanton.DataSource = cantonesFiltrados;
                cmbCanton.DisplayMember = "Descripcion";
                cmbCanton.ValueMember = "IdCanton";

                if (cantonesFiltrados.Count == 0)
                {
                    MessageBox.Show("No se encuentran cantones para esta provicia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.cmbCanton.DataSource = null;
                }
                this.cmbCanton.Enabled = true;
            }
        }

        private void cmbCanton_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbCanton.SelectedValue is int idCanton)
            {

                var distritosFiltrados = listaDistritos.Where(d => d.IdCanton == idCanton).ToList();
                cmbDistrito.DataSource = distritosFiltrados;
                cmbDistrito.DisplayMember = "Descripcion";
                cmbDistrito.ValueMember = "IdDistrito";

                if (distritosFiltrados.Count == 0)
                {
                    MessageBox.Show("No se encuentran distritos para este canton", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.cmbDistrito.DataSource = null;
                }
                this.cmbDistrito.Enabled = true;
            }
        }
    }
}

