﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPCOMY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtRegistrate_Click(object sender, EventArgs e)
        {
            Form3 administrador = new Form3();
            administrador.ShowDialog();
        }

        private void txtIniciar_Click(object sender, EventArgs e)
        {
            Form2 administrador = new Form2();
            administrador.ShowDialog();
        }
    }
}
