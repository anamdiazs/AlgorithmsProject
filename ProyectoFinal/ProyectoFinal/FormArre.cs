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
	public partial class FormArre : Form
	{
		public FormArre()
		{
			InitializeComponent();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			FormArreglos arreglos = new FormArreglos();
			arreglos.Show();
			this.Hide();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			Form1 inicial = new Form1();
			inicial.Show();
			this.Hide();
		}
	}
}
