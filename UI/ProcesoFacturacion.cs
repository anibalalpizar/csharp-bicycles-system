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
using System.Windows.Controls;
using System.Windows.Forms;

namespace ProyectoProgramadolll.UI
{
    public partial class ProcesoFacturacion : Form
    {
        private decimal totalColonesAcumulado = 0;
        private decimal totalDolaresAcumulado = 0;
        private VendedorClienteDTO vendedor = null;
        private List<decimal> montosIndividualesC = new List<decimal>();
        private List<decimal> montosIndividualesD = new List<decimal>();
        public ProcesoFacturacion(VendedorClienteDTO vendedor)
        {
            InitializeComponent();
            this.vendedor = vendedor;
        }

        private void ProcesoFacturacion_Load(object sender, EventArgs e)
        {
            try
            {
                this.CargarComboClientes();
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
                    this.lstDetallesFactura.Items.Clear();
                    this.txtPrecioColones.Text = "0.00";
                    this.txtPrecioDolares.Text = "0.00";
                    txtNumeroTarjeta.Clear();
                    totalColonesAcumulado = 0;
                    totalDolaresAcumulado = 0;
                    montosIndividualesC.Clear();
                    montosIndividualesD.Clear();

                    break;
          
                case EstadoMantenimiento.Ninguno:
                    this.lstDetallesFactura.Items.Clear();
                    this.txtPrecioColones.Text = "0.00";
                    this.txtPrecioDolares.Text = "0.00";
                    txtNumeroTarjeta.Clear();
                    totalColonesAcumulado = 0;
                    totalDolaresAcumulado = 0;
                    montosIndividualesC.Clear();
                    montosIndividualesD.Clear();

                    break;
            
                   
            }
        }

        private async void CargarComboClientes()
        {
            try
            {
                IBLLClientes bLLClientes = new BLLClientes();
                List<ClienteDTO> lista = null;
                this.cmbClientes.Items.Clear();


                lista = await bLLClientes.ObtenerClientesConBicicletas();

                this.cmbClientes.DataSource = lista;
                this.cmbClientes.DisplayMember = "Nombre";
                this.cmbClientes.ValueMember = "idCliente";
                this.cmbClientes.SelectedIndex = 0;

                this.cmbTipoTarjeta.DataSource = Enum.GetValues(typeof(TipoPago));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception err)
            {

                MessageBox.Show("Error " + err.Message, "Atención");
            }
        }

