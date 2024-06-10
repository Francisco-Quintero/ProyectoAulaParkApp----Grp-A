using System;
using System.Windows.Forms;

namespace ParkApp
{
    public partial class FrmTikets : Form
    {
        public FrmTikets()
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
