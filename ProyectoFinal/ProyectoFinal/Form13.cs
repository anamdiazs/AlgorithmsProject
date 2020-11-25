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
    public partial class Form13 : Form
    {
        double altura;
        double mbase;
        double mlado;
        public Form13()
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mlado = Convert.ToInt32(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Ingresa un número");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(mbase == mlado){
                MessageBox.Show("La base no puede ser igual al valor de los otros dos lados en este tipo de triangulo");

            }
            else
            {
                double area;
                area = (mbase * altura) / 2;
                MessageBox.Show("El area del triangulo es: " + area.ToString());
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mbase == mlado)
            {
                MessageBox.Show("La base no puede ser igual al valor de los otros dos lados en este tipo de triangulo");

            }
            else
            {
                double perimetro;
                perimetro = (mlado * 2) + mbase;
                MessageBox.Show("El perimetro del triangulo es: " + perimetro.ToString());
            }
        }
    }
}
