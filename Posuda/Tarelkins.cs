﻿using System;
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
    public partial class Tarelkins : Form
    {
        public Tarelkins()
        {
            InitializeComponent();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
