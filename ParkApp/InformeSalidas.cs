using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
