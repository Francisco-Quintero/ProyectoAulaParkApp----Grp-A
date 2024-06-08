using System;
using System.Windows.Forms;

namespace ParkApp
{
    public partial class InformeSalidas : Form
    {
        public InformeSalidas()
        {
            InitializeComponent();
        }

        private void btnCerrarSalidasVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridSalidasVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarHSalidas_Click(object sender, EventArgs e)
        {

        }
    }
}
