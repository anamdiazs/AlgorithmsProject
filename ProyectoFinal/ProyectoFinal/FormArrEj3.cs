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
	public partial class FormArrEj3 : Form
	{
		public FormArrEj3()
		{
			InitializeComponent();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int x, y, z;
			x = int.Parse(dim1.Text);
			y = int.Parse(dim2.Text);
			z = int.Parse(dim3.Text);

			int[,,] Arreglo = new int[x,y,z];

			MessageBox.Show("Arreglo de 3 dimensiones creado!");
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

		private void FormArrEj3_Load(object sender, EventArgs e)
		{

		}
	}
}
