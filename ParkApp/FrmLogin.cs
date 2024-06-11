using BLL;
using ENTITY;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace ParkApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    lblhoraLogin.Text = DateTime.Now.ToLongTimeString();
        //    lblfechaLogin.Text = DateTime.Now.ToShortDateString();

        //}



        private void ValidarCredenciales()
        {
            try
            {
                Usuario usuario = new ServicioUsuario().Listar().Where(u => u.Nombre == txtUsuario.Text
                        && u.Contraseña == txtContraseña.Text).FirstOrDefault();

                if (txtUsuario.Text == "")
                {
                    MessageBox.Show("El campo del usuario está vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Focus();
                }
                else if (txtContraseña.Text == "")
                {
                    MessageBox.Show("El campo de contraseña está vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContraseña.Focus();
                }
                else
                {
                    if (usuario != null)
                    {
                        if (usuario.Estado == false)
                        {
                            MessageBox.Show("Este usuario se encuentra Inactivo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            this.Hide();
                            FrmMenu menu = new FrmMenu();
                            menu.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Credenciales incorrectas, verifique e intentelo nuevamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMinizarL_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarL_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ValidarCredenciales();
        }

        private void panelArriba_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelArriba_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
        }
    }
}
