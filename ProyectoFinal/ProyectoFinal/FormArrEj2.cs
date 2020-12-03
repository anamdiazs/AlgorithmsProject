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
	public partial class FormArrEj2 : Form
	{
		public FormArrEj2()
		{
			InitializeComponent();
		}

		private void FormArrEj2_Load(object sender, EventArgs e)
		{

		}

		int[,] Matriz = new int[3, 4];

		private void button4_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					Matriz[i, j] = int.Parse(valor.Text);
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			label3.Text = (Matriz[0, 0] + "--" + Matriz[0, 1] + "--" +  Matriz[0, 2] + "--" + Matriz[0, 3] +
				"\n" + Matriz[1, 0] + "--" + Matriz[1, 1] + "--" + Matriz[1, 2] + "--" + Matriz[1, 3] +
				"\n" + Matriz[2, 0] + "--" + Matriz[2, 1] + "--" + Matriz[2, 2] + "--" + Matriz[2, 3]);
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
