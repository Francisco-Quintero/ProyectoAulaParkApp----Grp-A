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
    public partial class Informes : Form
    {
        public Informes()
        {
            InitializeComponent();
        }

        private void btnInformeSalida_Click(object sender, EventArgs e)
        {
            InformeSalidas panelSalida = new InformeSalidas();
            AddOwnedForm(panelSalida);
            panelSalida.FormBorderStyle = FormBorderStyle.None;
            panelSalida.TopLevel = false;
            panelSalida.Dock = DockStyle.Fill;
            this.Controls.Add(panelSalida);
            this.Tag = panelSalida;
            panelSalida.BringToFront();
            panelSalida.Show();
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            InformeIngresos panelSalida = new InformeIngresos();
            AddOwnedForm(panelSalida);
            panelSalida.FormBorderStyle = FormBorderStyle.None;
            panelSalida.TopLevel = false;
            panelSalida.Dock = DockStyle.Fill;
            this.Controls.Add(panelSalida);
            this.Tag = panelSalida;
            panelSalida.BringToFront();
            panelSalida.Show();
        }
    }
}
