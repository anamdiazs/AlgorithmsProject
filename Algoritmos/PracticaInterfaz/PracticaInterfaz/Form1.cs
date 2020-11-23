using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaInterfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LNumero1_Click(object sender, EventArgs e)
        {

        }

        private void BResultado_Click(object sender, EventArgs e)
        {
            int Num1, Num2, Resultado = 0;
            char Operador;
            Num1 = int.Parse(TNum1.Text);
            Num2 = int.Parse(TNum2.Text);
            Operador = char.Parse(LiOperador.Text);

            if (Operador == '+')
            {
                Resultado = Num1 + Num2;
            }
            if (Operador == '-')
                Resultado = Num1 - Num2;
            if (Operador == '*')
                Resultado = Num1 * Num2;
            if (Operador == '/')
                Resultado = Num1 / Num2;

            LResultado.Text = Resultado.ToString();
            MessageBox.Show(Resultado.ToString());
        }

        private void BAbrir_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            //F2.Show();

            //var frm = new Form2();
            F2.Location = this.Location;
            F2.StartPosition = FormStartPosition.Manual;
            F2.FormClosing += delegate { this.Show(); };
            F2.Show();
            this.Hide();
        }
    }
}
