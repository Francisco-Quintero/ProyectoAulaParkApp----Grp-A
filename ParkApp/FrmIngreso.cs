using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ParkApp
{
    public partial class FrmIngreso : Form
    {
        private ServicioTipoVehiculo servicioTipoVehiculo = new ServicioTipoVehiculo();
        //private ServicioVehiculo servicioVehiculo= new ServicioVehiculo();
        private ServicioVehiculo servicioVehiculo;
        private ServicioParqueadero servicioParqueadero;
        public FrmIngreso()
        {
            InitializeComponent();
            servicioVehiculo = new ServicioVehiculo();
            servicioParqueadero = new ServicioParqueadero();
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
            //FrmTikets form2 = new FrmTikets();
            //form2.datoplaca.Text = txtPlaca.Text;
            //form2.Show();
        }

        private void btnCerrarPingreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {
            ListarTipoVehiculo();
        }


        public void pruebaMostrar() 
        {
        
        
        
        
        
        
        }
        
        private void btnRealizarIngreso_Click(object sender, EventArgs e)
        {



            try
            {
                // Crear una instancia de la clase Vehiculo
                Vehiculo vehiculo = new Vehiculo();
                

                // Asignar los valores correspondientes
                vehiculo.Placa = txtPlaca.Text;
                vehiculo.IdTipoVehiculo = (int)boxTipoIngreso.SelectedValue;




                // Llamar al método Crear de la clase ServicioVehiculo
                servicioVehiculo.Crear(vehiculo);
                Parqueadero parqueadero = new Parqueadero();

                // Asignar los valores correspondientes
                parqueadero.Tarifa = 10.00m; // Supongamos que la tarifa es $10.00 por hora
                parqueadero.HoraEntrada = DateTime.Now;
                parqueadero.IdVehiculo = vehiculo.IdVehiculo; // Aquí necesitas el ID del vehículo que acabas de crear
                parqueadero.TipoParqueadero = 1; // Esto depende de cómo estés manejando los tipos de parqueadero

                // Llamar al método Crear de la clase ServicioParqueadero
                servicioParqueadero.Crear(parqueadero);
                // Mostrar un mensaje de éxito
                MessageBox.Show("Ingreso realizado con éxito", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Error al realizar ingreso: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lblfecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btnRegistarSalida_Click(object sender, EventArgs e)
        {

        }
    }
}