        private async void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                this.cambiarEstado(EstadoMantenimiento.Nuevo);
                int idCliente = ((ClienteDTO)this.cmbClientes.SelectedItem).IdCliente;
                IBLLOrdenTrabajo oBLLOrdenTrabajo = new BLLOrdenTrabajo();
                this.cmbOrdenTrabajo.DataSource = await oBLLOrdenTrabajo.ObtenerOrdenPorIdCliente(idCliente.ToString());
                this.cmbOrdenTrabajo.DisplayMember = "idOrdenTrabajo";
                this.cmbOrdenTrabajo.ValueMember = "idOrdenTrabajo";
                this.cmbOrdenTrabajo.Enabled = true;
                this.cmbOrdenTrabajo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lstDetallesFactura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarTelefono_Click(object sender, EventArgs e)
        {
            try
            {

                if (lstDetallesFactura.SelectedIndex != -1)
                {
                    lstDetallesFactura.Items.RemoveAt(lstDetallesFactura.SelectedIndex);

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

        private void btnAnnadirOrden_Click(object sender, EventArgs e)
        {
            try
            {

                string ordenSeleccionada = this.cmbOrdenTrabajo.Text;

                for (int i = 0; i < lstDetallesFactura.Items.Count; i++)
                {
                    if (lstDetallesFactura.Items[i].ToString().Contains(ordenSeleccionada))
                    {
                        MessageBox.Show("Esta orden ya ha sido seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                this.lstDetallesFactura.Items.Add($"Orden de Trabajo #{ordenSeleccionada}");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }



        private async void btnCobrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstDetallesFactura.SelectedIndex != -1)
                {


                    string ordenSeleccionada = this.lstDetallesFactura.SelectedItem.ToString().Replace("Orden de Trabajo #", "");
                    IBLLOrdenTrabajo oBLLOrdenTrabajo = new BLLOrdenTrabajo();
                    IEnumerable<OrdenTrabajoDTO> ordenes = await oBLLOrdenTrabajo.ObtenerPrecioProductoPorIdOrden(ordenSeleccionada);

                    OrdenTrabajoDTO orden = ordenes.FirstOrDefault();
                    if (orden != null)
                    {
                        
                        if (orden.IsCobrada)
                        {
                            MessageBox.Show("Esta orden ya ha sido cobrada y no se puede seleccionar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                           
                            DesactivarItemOrden(ordenSeleccionada);
                            return;
                        }

                   
                        orden.IsCobrada = true;

                       
                        totalColonesAcumulado += orden.TotalColones;
                        decimal dolares = await Utils.ObtenerTipoCambioAsync();

                        if (dolares == 0)
                        {
                            MessageBox.Show("No se pudo obtener el tipo de cambio");
                            return;
                        }

                        decimal precioDolares = orden.TotalColones / dolares;
                        totalDolaresAcumulado += precioDolares;

                      
                        this.txtPrecioColones.Text = totalColonesAcumulado.ToString("0.00");
                        txtPrecioDolares.Text = totalDolaresAcumulado.ToString("0.00");

                        montosIndividualesC.Add(orden.TotalColones);
                        montosIndividualesD.Add(precioDolares);

                        DesactivarItemOrden(ordenSeleccionada);

                        MessageBox.Show("Orden cobrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró una orden con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una orden para cobrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Esta orden ya ha sido cobrada y no se puede seleccionar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void DesactivarItemOrden(string ordenId)
        {
            for (int i = 0; i < lstDetallesFactura.Items.Count; i++)
            {
                if (lstDetallesFactura.Items[i].ToString().Contains(ordenId))
                {
                  
                    lstDetallesFactura.Items[i] = $"[Cobrada] {lstDetallesFactura.Items[i].ToString()}";
                    break; 
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.cambiarEstado(EstadoMantenimiento.Ninguno);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstDetallesFactura.Items.Count == 0)
                {
                    MessageBox.Show("Debe agregar al menos un detalle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(txtNumeroTarjeta.Text))
                {
                    MessageBox.Show("Debe ingresar un número de tarjeta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtPrecioColones.Text == "0.00")
                {
                    MessageBox.Show("Debe ingresar un monto en colones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FacturaDTO factura = new FacturaDTO();
                factura.IdCliente = ((ClienteDTO)this.cmbClientes.SelectedItem).IdCliente;
                factura.FechaFactura = DateTime.Now;
                factura.MontoColones = Convert.ToDecimal(txtPrecioColones.Text);
                factura.Venta = Convert.ToDecimal(txtPrecioDolares.Text);
                factura.IdVendedor = this.vendedor.IdVendedor;
                factura.TipoTarjeta = this.cmbTipoTarjeta.Text;
                factura.NumeroTarjeta = txtNumeroTarjeta.Text;
                factura.FechaPago = DateTime.Now;
                factura.MontoPago = Convert.ToDecimal(txtPrecioColones.Text);

                List<FacturaDTO> detalles = new List<FacturaDTO>();
                foreach (var item in lstDetallesFactura.Items)
                {
                    FacturaDTO detalle = new FacturaDTO();
                    detalle.IdOrdenTrabajo = Convert.ToInt32(item.ToString().Replace("Orden de Trabajo #", "").Replace("[Cobrada] ", ""));
                   
                    detalles.Add(detalle);
                }

                factura.ListaDetallesFactura = detalles;

                IBLLFactura bLLFactura = new BLLFactura();
                bLLFactura.GuardarFactura(factura, montosIndividualesC, montosIndividualesD);
                MessageBox.Show("Factura creada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cambiarEstado(EstadoMantenimiento.Nuevo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
