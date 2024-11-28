using ProyectoProgramadolll.BLL;
using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Entities.DTO;
using ProyectoProgramadolll.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoProgramadolll.UI
{
    public partial class MantenimientoVendedor : Form
    {
        public MantenimientoVendedor()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

        }

        private void Apellido_Click(object sender, EventArgs e)
        {

        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            IBLLVendedor bllVendedor = new BLLVendedor();

            try
            {
                this.cambiarEstado(EstadoMantenimiento.Nuevo);
                if (string.IsNullOrEmpty(txtCodigoVendedor.Text))
                {
                    MessageBox.Show("El código del vendedor es requerido", "Atencion!"); 
                    return;
                }

                if (string.IsNullOrEmpty(txtContrasegna.Text))
                {
                    
                    MessageBox.Show("La contraseña es requerida", "Atencion!");
                    return;
                }

                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("El nombre del vendedor es requerido", "Atencion!");
                    return;
                }

                if (string.IsNullOrEmpty(txtApellidos.Text))
                {
                    MessageBox.Show("El apellido del vendedor es requerido", "Atencion!");
                    return;
                }

                if (this.ptbFotoVendedor.Tag == null)
                {
                    MessageBox.Show("La Imagen  es un dato requerido !", "Atención");
                    return;
                }

                if (!txtNombre.Text.All(c => Char.IsLetter(c) || Char.IsWhiteSpace(c)) ||
                    !txtApellidos.Text.All(c => Char.IsLetter(c) || Char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("El nombre y apellido solo pueden contener letras y espacios", "Atención");
                    return;
                }


                if (txtNombre.Text.Length > 50 || txtApellidos.Text.Length > 50 || txtCodigoVendedor.Text.Length > 50 || txtContrasegna.Text.Length > 50)
                {
                    MessageBox.Show("Los datos no pueden tener más de 50 caracteres", "Atención");
                    return;
                }

                if (txtContrasegna.Text.Length < 8)
                {
                    MessageBox.Show("La contraseña debe tener al menos 8 caracteres");
                 
                }

                if (txtContrasegna.Text.Trim().Length > 10)
                {
                    MessageBox.Show("La contraseña no puede tener más de 10 caracteres");
                  
                }

                if (dtpFechaNacimiento.Value > DateTime.Now)
                {
                    MessageBox.Show("La fecha de nacimiento no puede ser mayor a la fecha actual", "Atención");
                    return;
                }


                Vendedor vendedor = new Vendedor();

                vendedor.CodigoVendedor = txtCodigoVendedor.Text;
                vendedor.IdRol = ((Rol)cmbRoles.SelectedItem).IdRol.ToString();
                vendedor.Contrasegna = txtContrasegna.Text;
                vendedor.IdTienda = (cmbTiendas.SelectedItem as Tienda).IdTienda;
                vendedor.Nombre = txtNombre.Text;
                vendedor.Apellidos = txtApellidos.Text;
                vendedor.FechaNacimiento = dtpFechaNacimiento.Value;
                vendedor.Estado = rdbActivo.Checked ? true : false;
                vendedor.Fotografia = (byte[])ptbFotoVendedor.Tag;

                vendedor =  bllVendedor.GuardarVendedor(vendedor);
                MessageBox.Show("Datos del Vendedor guardados correctamente!", "Exito", MessageBoxButtons.OK);
                this.cambiarEstado(EstadoMantenimiento.Ninguno);
                this.CargarDatos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el vendedor", ex.Message);
            }

        }

        private void cambiarEstado(EstadoMantenimiento estadoMantenimiento)
        {
            this.btnCancelar.Enabled = false;
            

            switch (estadoMantenimiento)
            {
                case EstadoMantenimiento.Nuevo:
                    this.txtCodigoVendedor.Enabled = true;
                    this.txtNombre.Enabled = true;
                    this.txtApellidos.Enabled = true;
                    this.dtpFechaNacimiento.Enabled = true;
                    this.rdbActivo.Enabled = true;
                    this.rdbNoActivo.Enabled = true;
                    this.cmbRoles.Enabled = true;
                    this.cmbTiendas.Enabled = true;
                    this.ptbFotoVendedor.Enabled = true;
                    this.btnGuardar.Enabled = true;
                    this.btnEliminar.Enabled = false;
                    this.btnCancelar.Enabled = true;
                    break;
                case EstadoMantenimiento.Editar:
                    this.txtCodigoVendedor.Enabled = false;
                    this.txtCodigoVendedor.Focus();
                    this.txtNombre.Enabled = true;
                    this.txtApellidos.Enabled = true;
                    this.dtpFechaNacimiento.Enabled = true;
                    this.rdbActivo.Enabled = true;
                    this.rdbNoActivo.Enabled = true;
                    this.cmbRoles.Enabled = true;
                    this.cmbTiendas.Enabled = true;
                    this.ptbFotoVendedor.Enabled = true;
                    this.btnGuardar.Enabled = true;
                    this.btnEliminar.Enabled = false;
                    this.btnCancelar.Enabled = true;
                    break;
                case EstadoMantenimiento.Borrar:
                    break;
                case EstadoMantenimiento.Ninguno:
                    this.txtCodigoVendedor.Enabled = true;
                    this.btnEliminar.Enabled = true;
                    this.txtCodigoVendedor.Clear();
                    this.txtContrasegna.Clear();
                    this.cmbRoles.SelectedIndex = 0;
                    this.cmbTiendas.SelectedIndex = 0;
                    this.txtNombre.Clear();
                    this.txtApellidos.Clear();
                    this.dtpFechaNacimiento.Value = DateTime.Now;
                    this.rdbActivo.Checked = true;
                    this.rdbNoActivo.Checked = false;
                    this.ptbFotoVendedor.Image = null;
                    this.ptbFotoVendedor.Tag = null;
                    break;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog opt = new OpenFileDialog();
            opt.Title = "Seleccione la Imagen ";
            opt.SupportMultiDottedExtensions = true;
            opt.DefaultExt = "*.jpg";
            opt.Filter = "Archivos de Imagenes (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png| All files (*.*)|*.*";
            opt.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            opt.FileName = "";

            if (opt.ShowDialog(this) == DialogResult.OK)
            {
                string extension = Path.GetExtension(opt.FileName).ToLower();
                if (extension == ".jpg" || extension == ".jpeg" || extension == ".png")
                {
                    this.ptbFotoVendedor.ImageLocation = opt.FileName;
                    ptbFotoVendedor.SizeMode = PictureBoxSizeMode.StretchImage;

                    byte[] cadenaBytes = File.ReadAllBytes(opt.FileName);

                    ptbFotoVendedor.Tag = cadenaBytes;
                }
                else
                {
                    MessageBox.Show("Solo se permiten archivos con extensión .jpg, .jpeg o .png", "Formato no permitido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void CargarDatos()
        {
            IBLLVendedor bllVendedor = new BLLVendedor();
            IBLLRol bllRol;
            IBLLTienda bllTienda;

            List<Rol> listaRol;
            List<Tienda> listaTienda;
            try
            {
                bllRol = new BLLRol();
                bllTienda = new BLLTienda();

                

                listaRol =  bllRol.ObtenerRoles();
                listaTienda = (await bllTienda.ObtenerTodasLasTiendas()).ToList();

                cmbRoles.DataSource = listaRol;
                cmbRoles.DisplayMember = "DescripcionRol"; 
                cmbRoles.ValueMember = "IdRol";

                cmbTiendas.DataSource = listaTienda;
                cmbTiendas.DisplayMember = "Nombre"; 
                cmbTiendas.ValueMember = "IdTienda";

                dgvDatos.AutoGenerateColumns = false;
                dgvDatos.RowTemplate.Height = 100;
                dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                this.ptbFotoVendedor.Enabled = false;

                this.dgvDatos.DataSource = bllVendedor.ObtenerVendedores();

                this.ptbFotoVendedor.SizeMode = PictureBoxSizeMode.CenterImage;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos", ex.Message);
            }
        }



        private void MantenimientoVendedor_Load(object sender, EventArgs e)
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            VendedorDTO oVendedor = null;
            if (this.dgvDatos.SelectedRows.Count > 0)
            {
                this.cambiarEstado(EstadoMantenimiento.Editar);
                oVendedor = (VendedorDTO)this.dgvDatos.SelectedRows[0].DataBoundItem as VendedorDTO;

                this.txtCodigoVendedor.Text = oVendedor.CodigoVendedor;
                this.txtContrasegna.Text = oVendedor.Contrasegna;
                this.cmbRoles.SelectedValue = oVendedor.IdRol;
                this.cmbTiendas.SelectedValue = oVendedor.IdTienda;
                this.txtNombre.Text = oVendedor.Nombre;
                this.txtApellidos.Text = oVendedor.Apellidos;
                this.dtpFechaNacimiento.Value = oVendedor.FechaNacimiento;
                this.rdbActivo.Checked = oVendedor.EstadoDescripcion == "Activo";
                this.rdbNoActivo.Checked = oVendedor.EstadoDescripcion != "Activo";
                this.ptbFotoVendedor.Image = Image.FromStream(new MemoryStream(oVendedor.Fotografia));
                this.ptbFotoVendedor.Tag = oVendedor.Fotografia;
                this.ptbFotoVendedor.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un vendedor para editar", "Atención");
            }

        }

        private  void btnCancelar_Click(object sender, EventArgs e)
        {
            this.cambiarEstado(EstadoMantenimiento.Ninguno);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            IBLLVendedor bllVendedor = new BLLVendedor();
            try
            {
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    VendedorDTO oVendedor = (VendedorDTO)this.dgvDatos.SelectedRows[0].DataBoundItem as VendedorDTO;
                    if (MessageBox.Show("¿Está seguro de eliminar el vendedor?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool eliminado = await bllVendedor.EliminarVendedor(oVendedor.CodigoVendedor.ToString());
                        if (eliminado) {

                        MessageBox.Show("Vendedor eliminado correctamente!", "Exito", MessageBoxButtons.OK);
                        this.CargarDatos();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el vendedor, debido a que tiene otras relaciones asociadas.", "Advertencia", MessageBoxButtons.OK);
                            return;
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Debe seleccionar un vendedor para eliminar", "Atención");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el vendedor", ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
