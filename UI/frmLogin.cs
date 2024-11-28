using ProyectoProgramadolll.BLL;
using ProyectoProgramadolll.Entities.DTO;
using ProyectoProgramadolll.Interfaces;
using System;
using System.Windows.Forms;

namespace ProyectoProgramadolll.UI
{
    public partial class frmLogin : Form
    {

        private int contador = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            IBLLVendedor bLLVendedor = new BLLVendedor();
            epError.Clear();
            VendedorClienteDTO oVendedor = null;

            try
            {
                if (string.IsNullOrEmpty(txtLogin.Text))
                {
                    epError.SetError(txtLogin, "El campo usuario es obligatorio");
                    txtLogin.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    epError.SetError(txtPassword, "El campo contraseña es obligatorio");
                    txtPassword.Focus();
                    return;
                }

                oVendedor = bLLVendedor.Login(txtLogin.Text, txtPassword.Text);

                if (oVendedor == null)
                {
                    contador++;
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (contador == 3)
                    {
                        MessageBox.Show("Ha superado el número de intentos permitidos, el sistema se cerrará por seguridad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                }
                else
                {
                    if (!oVendedor.Estado)
                    {
                        MessageBox.Show("El usuario se encuentra inactivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MainForm oMainForm = new MainForm(oVendedor);
                    oMainForm.Show();
                    this.Hide();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}