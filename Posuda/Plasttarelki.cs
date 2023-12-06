using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Posuda
{
    public partial class Plasttarelki : Form
    {
        public Plasttarelki()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Netoplatbl netoplatbl = new Netoplatbl();
            netoplatbl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home2 home2 = new Home2();
            home2.Show();
        }
    }
}
