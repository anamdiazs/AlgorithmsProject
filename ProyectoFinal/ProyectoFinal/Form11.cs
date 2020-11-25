using System;
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
    public partial class Form11 : Form
    {
        double altura;
        double mbase;
        public Form11()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mbase = Convert.ToInt32(textBox1.Text);
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
                altura = Convert.ToInt32(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Ingresa un número");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double area;
            area = (mbase * altura) / 2;
            MessageBox.Show("El area del triangulo es: " + area.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double perimetro;
            perimetro = mbase * 3;
            MessageBox.Show("El perimetro del triangulo es: " + perimetro.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form10 triangulos = new Form10();
            triangulos.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
