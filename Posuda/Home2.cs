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
    public partial class Home2 : Form
    {
        public Home2()
        {
            InitializeComponent();
        }

        private void Home2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Steklo steklo = new Steklo();
            steklo.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Plasttarelki plasttarelki = new Plasttarelki();
            plasttarelki.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Plasttarelki plasttarelki = new Plasttarelki();
            plasttarelki.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Steklo steklo = new Steklo();
            steklo.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tarelkin tarelkin = new Tarelkin();
            tarelkin.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tarelkins tarelkins = new Tarelkins();
            tarelkins.Show();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tarelkin tarelkin = new Tarelkin();
            tarelkin.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tarelkin tarelkin = new Tarelkin();
            tarelkin.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tarelkins tarelkins = new Tarelkins();
            tarelkins.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tarelkins tarelkins = new Tarelkins();
            tarelkins.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Plasttarelki plasttarelki = new Plasttarelki(); 
            plasttarelki.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Steklo steklo = new Steklo();   
            steklo.Show();
        }
    }
}
