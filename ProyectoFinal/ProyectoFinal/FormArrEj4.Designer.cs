
namespace ProyectoFinal
{
	partial class FormArrEj4
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
			this.button2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button2.Location = new System.Drawing.Point(141, 129);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(108, 27);
			this.button2.TabIndex = 40;
			this.button2.Text = "Invertir Arreglo";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 13);
			this.label2.TabIndex = 38;
			this.label2.Text = "Arreglo Original: ";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Red;
			this.button1.Location = new System.Drawing.Point(285, 257);
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
			this.button7.Location = new System.Drawing.Point(171, 257);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(108, 27);
			this.button7.TabIndex = 35;
			this.button7.Text = "Volver";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(25, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(392, 25);
			this.label1.TabIndex = 33;
			this.label1.Text = "Invertir el orden del arreglo descrito en el ejercicio 1 (Sin utilizar un método)" +
    ".";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(52, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 139);
			this.label3.TabIndex = 41;
			this.label3.Text = "0 -> 0 1 -> 2 2 -> 4 3 -> 6 4 -> 8 5 -> 10 6 -> 12 7 -> 14 8 -> 16 9 -> 18";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(308, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 139);
			this.label4.TabIndex = 43;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(288, 81);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 13);
			this.label5.TabIndex = 42;
			this.label5.Text = "Arreglo Invertido: ";
			// 
			// FormArrEj4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(405, 296);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.label1);
			this.Name = "FormArrEj4";
			this.Text = "FormArrEj4";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}