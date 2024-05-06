using ENTITY;
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
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
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
    }
}
