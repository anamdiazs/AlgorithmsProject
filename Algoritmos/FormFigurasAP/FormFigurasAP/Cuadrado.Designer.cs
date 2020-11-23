namespace FormFigurasAP
{
    partial class Cuadrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cuadrado));
            this.lCuRPerimetro = new System.Windows.Forms.Label();
            this.lCuRArea = new System.Windows.Forms.Label();
            this.CuBCalcular = new System.Windows.Forms.Button();
            this.lCuPerimetro = new System.Windows.Forms.Label();
            this.lCuArea = new System.Windows.Forms.Label();
            this.tBCuLado = new System.Windows.Forms.TextBox();
            this.lCuLado = new System.Windows.Forms.Label();
            this.CuBSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lCuRPerimetro
            // 
            this.lCuRPerimetro.AutoSize = true;
            this.lCuRPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCuRPerimetro.Location = new System.Drawing.Point(401, 273);
            this.lCuRPerimetro.Name = "lCuRPerimetro";
            this.lCuRPerimetro.Size = new System.Drawing.Size(0, 29);
            this.lCuRPerimetro.TabIndex = 26;
            // 
            // lCuRArea
            // 
            this.lCuRArea.AutoSize = true;
            this.lCuRArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCuRArea.Location = new System.Drawing.Point(401, 201);
            this.lCuRArea.Name = "lCuRArea";
            this.lCuRArea.Size = new System.Drawing.Size(0, 29);
            this.lCuRArea.TabIndex = 25;
            // 
            // CuBCalcular
            // 
            this.CuBCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CuBCalcular.Location = new System.Drawing.Point(544, 103);
            this.CuBCalcular.Name = "CuBCalcular";
            this.CuBCalcular.Size = new System.Drawing.Size(113, 43);
            this.CuBCalcular.TabIndex = 22;
            this.CuBCalcular.Text = "Calcular";
            this.CuBCalcular.UseVisualStyleBackColor = true;
            this.CuBCalcular.Click += new System.EventHandler(this.CuBCalcular_Click);
            // 
            // lCuPerimetro
            // 
            this.lCuPerimetro.AutoSize = true;
            this.lCuPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCuPerimetro.Location = new System.Drawing.Point(204, 273);
            this.lCuPerimetro.Name = "lCuPerimetro";
            this.lCuPerimetro.Size = new System.Drawing.Size(125, 29);
            this.lCuPerimetro.TabIndex = 21;
            this.lCuPerimetro.Text = "Perímetro:";
            // 
            // lCuArea
            // 
            this.lCuArea.AutoSize = true;
            this.lCuArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCuArea.Location = new System.Drawing.Point(204, 201);
            this.lCuArea.Name = "lCuArea";
            this.lCuArea.Size = new System.Drawing.Size(69, 29);
            this.lCuArea.TabIndex = 20;
            this.lCuArea.Text = "Área:";
            // 
            // tBCuLado
            // 
            this.tBCuLado.Location = new System.Drawing.Point(332, 111);
            this.tBCuLado.Name = "tBCuLado";
            this.tBCuLado.Size = new System.Drawing.Size(100, 29);
            this.tBCuLado.TabIndex = 19;
            // 
            // lCuLado
            // 
            this.lCuLado.AutoSize = true;
            this.lCuLado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCuLado.Location = new System.Drawing.Point(290, 44);
            this.lCuLado.Name = "lCuLado";
            this.lCuLado.Size = new System.Drawing.Size(179, 29);
            this.lCuLado.TabIndex = 18;
            this.lCuLado.Text = "Ingresa el Lado";
            // 
            // CuBSalir
            // 
            this.CuBSalir.AutoSize = true;
            this.CuBSalir.Location = new System.Drawing.Point(687, 395);
            this.CuBSalir.Name = "CuBSalir";
            this.CuBSalir.Size = new System.Drawing.Size(101, 43);
            this.CuBSalir.TabIndex = 17;
            this.CuBSalir.Text = "Regresar";
            this.CuBSalir.UseVisualStyleBackColor = true;
            this.CuBSalir.Click += new System.EventHandler(this.CuBSalir_Click);
            // 
            // Cuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lCuRPerimetro);
            this.Controls.Add(this.lCuRArea);
            this.Controls.Add(this.CuBCalcular);
            this.Controls.Add(this.lCuPerimetro);
            this.Controls.Add(this.lCuArea);
            this.Controls.Add(this.tBCuLado);
            this.Controls.Add(this.lCuLado);
            this.Controls.Add(this.CuBSalir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cuadrado";
            this.Text = "Cuadrado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCuRPerimetro;
        private System.Windows.Forms.Label lCuRArea;
        private System.Windows.Forms.Button CuBCalcular;
        private System.Windows.Forms.Label lCuPerimetro;
        private System.Windows.Forms.Label lCuArea;
        private System.Windows.Forms.TextBox tBCuLado;
        private System.Windows.Forms.Label lCuLado;
        private System.Windows.Forms.Button CuBSalir;
    }
}