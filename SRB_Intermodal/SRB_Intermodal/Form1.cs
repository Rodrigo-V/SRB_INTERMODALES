﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRB_Intermodal
{
    public partial class Registro1 : Form
    {
        public Registro1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            radLabel2.Text = DateTime.Now.ToShortDateString();
            


        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
           
        }

        private void radLabel1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           radLabel1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
