using log4net;
using ProyectoProgramadolll.BLL;
using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Entities.DTO;
using ProyectoProgramadolll.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using UTN.Winform.Electronics.Extensions;

namespace ProyectoProgramadolll.UI
{
    public partial class MantenimientoClientes : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        private List<Provincia> listProvincias;
        private List<Canton> listaCantones;
        private List<Distrito> listaDistritos;
        private IList<Telefono> listaTelefonos = new List<Telefono>();


        public MantenimientoClientes()
        {
            InitializeComponent();
        }


        private void MantenimientoClientes_Load(object sender, EventArgs e)
        {
            try
            {
                this.CargarCombosApi();
                this.CargarDatos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los combos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CargarCombosApi()
        {
            this.listProvincias = await Utils.ObtenerProvinciasAsync();
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

        private async void CargarDatos()
        {
            IBLLClientes bllClientes = new BLLClientes();
            IBLLTipoIdentificacion bllTipo;

            List<TipoIdentificacion> listaTipoIdentificacion;
            try
            {
                bllTipo = new BLLTipoIdentificacion();

                listaTipoIdentificacion = bllTipo.ObtenerTipoIdentificacion();

                cmbTipo.DataSource = listaTipoIdentificacion;
                cmbTipo.DisplayMember = "Descripcion";
                cmbTipo.ValueMember = "IdTipoIdentificacion";

                dgvDatos.AutoGenerateColumns = false;
                dgvDatos.RowTemplate.Height = 100;
                dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                this.dgvDatos.DataSource = bllClientes.ObtenerClientes();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos", ex.Message);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            IBLLClientes bllClientes = new BLLClientes();
            int idCliente;
            try
            {

                this.cambiarEstado(EstadoMantenimiento.Nuevo);
                if (cmbTipo.SelectedIndex == 1)
                {
                    if (txtIdentificacion.Text.Length != 7 || !Char.IsLetter(txtIdentificacion.Text[0]) || !txtIdentificacion.Text.Substring(1).All(Char.IsDigit))
                    {
                        MessageBox.Show("El pasaporte debe tener 1 letra y 6 dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (string.IsNullOrWhiteSpace(txtIdentificacion.Text))
                {
                    MessageBox.Show("La identificacion es obligatoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (string.IsNullOrWhiteSpace(txtContrasegna.Text))
                {
                    MessageBox.Show("La contraseña es obligatoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (!rdbFemenino.Checked && !rdbMasculino.Checked)
                {
                    MessageBox.Show("Debe seleccionar el sexo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCorreoElectronico.Text))
                {
                    MessageBox.Show("El correo electrónico es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                var emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                if (!Regex.IsMatch(txtCorreoElectronico.Text, emailPattern))
                {
                    MessageBox.Show("El formato del correo electrónico es inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (cmbProvincia.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una provincia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cmbCanton.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un cantón", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cmbDistrito.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un distrito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (lstTelefonos.Items.Count == 0)
                {
                    MessageBox.Show("Debe agregar al menos un número de teléfono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtIdentificacion.Text.Length > 50 ||
                    txtNombre.Text.Length > 50 ||
                    txtCorreoElectronico.Text.Length > 50)
                {
                    MessageBox.Show("Ningún campo debe exceder los 50 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

               


                ClienteDTO oCliente = new ClienteDTO();
                Direccion oDireccion = new Direccion();
                oCliente.Identificacion = txtIdentificacion.Text;
                oCliente.IdTipoIdentificacion = (int)cmbTipo.SelectedValue;
                oCliente.Nombre = txtNombre.Text;
                oCliente.Sexo = rdbFemenino.Checked ? true : false;
                oCliente.CorreoElectronico = txtCorreoElectronico.Text;
                oCliente.Contrasegna = txtContrasegna.Text;
                oCliente.Estado = rdbActivo.Checked ? true : false;

                if (int.TryParse(lblCliente.Text, out idCliente))
                {
                    oCliente.IdCliente = idCliente;
                }
                else
                {
                    oCliente.IdCliente = 0;
                }

                oDireccion.IdProvincia = (int)cmbProvincia.SelectedValue;
                oDireccion.IdCanton = (int)cmbCanton.SelectedValue;
                oDireccion.IdDistrito = (int)cmbDistrito.SelectedValue;
                oDireccion.DescripcionProvincia = cmbProvincia.Text;
                oDireccion.DescripcionCanton = cmbCanton.Text;
                oDireccion.DescripcionDistrito = cmbDistrito.Text;


                List<Telefono> listaTelefonos = new List<Telefono>();

                foreach (ListViewItem item in lstTelefonos.Items)
                {
                    var telefono = new Telefono
                    {
                        NumeroTelefonico = item.SubItems[0].Text
                    };

                    listaTelefonos.Add(telefono);
                }

                oCliente.ListaTelefonos = listaTelefonos;




                oCliente = bllClientes.GuardarCliente(oCliente, oDireccion, listaTelefonos);
                MessageBox.Show("Datos del Cliente guardados correctamente!", "Exito", MessageBoxButtons.OK);
                this.cambiarEstado(EstadoMantenimiento.Ninguno);
                this.CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el cliente ", "Identificacion ya registrada");
            }


        }

        private void cambiarEstado(EstadoMantenimiento estadoMantenimiento)
        {
            this.btnCancelar.Enabled = false;




            switch (estadoMantenimiento)
            {
                case EstadoMantenimiento.Nuevo:
                    this.cmbTipo.Enabled = true;
                    this.btnCrear.Enabled = true;
                    this.txtIdentificacion.Enabled = true;
                    this.btnEliminar.Enabled = false;
                    this.btnCancelar.Enabled = true;
                    break;
                case EstadoMantenimiento.Editar:
                    this.txtIdentificacion.Enabled = false;
                    txtNumeroTelefonico.Clear();
                    this.cmbTipo.Enabled = true;
                    this.cmbCanton.Enabled = true;
                    this.cmbDistrito.Enabled = true;
                    this.btnCrear.Enabled = true;
                    this.btnEliminar.Enabled = false;
                    this.btnCancelar.Enabled = true;
                    this.lstTelefonos.Clear();
                    this.listaTelefonos.Clear();
                    ActualizarListView();

                    break;
                case EstadoMantenimiento.Borrar:
                    break;
                case EstadoMantenimiento.Ninguno:
                    this.txtIdentificacion.Enabled = true;
                    txtIdentificacion.Clear();
                    this.btnEliminar.Enabled = true;
                    this.txtNumeroTelefonico.Clear();
                    this.txtNombre.Clear();
                    this.txtCorreoElectronico.Clear();
                    this.cmbCanton.DataSource = null;
                    this.cmbDistrito.DataSource = null;
                    this.rdbFemenino.Checked = false;
                    this.rdbMasculino.Checked = false;
                    this.lstTelefonos.Clear();
                    this.listaTelefonos.Clear();
                    this.txtContrasegna.Clear();
                    this.lblCliente.Text = "";
                    break;
            }
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
                if (nombreCliente == null)
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
            string numeroTelefono = txtNumeroTelefonico.Text.Trim();

            if (string.IsNullOrEmpty(numeroTelefono))
            {
                MessageBox.Show("Por favor ingresa un número de teléfono.");
                return;
            }

            if (numeroTelefono.Length != 8)
            {
                MessageBox.Show("Por favor ingresa un número de teléfono válido (8 dígitos).");
                return;
            }

            Telefono telefono = new Telefono
            {
                NumeroTelefonico = numeroTelefono
            };

            listaTelefonos.Add(telefono);

            txtNumeroTelefonico.Clear();

            ActualizarListView();

            MessageBox.Show("Recuerda guardar tus cambios!", "Número de teléfono agregado correctamente.", MessageBoxButtons.OK);

        }

        private void ActualizarListView()
        {
            lstTelefonos.Items.Clear();

            foreach (var telefono in listaTelefonos)
            {
                ListViewItem item = new ListViewItem(telefono.NumeroTelefonico);
                lstTelefonos.Items.Add(item);
            }
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void lblTipoIdentificacion_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            IBLLClientes bllCliente = new BLLClientes();
            try
            {
                this.cambiarEstado(EstadoMantenimiento.Borrar);
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    ClienteDTO oCliente = (ClienteDTO)this.dgvDatos.SelectedRows[0].DataBoundItem as ClienteDTO;
                    if (MessageBox.Show("¿Está seguro de eliminar el cliente?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (bllCliente.ValidarCliente(oCliente.IdCliente.ToString()))
                        {
                            MessageBox.Show("No se pudo eliminar el cliente, debido a que tiene otras relaciones asociadas.", "Advertencia", MessageBoxButtons.OK);
                            return;
                        }
                        else
                        {

                            bllCliente.EliminarCliente(oCliente.Identificacion);
                            MessageBox.Show("Cliente eliminado correctamente!", "Exito", MessageBoxButtons.OK);
                        }
                        this.CargarDatos();
                    }

                }
                else
                {
                    MessageBox.Show("Debe seleccionar un cliente para eliminar", "Atención");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente", ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.cambiarEstado(EstadoMantenimiento.Ninguno);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ClienteDTO oCliente = null;
            if (this.dgvDatos.SelectedRows.Count > 0)
            {
                this.cambiarEstado(EstadoMantenimiento.Editar);
                oCliente = (ClienteDTO)this.dgvDatos.SelectedRows[0].DataBoundItem as ClienteDTO;

                this.txtIdentificacion.Text = oCliente.Identificacion;
                this.cmbTipo.SelectedValue = oCliente.IdTipoIdentificacion;
                this.txtNombre.Text = oCliente.Nombre;
                this.rdbMasculino.Checked = oCliente.Genero == "Masculino";
                this.rdbFemenino.Checked = oCliente.Genero != "Masculino";
                this.txtCorreoElectronico.Text = oCliente.CorreoElectronico;
                this.lblCliente.Text = oCliente.IdCliente.ToString();
                this.rdbActivo.Checked = oCliente.EstadoDescripcion == "Activo";
                this.rdbNoActivo.Checked = oCliente.EstadoDescripcion != "Activo";
                this.txtContrasegna.Text = oCliente.Contrasegna;

                if (oCliente.DireccionCompleta != null)
                {

                    string provincia = oCliente.DireccionCompleta.Split(',')[0].Trim();
                    string canton = oCliente.DireccionCompleta.Split(',')[1].Trim();
                    string distrito = oCliente.DireccionCompleta.Split(',')[2].Trim();


                    cmbProvincia.DataSource = this.listProvincias;
                    cmbProvincia.DisplayMember = "Descripcion";
                    cmbProvincia.ValueMember = "IdProvincia";

                    cmbCanton.DataSource = listaCantones;
                    cmbCanton.DisplayMember = "Descripcion";
                    cmbCanton.ValueMember = "IdCanton";

                    cmbDistrito.DataSource = listaDistritos;
                    cmbDistrito.DisplayMember = "Descripcion";
                    cmbDistrito.ValueMember = "IdDistrito";

                    var provinciaSeleccionada = listProvincias.FirstOrDefault(p => p.Descripcion == provincia);
                    if (provinciaSeleccionada != null)
                    {
                        cmbProvincia.SelectedValue = provinciaSeleccionada.IdProvincia;

                        var cantonSeleccionado = listaCantones.FirstOrDefault(c => c.Descripcion == canton && c.IdProvincia == provinciaSeleccionada.IdProvincia);
                        if (cantonSeleccionado != null)
                        {
                            cmbCanton.SelectedValue = cantonSeleccionado.IdCanton;

                            var distritoSeleccionado = listaDistritos.FirstOrDefault(d => d.Descripcion == distrito && d.IdCanton == cantonSeleccionado.IdCanton);
                            if (distritoSeleccionado != null)
                            {
                                cmbDistrito.SelectedValue = distritoSeleccionado.IdDistrito;
                            }
                        }
                    }
                }

                this.lstTelefonos.Items.Clear();

                foreach (var telefono in oCliente.ListaTelefonos)
                {
                    ListViewItem item = new ListViewItem(telefono.NumeroTelefonico);
                    this.listaTelefonos.Add(telefono);
                    this.lstTelefonos.Items.Add(item);
                }


            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente para editar", "Atención");
            }
        }




        private void btnEliminarTelefono_Click(object sender, EventArgs e)
        {

            if (this.lstTelefonos.SelectedItems.Count > 0)
            {
                ListViewItem item = (ListViewItem)lstTelefonos.SelectedItems[0];

                string numeroTelefono = item.SubItems[0].Text;

                var telefono = listaTelefonos.FirstOrDefault(t => t.NumeroTelefonico == numeroTelefono);

                if (telefono != null)
                {
                    listaTelefonos.Remove(telefono);
                }

                this.lstTelefonos.Items.Remove(item);
                this.txtNumeroTelefonico.Clear();
                MessageBox.Show("Recuerda guardar tus cambios!", "Número de teléfono eliminado correctamente.", MessageBoxButtons.OK);

            }
        }

        private void btnEditarTelefono_Click(object sender, EventArgs e)
        {
            if (this.lstTelefonos.SelectedItems.Count > 0)
            {
                if (txtNumeroTelefonico.Text.Length != 8)
                {
                    MessageBox.Show("Por favor ingresa un número de teléfono válido (8 dígitos).");
                    return;
                }

                ListViewItem item = (ListViewItem)this.lstTelefonos.SelectedItems[0];
                item.Text = this.txtNumeroTelefonico.Text;
                this.txtNumeroTelefonico.Clear();
                MessageBox.Show("Recuerda guardar tus cambios!", "Número de teléfono editado correctamente.", MessageBoxButtons.OK);
            }



        }

        private void lstTelefonos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            if (this.lstTelefonos.SelectedItems.Count > 0)
            {
                ListViewItem item = (ListViewItem)this.lstTelefonos.SelectedItems[0];
                this.txtNumeroTelefonico.Text = item.Text;
            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbTipo.SelectedIndex == 1)
            {
                this.txtNombre.Enabled = true;
                this.btnBuscar.Enabled = false;
            }
            else
            {
                this.txtNombre.Enabled = false;
                this.btnBuscar.Enabled = true;
            }
        }
    }
}

