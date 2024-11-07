using ProyectoProgramadolll.Entities;
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
    public partial class ProcesoFacturacion : Form
    {
        public ProcesoFacturacion()
        {
            InitializeComponent();
        }

        private void ProcesoFacturacion_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int nivel = 0; // depende del máximo de caracteres permitidos
                nivel = 53;   // Existen los niveles  17,32,53,78,108,134,154,
                // 192,230,271,321,367,425,458,520,586,644,718
                // 792, 858

                QuickResponse qr = new QuickResponse();
               // ptbQR.Image = qr.QuickResponseGenerador(this.mtbNumerOrden.Text, nivel);
            }
            catch (Exception err)
            {

                MessageBox.Show("Error " + err.Message, "Atención");
            }
        }
    }
}
