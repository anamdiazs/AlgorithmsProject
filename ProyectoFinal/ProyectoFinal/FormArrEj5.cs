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
	public partial class FormArrEj5 : Form
	{
		public FormArrEj5()
		{
			InitializeComponent();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int tam1 = 0, tam = int.Parse(valor.Text);

			int[] arreglo = new int[tam];

			for (int i = 0; i < tam; i++)
			{
				tam1++;
			}

			MessageBox.Show("El arreglo tiene un tamaño de: " + tam1 + " posiciones!");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			FormArreglos volver = new FormArreglos();
			volver.Show();
			this.Hide();
		}
	}
}
