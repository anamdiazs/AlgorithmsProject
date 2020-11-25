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
    public partial class Form9 : Form
    {
        double mbase;
        double altura;
        public Form9()
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
            double area = mbase * altura;
            MessageBox.Show("El area del rectangulo es: " + area.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double perimetro = 2 * mbase + 2 * altura;
            MessageBox.Show("El perimetro del rectangulo es: " + perimetro.ToString());
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
    }
}
