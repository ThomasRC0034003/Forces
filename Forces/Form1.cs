﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forces
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

        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }

        double asin(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);
        }

        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double angle = double.Parse(textBox2.Text);
                double F = double.Parse(textBox1.Text);

                double Fx = F * cos(angle);
                double Fy = F * sin(angle);

                MessageBox.Show("Fx = " + Fx.ToString("N3") + " N" + "\n" + "Fy = " + Fy.ToString("N3") + " N");
            }
            catch
            {
                MessageBox.Show("Error");
            }

            
        }
        private void label1_Click(object sender, EventArgs e)
        {
  
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
