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
    public partial class Form8 : Form
    {
        double radio;
        double pi = 3.1416;

        public Form8()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            radio = Convert.ToInt32(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double area;
            area = pi * (radio * radio);
            MessageBox.Show("El area del circulo es: " + area.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double perimetro;
            perimetro = 2 * pi * radio;
            MessageBox.Show("El perimetro del circulo es: " + perimetro.ToString());
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
