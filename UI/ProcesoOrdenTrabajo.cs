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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgramadolll.UI
{
    public partial class ProcesoOrdenTrabajo : Form
    {
        private Dictionary<string, Image> fotos = new Dictionary<string, Image>();
        private bool isDrawing = false;
        private Point lastPoint;
        private Bitmap firmaBitmap;
        private VendedorClienteDTO vendedor = null;
        public ProcesoOrdenTrabajo(VendedorClienteDTO vendedor)
        {
            InitializeComponent();
            InicializarPanelFirma();
            this.vendedor = vendedor;
        }
        private void InicializarPanelFirma()
        {
            pnlFirma.BackColor = Color.White;
            pnlFirma.BorderStyle = BorderStyle.FixedSingle;

            firmaBitmap = new Bitmap(pnlFirma.Width, pnlFirma.Height);

            pnlFirma.MouseDown += pnlFirma_MouseDown;
            pnlFirma.MouseMove += pnlFirma_MouseMove;
            pnlFirma.MouseUp += pnlFirma_MouseUp;

            using (Graphics g = Graphics.FromImage(firmaBitmap))
            {
                g.Clear(Color.White);
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string bicicletaSeleccionada = this.cmbBicicletas.Text;
                string servicioSeleccionado = this.cmbServicio.Text;
                string descripcion = this.txaDescripcion.Text;

                this.lstDetalles.Items.Add($"{bicicletaSeleccionada} - {servicioSeleccionado} - {descripcion}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void CargarComboClientes()
        {
            try
            {
                IBLLClientes bLLClientes = new BLLClientes();
                List<ClienteDTO> lista = null;
                this.cmbClientes.Items.Clear();

                lista = await bLLClientes.ObtenerClientesConBicicletas();

                foreach (ClienteDTO cliente in lista)
                {
                    this.cmbClientes.Items.Add(cliente);
                }

                this.cmbClientes.SelectedIndex = 0;


                IBLLProductoServicio bLLProductoServicio = new BLLProductoServicio();
                foreach (ProductoServicioDTO productoServicio in bLLProductoServicio.ObtenerProductoServicios())
                {
                    this.cmbServicio.Items.Add(productoServicio);
                }
                this.cmbServicio.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void CargarDatos()
        {
            try
            {
                IBLLOrdenTrabajo ordenBLL = new BLLOrdenTrabajo();

                dgvDatos.AutoGenerateColumns = false;
                dgvDatos.RowTemplate.Height = 100;
                dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                this.dgvDatos.DataSource = ordenBLL.ObtenerOrdenesTrabajo();

                this.ptbFotoBici.SizeMode = PictureBoxSizeMode.CenterImage;
              
                ((DataGridViewImageColumn)dgvDatos.Columns["QR"]).ImageLayout = DataGridViewImageCellLayout.Zoom;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void cambiarEstado(EstadoMantenimiento estadoMantenimiento)
        {
            this.btnCancelar.Enabled = false;

            switch (estadoMantenimiento)
            {
                case EstadoMantenimiento.Nuevo:
                    this.btnCrear.Enabled = true;
                    this.btnEliminar.Enabled = false;
                    this.btnCancelar.Enabled = true;
                    break;
                case EstadoMantenimiento.Editar:
                    this.cmbClientes.Enabled = true;
                    this.btnCrear.Enabled = true;
                    this.btnEliminar.Enabled = false;
                    this.btnCancelar.Enabled = true;
                    this.lstFotografias.Items.Clear();
                    this.lstDetalles.Items.Clear();
                    this.ptbFotoBici.Tag = null;
                    this.ptbFotoBici.Image = null;
                    break;
                case EstadoMantenimiento.Borrar:
                    break;
                case EstadoMantenimiento.Ninguno:
                    this.btnEliminar.Enabled = true;
                    this.cmbBicicletas.SelectedIndex = 0;
                    this.cmbClientes.SelectedIndex = 0;
                    this.cmbServicio.SelectedIndex = 0;
                    this.ptbFotoBici.Tag = null;
                    this.ptbFotoBici.Image = null;
                    this.dtpFinalizacion.Value = DateTime.Now;
                    this.txaDescripcion.Clear();
                    this.lstFotografias.Items.Clear();
                    this.lstDetalles.Items.Clear();
                    limpiarFirma();
                    break;
            }
        }


        private void ProcesoOrdenTrabajo_Load(object sender, EventArgs e)
        {
            try
            {
                this.CargarComboClientes();
                this.CargarDatos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idCliente = ((ClienteDTO)this.cmbClientes.SelectedItem).IdCliente;
                IBLLBicicleta oBLLBicicleta = new BLLBicicleta();
                this.cmbBicicletas.DataSource = await oBLLBicicleta.ObtenerBicicletasPorVendedor(idCliente);
                this.cmbBicicletas.DisplayMember = "NumeroSerie";
                this.cmbBicicletas.ValueMember = "NumeroSerie";
                this.cmbBicicletas.Enabled = true;
                this.cmbBicicletas.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lstDetalles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstDetalles.SelectedItem != null)
                {

                    string selectedText = lstDetalles.SelectedItem.ToString();


                    string[] parts = selectedText.Split(new[] { " - " }, StringSplitOptions.None);

                    if (parts.Length == 4)
                    {
                        string bicicleta = parts[0];

                        string servicio = parts[1] + " - " + parts[2];

                        string descripcion = parts[3];


                        for (int i = 0; i < cmbBicicletas.Items.Count; i++)
                        {
                            var item = (BicicletaDTO)cmbBicicletas.Items[i];
                            if (item.NumeroSerie.Equals(bicicleta, StringComparison.OrdinalIgnoreCase))
                            {
                                cmbBicicletas.SelectedIndex = i;
                                break;
                            }
                        }


                        for (int i = 0; i < cmbServicio.Items.Count; i++)
                        {
                            var item = (ProductoServicioDTO)cmbServicio.Items[i];
                            if (item.Descripcion.Equals(servicio, StringComparison.OrdinalIgnoreCase))
                            {
                                cmbServicio.SelectedIndex = i;
                                break;
                            }
                        }

                        txaDescripcion.Text = descripcion;
                    }
                    else
                    {
                        MessageBox.Show("El formato del texto seleccionado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnEditarTelefono_Click(object sender, EventArgs e)
        {
            try
            {

                if (lstDetalles.SelectedIndex != -1)
                {

                    string bicicletaSeleccionada = cmbBicicletas.Text;
                    string servicioSeleccionado = cmbServicio.Text;
                    string descripcion = txaDescripcion.Text;


                    string nuevoTexto = $"{bicicletaSeleccionada} - {servicioSeleccionado} - {descripcion}";


                    lstDetalles.Items[lstDetalles.SelectedIndex] = nuevoTexto;

                    MessageBox.Show("Detalle actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un detalle para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarTelefono_Click(object sender, EventArgs e)
        {
            try
            {

                if (lstDetalles.SelectedIndex != -1)
                {
                    lstDetalles.Items.RemoveAt(lstDetalles.SelectedIndex);

                    MessageBox.Show("Detalle eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un detalle para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
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
                    this.ptbFotoBici.ImageLocation = opt.FileName;
                    ptbFotoBici.SizeMode = PictureBoxSizeMode.StretchImage;

                    byte[] cadenaBytes = File.ReadAllBytes(opt.FileName);


                    ptbFotoBici.Tag = cadenaBytes;
                }
                else
                {
                    MessageBox.Show("Solo se permiten archivos con extensión .jpg, .jpeg o .png", "Formato no permitido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void lstFotografias_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string nombreFotoSeleccionada = lstFotografias.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(nombreFotoSeleccionada) && fotos.ContainsKey(nombreFotoSeleccionada))
                {

                    ptbFotoBici.Image = fotos[nombreFotoSeleccionada];
                    ptbFotoBici.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarListaFotos_Click(object sender, EventArgs e)
        {
            try
            {

                if (ptbFotoBici.Image != null)
                {

                    string nombreFoto = $"Foto {fotos.Count + 1}";


                    lstFotografias.Items.Add(nombreFoto);
                    fotos[nombreFoto] = (Image)ptbFotoBici.Image.Clone();
                    ptbFotoBici.Image = null;
                    MessageBox.Show("Foto agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No hay ninguna foto seleccionada en el PictureBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarFoto_Click(object sender, EventArgs e)
        {
            try
            {

                if (lstFotografias.SelectedIndex != -1)
                {

                    string nombreFotoSeleccionada = lstFotografias.SelectedItem.ToString();


                    if (fotos.ContainsKey(nombreFotoSeleccionada))
                    {
                        fotos.Remove(nombreFotoSeleccionada);
                    }
                    lstFotografias.Items.RemoveAt(lstFotografias.SelectedIndex);


                    ptbFotoBici.Image = null;

                    MessageBox.Show("Foto eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una foto para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnlFirma_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                lastPoint = e.Location;
            }
        }

        private void pnlFirma_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = Graphics.FromImage(firmaBitmap))
                {

                    g.DrawLine(Pens.Black, lastPoint, e.Location);
                }


                pnlFirma.Invalidate();


                lastPoint = e.Location;
            }
        }

        private void pnlFirma_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
            }
        }

        private void pnlFirma_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.DrawImage(firmaBitmap, Point.Empty);
        }

        private void btnGuardarFirma_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarFirma_Click(object sender, EventArgs e)
        {
            limpiarFirma();
        }

        private void limpiarFirma()
        {
            using (Graphics g = Graphics.FromImage(firmaBitmap))
            {
                g.Clear(Color.White);
            }

            pnlFirma.Invalidate();
        }
        private bool IsBitmapBlank(Bitmap bitmap)
        {
            Color backgroundColor = bitmap.GetPixel(0, 0); 
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    if (bitmap.GetPixel(x, y) != backgroundColor)
                    {
                        return false; 
                    }
                }
            }
            return true;

        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                //validaciones
                int idOrdenTrabajo;
                if (lstDetalles.Items.Count == 0)
                {
                    MessageBox.Show("Debe agregar al menos un detalle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (firmaBitmap == null || IsBitmapBlank(firmaBitmap))
                {
                    MessageBox.Show("Debe agregar una firma", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txaDescripcion.Text == "")
                {
                    MessageBox.Show("Debe agregar una descripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                OrdenTrabajoDTO orden = new OrdenTrabajoDTO();
                orden.IdCliente = ((ClienteDTO)cmbClientes.SelectedItem).IdCliente;
                orden.IdVendedor = vendedor.IdVendedor;
                orden.FechaInicio = DateTime.Now;
                orden.FechaFinalizacion = dtpFinalizacion.Value;
                orden.Firma = ImageToByteArray(firmaBitmap);
                orden.ImagenQROrden = null;

                if (int.TryParse(lblOrden.Text, out idOrdenTrabajo))
                {
                    orden.IdOrdenTrabajo = idOrdenTrabajo;
                }
                else
                {
                    orden.IdOrdenTrabajo = 0;
                }


                string textoCbo = cmbServicio.SelectedItem.ToString();
                string idProductoServicio = textoCbo.Split('-')[0].Trim();

                foreach (string detalle in lstDetalles.Items)
                {

                    string[] parts = detalle.Split(new[] { " - " }, StringSplitOptions.None);
                    if (parts.Length == 4)
                    {
                        DetalleOrdenTrabajo detalleOrden = new DetalleOrdenTrabajo();
                        detalleOrden.NumeroSerie = parts[0];
                        detalleOrden.IdProductoServicio = int.Parse(idProductoServicio);
                        detalleOrden.Descripcion = parts[3];
                        orden.ListaDetalles.Add(detalleOrden);

                    }

                }
              
                List<FotografiaOrden> listaFotografias = new List<FotografiaOrden>();

                foreach (var item in lstFotografias.Items)
                {
             
                    string nombreFoto = item.ToString();
                    if (fotos.ContainsKey(nombreFoto))
                    {
                        var foto = new FotografiaOrden
                        {
                            Fotografia = ImageToByteArray(fotos[nombreFoto])  
                        };

                        listaFotografias.Add(foto);
                    }
                }

                orden.ListaFotografias = listaFotografias;


                IBLLOrdenTrabajo bLLOrdenTrabajo = new BLLOrdenTrabajo();
                OrdenTrabajoDTO ordenGuardada = bLLOrdenTrabajo.GuardarOrdenTrabajo(orden, listaFotografias);

               
                    MessageBox.Show("Orden de trabajo creada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cambiarEstado(EstadoMantenimiento.Ninguno);
                    this.CargarDatos();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                this.cambiarEstado(EstadoMantenimiento.Editar);
                if (dgvDatos.SelectedRows.Count > 0)
                {
                    OrdenTrabajoDTO ordenDto = null;
                    OrdenTrabajoDTO orden = (OrdenTrabajoDTO)dgvDatos.SelectedRows[0].DataBoundItem;
                    IBLLOrdenTrabajo oOrden = new BLLOrdenTrabajo();
                    ordenDto =
                    oOrden.ObtenerOrdenPorId(orden.IdOrdenTrabajo.ToString());
                    this.lblOrden.Text = ordenDto.IdOrdenTrabajo.ToString();
                    this.cmbClientes.SelectedValue = ordenDto.IdCliente;
                    this.cmbBicicletas.SelectedValue = ordenDto.ListaDetalles[0].NumeroSerie;
                    this.cmbServicio.SelectedValue = ordenDto.ListaDetalles[0].IdProductoServicio;
                    this.txaDescripcion.Text = ordenDto.ListaDetalles[0].Descripcion;
                    this.dtpFinalizacion.Value = ordenDto.FechaFinalizacion;
                    this.lstDetalles.Items.Clear();
                    foreach (DetalleOrdenTrabajo detalle in ordenDto.ListaDetalles)
                    {
                        //hacer inner DescripcionServicio y annadir
                        this.lstDetalles.Items.Add($"{detalle.NumeroSerie} - {detalle.IdProductoServicio} - {detalle.NombreProducto} - {detalle.Descripcion}");
                    }

                    this.lstFotografias.Items.Clear();
                  
                    if (ordenDto.Firma != null && ordenDto.Firma.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(ordenDto.Firma))
                        {
                            this.firmaBitmap = new Bitmap(ms);
                        }
                    }
                    else
                    {
                        using (Graphics g = Graphics.FromImage(firmaBitmap))
                        {
                            g.Clear(Color.White);
                        }
                    }
                    this.pnlFirma.Invalidate();
                    this.pnlFirma.Refresh();


                    //if (ordenDto.ListaFotografias != null && ordenDto.ListaFotografias.Count > 0)
                    //{
                    //    foreach (FotografiaOrden fotografia in ordenDto.ListaFotografias)
                    //    {
                    //        using (MemoryStream ms = new MemoryStream(fotografia.Fotografia))
                    //        {
                    //            Image img = Image.FromStream(ms);
                    //            this.fotos["fotografía"] = img;
                    //            this.lstFotografias.Items.Add("fotografía");
                    //        }
                    //    }
                    //}
                    //else
                    //{
                    //    this.fotos.Clear();
                    //    this.lstFotografias.Items.Clear();
                    //}
                    if (ordenDto.ListaFotografias != null && ordenDto.ListaFotografias.Count > 0)
                    {
                        foreach (FotografiaOrden fotografia in ordenDto.ListaFotografias)
                        {
                            if (fotografia.Fotografia != null && fotografia.Fotografia.Length > 0)
                            {
                                try
                                {
                                    using (MemoryStream ms = new MemoryStream(fotografia.Fotografia))
                                    {
                                        Image img = Image.FromStream(ms);
                                        this.fotos["fotografía"] = img;
                                        this.lstFotografias.Items.Add("fotografía");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Error al cargar la fotografía: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Fotografía vacía o nula en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else
                    {
                        this.fotos.Clear();
                        this.lstFotografias.Items.Clear();
                    }

                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una orden de trabajo para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.cambiarEstado(EstadoMantenimiento.Ninguno); ;
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            IBLLOrdenTrabajo bLLOrdenTrabajo = new BLLOrdenTrabajo();
            try
            {
                if (this.dgvDatos.SelectedRows.Count > 0)
                {
                    OrdenTrabajoDTO oOrdenDto = (OrdenTrabajoDTO)dgvDatos.SelectedRows[0].DataBoundItem as OrdenTrabajoDTO;

                    if (MessageBox.Show("¿Está seguro de eliminar la orden de trabajo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool eliminado = await bLLOrdenTrabajo.EliminarOrdenTrabajo(oOrdenDto.IdOrdenTrabajo);
                        if (eliminado)
                        {
                           
                            MessageBox.Show("Orden de trabajo eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.CargarDatos();
                        } else
                        {

                            MessageBox.Show("No se pudo eliminar la orden de trabajo, debido a que tiene otras relaciones asociadas.", "Advertencia", MessageBoxButtons.OK);
                            return;
                        }
                       
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una orden de trabajo para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la orden", "Atencion");
            }
        }
    }
}
