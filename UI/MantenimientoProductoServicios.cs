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
    public partial class MantenimientoProductoServicios : Form
    {
        private decimal tipoCambioventa;
        public MantenimientoProductoServicios()
        {
            InitializeComponent();
        }

     
        private void MantenimientoProductoServicios_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            AgregarProductoServicio AgregarProductoServicio = new AgregarProductoServicio();
            AgregarProductoServicio.ShowDialog();
        }

        private async void btnCalcularPrecioDolar_Click(object sender, EventArgs e)
        {
            if(!decimal.TryParse(txtPrecioColones.Text,out decimal precioColones))
            {
                MessageBox.Show("El precio en colones no es valido");
                return;
            }

            tipoCambioventa = await Utils.ObtenerTipoCambioAsync();

            if(tipoCambioventa == 0)
            {
                MessageBox.Show("No se pudo obtener el tipo de cambio");
                return;
            }

            decimal precioDolares = precioColones / tipoCambioventa;
            txtPrecioDolares.Text = $"${precioDolares:0.00}";
        }
    }
}
