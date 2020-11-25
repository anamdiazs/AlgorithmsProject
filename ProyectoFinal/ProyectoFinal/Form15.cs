﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Form15 : Form
    {
        double lado;
        double apotema;
        public Form15()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 funciones = new Form6();
            funciones.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lado = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Ingresa un número");

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                apotema = Convert.ToInt32(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Ingresa un número");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double area;
            area = (lado * 6 * apotema) / 2;
            MessageBox.Show("El area del hexagono es: " + area.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double perimetro;
            perimetro = (lado * 6);
            MessageBox.Show("El perimetro del hexagono es: " + perimetro.ToString());
        }
    }
}
