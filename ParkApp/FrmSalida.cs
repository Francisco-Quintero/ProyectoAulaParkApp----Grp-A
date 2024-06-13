using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ParkApp
{
    public partial class FrmSalida : Form
    {


        private ServicioVehiculo servicioVehiculo;
        public FrmSalida()
        {
            InitializeComponent();
            servicioVehiculo = new ServicioVehiculo();
            
        }

        private void btnCerrarPsalida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnSalida_Click(object sender, EventArgs e)
        {

        }

        private void CargarVehiculosEstacionados()
        {
            try
            {
                List<Vehiculo> listaVehiculos = servicioVehiculo.Listar();
                dataGridSalidasVehiculo.DataSource = listaVehiculos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAutorizarSalida_Click(object sender, EventArgs e)
        {
            try
            {
                string placa = txtPlacaSalida.Text.Trim();
                if (string.IsNullOrEmpty(placa))
                {
                    MessageBox.Show("Por favor, ingrese la placa del vehículo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool resultado = servicioVehiculo.EliminarPorPlaca(placa);
                if (resultado)
                {
                    MessageBox.Show("Salida del vehiculo autorizada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarVehiculosEstacionados(); // Actualizar la lista de vehículos estacionados
                }
                else
                {
                    MessageBox.Show("Error al autorizar salida del vehículo. Verifique la placa ingresada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al autorizar salida: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmSalida_Load(object sender, EventArgs e)
        {
            CargarVehiculosEstacionados();

        }
    }
}
