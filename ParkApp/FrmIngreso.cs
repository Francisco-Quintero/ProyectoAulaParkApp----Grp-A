using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace ParkApp
{
    public partial class FrmIngreso : Form
    {
        private ServicioTipoVehiculo servicioTipoVehiculo = new ServicioTipoVehiculo();
        public FrmIngreso()
        {
            InitializeComponent();
        }

        private void ListarTipoVehiculo()
        {

            try
            {
                List<TipoVehiculo> tipoVehiculo = servicioTipoVehiculo.Listar();

                tipoVehiculo.Insert(0, new TipoVehiculo { IdTipoVehiculo = 0, Descripcion = "Seleccionar" });

                boxTipoIngreso.DataSource = tipoVehiculo;
                boxTipoIngreso.DisplayMember = "Descripcion";
                boxTipoIngreso.ValueMember = "IdTipoVehiculo";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lblfecha.Text = DateTime.Now.ToShortDateString();

        }

        private void CapturaIngreso()
        {
            //Ingreso ingreso = (Ingreso)boxTipoIngreso.SelectedItem;

            //vehiculo. = txtPlaca.Text;

        }

        private void btnticket_Click(object sender, EventArgs e)
        {
            FrmTikets form2 = new FrmTikets();
            form2.datoplaca.Text = txtPlaca.Text;



            form2.Show();
        }

        private void btnCerrarPingreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {
            ListarTipoVehiculo();
        }
    }
}
