using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ParkApp
{
    public partial class Ingreso : Form
    {
        private ServicioTipoVehiculo servicioTipoVehiculo = new ServicioTipoVehiculo();
        private TipoVehiculo TipoVehiculo = new TipoVehiculo();

        public Ingreso()
        {
            InitializeComponent();
        }

        private void ListarTipoVehiculo()
        {
            try
            {
                List<TipoVehiculo> tipoVehiculos = servicioTipoVehiculo.Listar();

                // Agrega la opción "Seleccionar"
                tipoVehiculos.Insert(0, new Rol { Id = 0, Nombre = "Seleccionar" });

                // Asigna la lista al ComboBox
                boxRoles.DataSource = roles;
                boxRoles.DisplayMember = "Nombre";
                boxRoles.ValueMember = "Id";
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

        private void btnticket_Click(object sender, EventArgs e)
        {
            Tikets form2 = new Tikets();
            form2.datoplaca.Text = placa.Text;



            form2.Show();
        }

        private void btnCerrarPingreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
