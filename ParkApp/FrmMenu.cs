using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ParkApp
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
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



        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelformularios.Controls.OfType<MiForm>().FirstOrDefault();
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
            AbrirFormulario<FrmIngreso>();
        }

       
        private void button5_Click(object sender, EventArgs e)
        {
            //AbrirFormEnPanel(new Salidas());
            AbrirFormulario<FrmSalida>();
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
            AbrirFormulario<FrmGestionUsuarios>();
        }

        private void btnTipoVehiculo_Click(object sender, EventArgs e)
        {
            AbrirFormulario<TipoVehiculo1>();
        }

        private void CargarVehiculosEstacionados()
        {
            try
            {
                ServicioVehiculo servicioVehiculo = new ServicioVehiculo();
                List<Vehiculo> listaVehiculos = servicioVehiculo.Listar();
                dataGridEstacionados.DataSource = listaVehiculos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void FiltrarDataGridView(DataGridView dataGridView, TextBox textBox)
        {
            
            string filtro = textBox.Text.ToLower();

            
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                bool filaVisible = false;

                
                foreach (DataGridViewCell cell in row.Cells)
                {
                   
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(filtro))
                    {
                        
                        filaVisible = true;
                        break;
                    }
                }

                
                row.Visible = filaVisible;
            }
        }




        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CargarVehiculosEstacionados();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            CargarVehiculosEstacionados();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarDataGridView(dataGridEstacionados, txtBusquedaEstacionado);
        }

        private void txtBusquedaEstacionado_TextChanged(object sender, EventArgs e)
        {
            ServicioVehiculo servicioVehiculo = new ServicioVehiculo();

            var textoBusqueda = txtBusquedaEstacionado.Text;
            var resultados = servicioVehiculo.FiltrarVehiculos(textoBusqueda);
            dataGridEstacionados.DataSource = resultados;
            
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
