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
    public partial class Form12 : Form
    {

        double altura;
        double mlado1;
        double mlado2;
        double mlado3;
        public Form12()
        {
            InitializeComponent();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mlado1 = Convert.ToInt32(textBox1.Text);
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
                mlado2 = Convert.ToInt32(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Ingresa un número");

            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                altura = Convert.ToInt32(textBox3.Text);

            }
            catch
            {
                MessageBox.Show("Ingresa un número");

            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mlado3 = Convert.ToInt32(textBox4.Text);
            }
            catch
            {
                MessageBox.Show("Ingresa un número");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (mlado2 == mlado1 || mlado2 == mlado3 || mlado3 == mlado1)
            {
                MessageBox.Show("No puede haber lados iguales en este tipo de triangulo");

            }
            else
            {
                double area;
                area = (mlado3 * altura) / 2;
                MessageBox.Show("El area del triangulo es: " + area.ToString());
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mlado2 == mlado1 || mlado2 == mlado3 || mlado3 == mlado1)
            {
                MessageBox.Show("No puede haber lados iguales en este tipo de triangulo");

            }
            else
            {
                double perimetro;
                perimetro = mlado1 + mlado2 + mlado3;
                MessageBox.Show("El perimetro del triangulo es: " + perimetro.ToString());
            }
        }

		private void Form12_Load(object sender, EventArgs e)
		{

		}
	}
}
