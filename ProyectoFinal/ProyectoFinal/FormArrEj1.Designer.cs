
namespace ProyectoFinal
{
	partial class FormArrEj1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.button7 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(326, 27);
			this.label1.TabIndex = 1;
			this.label1.Text = "Crear un arreglo unidimensional de tamaño 10 e insertar los primeros números natu" +
    "rales múltiplos de 2.";
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button4.Location = new System.Drawing.Point(120, 55);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(108, 27);
			this.button4.TabIndex = 20;
			this.button4.Text = "Ejecutar";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(117, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 166);
			this.label2.TabIndex = 21;
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.Red;
			this.button7.Location = new System.Drawing.Point(15, 262);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(108, 27);
			this.button7.TabIndex = 22;
			this.button7.Text = "Volver";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Red;
			this.button1.Location = new System.Drawing.Point(15, 295);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 27);
			this.button1.TabIndex = 23;
			this.button1.Text = "Salir";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FormArrEj1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(345, 334);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.label1);
			this.Name = "FormArrEj1";
			this.Text = "Ejercicio 1";
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button1;
	}
}