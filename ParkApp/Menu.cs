using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ParkApp
{
    public partial class Menu : Form
    {
        public Menu()
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


        //private void AbrirFormEnPanel(object Formhijo)
        //{
        //    if (this.panelformularios.Controls.Count > 0)
        //        this.panelformularios.Controls.RemoveAt(0);
        //    Form fh = Formhijo as Form;
        //    fh.TopLevel = false;
        //    fh.Dock = DockStyle.Fill;
        //    this.panelformularios.Controls.Add(fh);
        //    this.panelformularios.Tag = fh;
        //    fh.Show();
        //}


        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelformularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelformularios.Controls.Add(formulario);
                panelformularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }



        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        int lx, ly;
        int sw, sh;

        private void btnCancelarM_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenuEx_Click(object sender, EventArgs e)
        {

            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
                MenuVertical.Width = 250;
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            //AbrirFormEnPanel(new Ingreso());
            AbrirFormulario<Ingreso>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //AbrirFormEnPanel(new InformeSalidas());
            AbrirFormulario<InformeSalidas>();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //AbrirFormEnPanel(new Salidas());
            AbrirFormulario<Salidas>();
        }

        private void dataGridEntradas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnHistorialIngresos_Click(object sender, EventArgs e)
        {
            //AbrirFormEnPanel(new InformeIngresos());
            AbrirFormulario<InformeIngresos>();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridEstacionados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CBVehiculosEstacionados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Usuarios>();
        }

        private void btnTipoVehiculo_Click(object sender, EventArgs e)
        {
            AbrirFormulario<TipoVehiculo>();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            iconmaximizar.Visible = false;
            iconrestaurar.Visible = true;
        }
    }
}
