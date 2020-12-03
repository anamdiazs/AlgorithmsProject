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
	public partial class FormArrEj6 : Form
	{
		public FormArrEj6()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int tam = 0, d1 = int.Parse(valor.Text), d2 = int.Parse(textBox1.Text);

			int[,] arreglo = new int[d1, d2];

			for (int i = 0; i < d1; i++)
			{
				for (int j = 0; j < d2; j++)
				{
					tam++;
				}
			}

			MessageBox.Show("Arreglo bidimensional de [" + d1 + ", " + d2 + "] tiene: " + tam + " posiciones!");
		}

		private void button7_Click(object sender, EventArgs e)
		{
			FormArreglos volver = new FormArreglos();
			volver.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
