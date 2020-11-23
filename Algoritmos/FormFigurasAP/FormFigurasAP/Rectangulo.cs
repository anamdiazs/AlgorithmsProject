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
    public partial class Rectangulo : Form
    {
        public Rectangulo()
        {
            InitializeComponent();
        }

        private void RBSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RBCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, area = 0, perimetro = 0;
            num1 = double.Parse(tBRAltura.Text);
            num2 = double.Parse(tBRBase.Text);

            area = num1 * num2;
            perimetro = 2 * num1 + 2 * num2;

            lRRArea.Text = area.ToString();
            lRRPerimetro.Text = perimetro.ToString();
        }
    }
}
