using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;

namespace ParkApp
{
    public partial class TipoVehiculo : Form
    {

        private ServicioTipoVehiculo servicioTipoVehiculo;

        public TipoVehiculo()
        {
            InitializeComponent();
            servicioTipoVehiculo = new ServicioTipoVehiculo();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string descripcion = txtTipoVehiculo.Text;

            // Crear una nueva instancia de ENTITY.TipoVehiculo usando fully qualified name
            ENTITY.TipoVehiculo tipoVehiculo = new ENTITY.TipoVehiculo(descripcion);

            // Llamar al servicio para registrar el nuevo TipoVehiculo
            bool resultado = servicioTipoVehiculo.Crear(tipoVehiculo);

            // Mostrar mensaje de éxito o error
            if (resultado)
            {
                MessageBox.Show("Registro exitoso.");
            }
            else
            {
                MessageBox.Show("Error al registrar el Tipo de Vehículo.");
            }
        }
    }
}
