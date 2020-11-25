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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form14 pentagono = new Form14();
            pentagono.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 inicial = new Form1();
            inicial.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 cuadrado = new Form7();
            cuadrado.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 circulo = new Form8();
            circulo.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 rectangulo = new Form9();
            rectangulo.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 triangulos = new Form10();
            triangulos.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form15 hexagono = new Form15();
            hexagono.Show();
            this.Hide();
        }
    }
}
