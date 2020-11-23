using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormFigurasAP
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

        private void PBCirculo_Click(object sender, EventArgs e)
        {
            Circulo CWindow = new Circulo();
            CWindow.Location = this.Location;
            CWindow.StartPosition = FormStartPosition.Manual;
            CWindow.FormClosing += delegate { this.Show(); };
            CWindow.Show();
            this.Hide();
        }

        private void PBTriangulo_Click(object sender, EventArgs e)
        {
            Triangulo TWindow = new Triangulo();
            TWindow.Location = this.Location;
            TWindow.StartPosition = FormStartPosition.Manual;
            TWindow.FormClosing += delegate { this.Show(); };
            TWindow.Show();
            this.Hide();
        }

        private void PBCuadrado_Click(object sender, EventArgs e)
        {
            Cuadrado CuWindow = new Cuadrado();
            CuWindow.Location = this.Location;
            CuWindow.StartPosition = FormStartPosition.Manual;
            CuWindow.FormClosing += delegate { this.Show(); };
            CuWindow.Show();
            this.Hide();
        }

        private void PBRectangualo_Click(object sender, EventArgs e)
        {
            Rectangulo RWindow = new Rectangulo();
            RWindow.Location = this.Location;
            RWindow.StartPosition = FormStartPosition.Manual;
            RWindow.FormClosing += delegate { this.Show(); };
            RWindow.Show();
            this.Hide();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
