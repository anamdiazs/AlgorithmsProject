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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form12 triangulo2 = new Form12();
            triangulo2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form13 triangulo3 = new Form13();
            triangulo3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form11 triangulo1 = new Form11();
            triangulo1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 funciones = new Form6();
            funciones.Show();
            this.Close();
        }
    }
}
