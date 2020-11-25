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
    public partial class Form7 : Form
    {

        double lado;
        public Form7()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            double area;
            area = lado * lado;
            MessageBox.Show("El area del cuadrado es: " + area.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double perimetro;
            perimetro = lado * 4;
            MessageBox.Show("El perimetro del cuadrado es: " + perimetro.ToString());
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
