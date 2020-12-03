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
	public partial class FormArreglos : Form
	{
		public FormArreglos()
		{
			InitializeComponent();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			FormArre ey = new FormArre();
			ey.Show();
			this.Hide();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			FormArrEj1 ej1 = new FormArrEj1();
			ej1.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FormArrEj2 ej2 = new FormArrEj2();
			ej2.Show();
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			FormArrEj3 ej3 = new FormArrEj3();
			ej3.Show();
			this.Hide();
		}

		private void button14_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			FormArrEj4 ej4 = new FormArrEj4();
			ej4.Show();
			this.Hide();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			FormArrEj5 ej5 = new FormArrEj5();
			ej5.Show();
			this.Hide();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			FormArrEj6 ej6 = new FormArrEj6();
			ej6.Show();
			this.Hide();
		}

		private void button6_Click(object sender, EventArgs e)
		{

		}
	}
}
