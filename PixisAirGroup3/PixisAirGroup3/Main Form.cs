using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixisAirGroup3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnDevin1_Click(object sender, EventArgs e)
        {
            Form FormDev1 = new FormDev1();
            FormDev1.Show();
            this.Hide();
        }

        private void btnDevin2_Click(object sender, EventArgs e)
        {
            Form FormDev2 = new FormDev2();
            FormDev2.Show();
            this.Hide();
        }

        private void btnJosh1_Click(object sender, EventArgs e)
        {
            Form FormJosh1 = new FormJosh1();
            FormJosh1.Show();
            this.Hide();
        }

        private void btnJosh2_Click(object sender, EventArgs e)
        {
            Form FormJosh2 = new FormJosh2();
            FormJosh2.Show();
            this.Hide();
        }

        private void btnFran1_Click(object sender, EventArgs e)
        {
            Form FormFran1 = new FormFran1();
            FormFran1.Show();
            this.Hide();
        }

        private void btnFran2_Click(object sender, EventArgs e)
        {
            Form FormFran2 = new FormFran2();
            FormFran2.Show();
            this.Hide();
        }
    }
}
