using System;
using System.Windows.Forms;

namespace ParkApp
{
    public partial class Tikets : Form
    {
        public Tikets()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfechatick.Text = DateTime.Now.ToShortTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
