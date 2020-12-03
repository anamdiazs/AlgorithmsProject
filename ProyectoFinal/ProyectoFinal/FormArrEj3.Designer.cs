
namespace ProyectoFinal
{
	partial class FormArrEj3
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
			this.label2 = new System.Windows.Forms.Label();
			this.dim1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dim3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dim2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 38;
			this.label2.Text = "Dimensión X:";
			// 
			// dim1
			// 
			this.dim1.Location = new System.Drawing.Point(100, 71);
			this.dim1.Name = "dim1";
			this.dim1.Size = new System.Drawing.Size(108, 20);
			this.dim1.TabIndex = 37;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Red;
			this.button1.Location = new System.Drawing.Point(278, 287);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 27);
			this.button1.TabIndex = 36;
			this.button1.Text = "Salir";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.Red;
			this.button7.Location = new System.Drawing.Point(278, 254);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(108, 27);
			this.button7.TabIndex = 35;
			this.button7.Text = "Volver";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button4.Location = new System.Drawing.Point(100, 199);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(108, 27);
			this.button4.TabIndex = 34;
			this.button4.Text = "Guardar";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(25, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(350, 43);
			this.label1.TabIndex = 33;
			this.label1.Text = "Crear un arreglo de tres dimensiones pidiendo al usuario que determine el tamaño " +
    "de cada dimensión del arreglo.";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(25, 162);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 13);
			this.label3.TabIndex = 40;
			this.label3.Text = "Dimensión Z:";
			// 
			// dim3
			// 
			this.dim3.Location = new System.Drawing.Point(100, 159);
			this.dim3.Name = "dim3";
			this.dim3.Size = new System.Drawing.Size(108, 20);
			this.dim3.TabIndex = 39;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(25, 116);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 13);
			this.label4.TabIndex = 42;
			this.label4.Text = "Dimensión Y:";
			// 
			// dim2
			// 
			this.dim2.Location = new System.Drawing.Point(100, 113);
			this.dim2.Name = "dim2";
			this.dim2.Size = new System.Drawing.Size(108, 20);
			this.dim2.TabIndex = 41;
			// 
			// FormArrEj3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(398, 326);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dim2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dim3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dim1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.label1);
			this.Name = "FormArrEj3";
			this.Text = "FormArrEj3";
			this.Load += new System.EventHandler(this.FormArrEj3_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox dim1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox dim3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox dim2;
	}
}