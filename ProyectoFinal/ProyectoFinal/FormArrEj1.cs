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
	public partial class FormArrEj1 : Form
	{
		public FormArrEj1()
		{
			InitializeComponent();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int[] Numeros = new int[10];

			for (int i = 0; i < Numeros.Length; i++)
			{
				Numeros[i] = i * 2;
			}

			//Imprimir
			
			label2.Text = (0 + " -> " + Numeros[0] +
				"\n" + 1 + " -> " + Numeros[1] +
				"\n" + 2 + " -> " + Numeros[2] +
				"\n" + 3 + " -> " + Numeros[3] +
				"\n" + 4 + " -> " + Numeros[4] +
				"\n" + 5 + " -> " + Numeros[5] +
				"\n" + 6 + " -> " + Numeros[6] +
				"\n" + 7 + " -> " + Numeros[7] +
				"\n" + 8 + " -> " + Numeros[8] +
				"\n" + 9 + " -> " + Numeros[9]);

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
