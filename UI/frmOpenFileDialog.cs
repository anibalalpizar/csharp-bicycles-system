using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Controles
{
    public partial class frmOpenFileDialog : Form
    {
        public frmOpenFileDialog()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
             
            ofdDialogo.Title = "Buscar Imágenes";
            ofdDialogo.SupportMultiDottedExtensions = true;
            ofdDialogo.DefaultExt = "*.jpg";
            ofdDialogo.Filter = "Archivos de Imagenes (*.jpg)|*.jpg| All files (*.*)|*.*";
           
            if (ofdDialogo.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    ptbImagen.ImageLocation = ofdDialogo.FileName;
                    ptbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            //Variables

            string linea = "";
            StringBuilder texto = new StringBuilder(); // inmutable
           
            OpenFileDialog ofdEscogerArchivo = new OpenFileDialog();
             
            ofdEscogerArchivo.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofdEscogerArchivo.FilterIndex = 2;
            ofdEscogerArchivo.RestoreDirectory = true;

            if (ofdEscogerArchivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    StreamReader sr = new StreamReader(ofdEscogerArchivo.FileName);

                    while ((linea = sr.ReadLine()) != null)
                    {
                        texto.AppendFormat("{0}",linea); 
                    } 

                    this.rtbTexto.AppendText(texto.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: No pude leer el archivo del disco.  Error: " + ex.Message);
                }
            }
        }
    }
}
