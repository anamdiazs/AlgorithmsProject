
namespace ProyectoFinal
{
	partial class FormArrEj5
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
			this.valor = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(59, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 38;
			this.label2.Text = "Tamaño:";
			// 
			// valor
			// 
			this.valor.Location = new System.Drawing.Point(114, 67);
			this.valor.Name = "valor";
			this.valor.Size = new System.Drawing.Size(108, 20);
			this.valor.TabIndex = 37;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Red;
			this.button1.Location = new System.Drawing.Point(228, 96);
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
			this.button7.Location = new System.Drawing.Point(114, 96);
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
			this.button4.Location = new System.Drawing.Point(228, 63);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(108, 27);
			this.button4.TabIndex = 34;
			this.button4.Text = "Ingresar";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(25, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(367, 43);
			this.label1.TabIndex = 33;
			this.label1.Text = "Determinar el tamaño de un arreglo unidimensional (Sin utilizar un método).";
			// 
			// FormArrEj5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(415, 152);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.valor);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.label1);
			this.Name = "FormArrEj5";
			this.Text = "FormArrEj5";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox valor;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label1;
	}
}