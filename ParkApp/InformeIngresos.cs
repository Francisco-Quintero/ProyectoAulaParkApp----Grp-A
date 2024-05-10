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
    public partial class InformeIngresos : Form
    {
        public InformeIngresos()
        {
            InitializeComponent();
        }

        private void btnCerrarPingreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridEntradas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InformeIngresos_Load(object sender, EventArgs e)
        {

        }
    }
}
