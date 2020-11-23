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
    public partial class Circulo : Form
    {
        public Circulo()
        {
            InitializeComponent();
        }

        private void lCPerimetro_Click(object sender, EventArgs e)
        {

        }

        private void CBSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBCalcular_Click(object sender, EventArgs e)
        {
            double num1, area = 0, perimetro = 0;
            num1 = double.Parse(tBCRadio.Text);

            area = Math.PI * num1 * num1;
            perimetro = 2 * Math.PI * num1;

            lCRArea.Text = area.ToString();
            lCRPerimetro.Text = perimetro.ToString();
        }
    }
}
