using log4net;
using ProyectoProgramadolll.BLL;
using ProyectoProgramadolll.DTO;
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

        public MantenimientoClientes()
        {
            InitializeComponent();
        }

       
        private void MantenimientoClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            AgregarClientes AgregarClientes = new AgregarClientes();
            AgregarClientes.ShowDialog();
        }

        ErrorProvider erp = new ErrorProvider();
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BLLPadron bLLPadron = new BLLPadron();
            IBLLPadron _BLLPadron = (IBLLPadron)bLLPadron;
            try
            {
                erp.Clear();

                if (string.IsNullOrEmpty(txtIdCliente.Text))
                {
                    erp.SetError(txtIdCliente, "Id Requerido");
                    txtIdCliente.Focus();
                    return;
                }

                if (txtIdCliente.Text.Trim().Length != 9)
                {
                    erp.SetError(txtIdCliente, "Largo de la Cédula 9 digitos");
                    txtIdCliente.Focus();
                    return;
                }


                // ToDo: Cree La validación que solo permita números en la cédula 

                PadronDTO oPadronDTO = _BLLPadron.GetPersonaById(txtIdCliente.Text.Trim());


                string[] array = oPadronDTO.nombre.Split(' ');

                // 1 nombres y dos apellidos
                if (array.Length == 0)
                {
                    txtNombre.Text = array[0];
                 // txtApellido1.Text = array[1];
                //  txtApellido2.Text = array[2];
                }

                // 2 nombres y dos apellidos
                if (array.Length == 0)
                {
                    txtNombre.Text = array[0] + " " + array[1];
                 //   txtApellido1.Text = array[2];
                  //  txtApellido2.Text = array[3];
                }

                // Ejemplo con varios nombres. 203960070 - ANTONIO MARIA DE LA TRINIDAD RODRIGUEZ CHAVES 
                // 2 nombres y dos apellidos
                // Nota: No se valida apellidos compuestos por ejemplo Maria de la O
                if (array.Length > 0)
                {
                    txtNombre.Text = array[0] + " " + array[1];
                  //  txtApellido1.Text = array[array.Length - 2];
                  //  txtApellido2.Text = array[array.Length - 1];
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
    }
    }

