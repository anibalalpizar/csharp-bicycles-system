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
    public partial class ProcesoOrdenTrabajo : Form
    {
        public ProcesoOrdenTrabajo()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ofdDialogo.Title = "Buscar Imágenes";
            ofdDialogo.SupportMultiDottedExtensions = true;
            ofdDialogo.DefaultExt = "*.jpg";
            ofdDialogo.Filter = "Archivos de Imagenes (*.jpg)|*.jpg| All files (*.*)|*.*";

            if (ofdDialogo.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    ptbFotoBici.ImageLocation = ofdDialogo.FileName;
                    ptbFotoBici.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
