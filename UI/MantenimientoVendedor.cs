using ProyectoProgramadolll.BLL;
using ProyectoProgramadolll.Entities;
using ProyectoProgramadolll.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            IBLLVendedor bLLVendedor = new BLLVendedor();

            try
            {
                if (string.IsNullOrEmpty(txtCodigoVendedor.Text))
                {
                    txtCodigoVendedor.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtContrasegna.Text))
                {
                    txtContrasegna.Focus();
                    return;
                }

                if (this.ptbFotoVendedor.Tag == null)
                {
                    MessageBox.Show("La Imagen  es un dato requerido !", "Atención");
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

                vendedor = bLLVendedor.GuardarVendedor(vendedor);

                this.CargarDatos();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el vendedor", ex.Message);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog opt = new OpenFileDialog();
            opt.Title = "Seleccione la Imagen ";
            opt.SupportMultiDottedExtensions = true;
            opt.DefaultExt = "*.jpg";
            opt.Filter = "Archivos de Imagenes (*.jpg)|*.jpg| All files (*.*)|*.*";
            opt.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            opt.FileName = "";

            if (opt.ShowDialog(this) == DialogResult.OK)
            {

                //ruta = opt.FileName.Trim();
                this.ptbFotoVendedor.ImageLocation = opt.FileName;
                ptbFotoVendedor.SizeMode = PictureBoxSizeMode.StretchImage;

                byte[] cadenaBytes = File.ReadAllBytes(opt.FileName);

                // Guarla la imagenen Bytes en el Tag de la imagen.
                ptbFotoVendedor.Tag = (byte[])cadenaBytes;


            }
        }

        private async void CargarDatos()
        {
            IBLLVendedor bLLVendedor = new BLLVendedor();
            IBLLRol bLLRol;
            IBLLTienda bLLTienda;

            List<Rol> listaRol;
            List<Tienda> listaTienda;
            try
            {
                bLLRol = new BLLRol();
                bLLTienda = new BLLTienda();

                // cambiar estado a ninguno

                listaRol = bLLRol.ObtenerRoles();
                listaTienda = (await bLLTienda.ObtenerTodasLasTiendas()).ToList();


                foreach (var item in listaRol)
                {
                    cmbRoles.Items.Add(item);
                }

                foreach (var item in listaTienda)
                {
                    cmbTiendas.Items.Add(item);
                }

                if (cmbRoles.Items.Count > 0)
                    this.cmbRoles.SelectedIndex = 0;

                if (cmbTiendas.Items.Count > 0)
                    this.cmbTiendas.SelectedIndex = 0;

                dgvDatos.AutoGenerateColumns = false;
                dgvDatos.RowTemplate.Height = 100;
                dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                this.ptbFotoVendedor.Enabled = false;

                this.dgvDatos.DataSource = bLLVendedor.ObtenerVendedores();

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
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos", ex.Message);
            }
        }
    }
}
