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
    public partial class Triangulo : Form
    {
        public Triangulo()
        {
            InitializeComponent();
        }
        private void Triangulo_Load(object sender, EventArgs e)
        {

        }

        private void TBSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TBCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, area = 0, perimetro = 0;
            num1 = double.Parse(tBTAltura.Text);
            num2 = double.Parse(tBTBase.Text);

            area = (num1 * num2) / 2;
            perimetro = 3 * num2;

            lTRArea.Text = area.ToString();
            lTRPerimetro.Text = perimetro.ToString();
        }
    }
}
